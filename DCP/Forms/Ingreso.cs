using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;

namespace DCP.Forms
{
    public partial class Ingreso : Form
    {
        private SqlConnection cn;
        public string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"]?.ConnectionString;
        private TotalDeCierre frmtotaldecierre;
        public string fechaingreso { get; set; }
        public string rutadestino { get; set; }

        public Ingreso()
        {
            InitializeComponent();
            txtConcepto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void Ingreso_Load(object sender, EventArgs e)
        {
            dtpIngreso.Value = DateTime.Now;
            this.cmbDestinatario.DroppedDown = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                GuardarEnDatagridview();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void LimpiarFormularioIngreso()
        {
            cbCambiarFecha.Checked = false;
            dtpIngreso.Enabled = false;
            dtpIngreso.Value = DateTime.Now;
            dgvIngreso.Rows.Clear();
            Ingreso_Clear();
        }
        public void CerrarPictureBox()
        {
            if (pbArchivo.Image != null)
            {
                pbArchivo.Image.Dispose();
                pbArchivo.Image = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            pArchivo.Enabled = false;
            pArchivo.Visible = false;
            pbArchivo.Visible = false;
            pbArchivo.Enabled = false;
        }

        public void Ingreso_Clear()
        {
            dtpIngreso.Value = DateTime.Now;
            dtpIngreso.Enabled = false;
            cbCambiarFecha.Checked = false;
            cbArchivoMultimedia.Checked = false;
            rutadestino = "";
            lblArchivo.Text = "No se ha seleccionado ningún archivo";
            cmbDestinatario.SelectedItem = null;
            txtConcepto.Clear();
            txtDetalle.Clear();
            cmbMetododepago.SelectedItem = null;
            txtEfectivodecaja.Text = "0.00";
            txtReserva.Text = "0.00";
            cmbDestinatario.Focus();
            txtObservacion.Text = "";
        }

        public decimal SumarEfectivo()
        {
            int y;
            decimal totalefectivo = 0;
            for (y = 0; y < dgvIngreso.Rows.Count; y++)
            {
                decimal efectivo = Convert.ToDecimal(dgvIngreso.Rows[y].Cells[4].Value);
                totalefectivo += efectivo;
            }
            return totalefectivo;
        }
        public int g = 0;
        public void GuardarIngreso()
        {
            CerrarPictureBox();
            int idcierre = frmtotaldecierre.IdCierre;
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                for ( g = g ; g < dgvIngreso.Rows.Count; g++)
                {
                    SqlCommand cmdg = new SqlCommand("GuardarDatosIngreso", cn);
                    cmdg.CommandType = CommandType.StoredProcedure;

                    cmdg.Parameters.AddWithValue("@Destinatario", this.dgvIngreso.Rows[g].Cells[0].Value);
                    cmdg.Parameters.AddWithValue("@Concepto", this.dgvIngreso.Rows[g].Cells[1].Value);
                    cmdg.Parameters.AddWithValue("@Detalle", this.dgvIngreso.Rows[g].Cells[2].Value);
                    cmdg.Parameters.AddWithValue("@MetodoDePago", this.dgvIngreso.Rows[g].Cells[3].Value);
                    cmdg.Parameters.AddWithValue("@EfectivoCaja", this.dgvIngreso.Rows[g].Cells[4].Value);
                    cmdg.Parameters.AddWithValue("@Reserva", this.dgvIngreso.Rows[g].Cells[5].Value);
                    cmdg.Parameters.AddWithValue("@Total", this.dgvIngreso.Rows[g].Cells[6].Value);
                    cmdg.Parameters.AddWithValue("@ObservacionIngreso", this.dgvIngreso.Rows[g].Cells[7].Value);
                    cmdg.Parameters.AddWithValue("@IDCierreDeCaja", idcierre);
                    cmdg.Parameters.AddWithValue("@Ruta", this.dgvIngreso.Rows[g].Cells[8].Value);


                    int idingreso = Convert.ToInt32(cmdg.ExecuteScalar());
                    if (this.dgvIngreso.Rows[g].Cells[8].Value == "Sin Imagen")
                    {
                       string nuevoarchivo = "Sin Imagen";
                    }
                    else
                    {
                        string archivo = this.dgvIngreso.Rows[g].Cells[8].Value.ToString();
                        if (File.Exists(archivo))
                        {
                            string nombreimagen = $"{idcierre}_{idingreso}";
                            string carpeta = Path.GetDirectoryName(archivo);
                            string extension = Path.GetExtension(archivo);
                            string nuevoarchivo = Path.Combine(carpeta, nombreimagen + extension);
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            File.Move(archivo, nuevoarchivo);

                            string sqlUpdate = @"UPDATE Ingreso set Ruta = @Ruta where IDCierreDeCaja = @IDCierreDeCaja and IDingreso = @IDingreso";
                            using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@Ruta", nuevoarchivo);
                                cmdUpdate.Parameters.AddWithValue("@IDCierreDeCaja", idcierre);
                                cmdUpdate.Parameters.AddWithValue("@IDingreso", idingreso);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                Ingreso_Clear();
                this.dgvIngreso.Rows.Clear();
            }
            g = 0;
        }
        
        public void EliminarImagenes()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            dtpIngreso.Value = DateTime.Now;
            cbCambiarFecha.Checked = false;

            if (pbArchivo.Image != null)
            {
                pbArchivo.Image.Dispose();
                pbArchivo.Image = null;
            }

            if (File.Exists(rutadestino))
            {
                File.Delete(rutadestino);
            }

            for (int Z = 0; Z < dgvIngreso.Rows.Count; Z++)
            {
                string recolectarimagenes = dgvIngreso.Rows[Z].Cells[8].Value.ToString();
                try
                {
                    File.Delete(recolectarimagenes);
                }
                catch { }
            }
        }
        public void LimpiarFormulario()
        {
            if (pbArchivo.Image != null)
            {
                pbArchivo.Image = Image.FromFile(rutadestino);
                pbArchivo.Image.Dispose();
                pbArchivo.Image = null;
            }
            Ingreso_Clear();
            dgvIngreso.Rows.Clear();
        }

        public void GuardarEnDatagridview()
        {
            if (!decimal.TryParse(txtEfectivodecaja.Text, out _) ||
    !decimal.TryParse(txtReserva.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en los campos de efectivo de caja y reserva.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtEfectivodecaja.Focus();
                this.txtEfectivodecaja.Text = "0.00";
                this.txtReserva.Text = "0.00";
                return;
            }
            if (string.IsNullOrWhiteSpace(rutadestino))
            {
                rutadestino = "Sin Imagen";
            }
            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                this.txtObservacion.Text = "Sin Observación";
            }

            if (this.cmbDestinatario.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(this.txtConcepto.Text) &&
                !string.IsNullOrWhiteSpace(this.txtDetalle.Text) &&
                this.cmbMetododepago.SelectedItem != null)
            {
                dgvIngreso.Rows.Add(
                    cmbDestinatario.SelectedItem.ToString(),
                    txtConcepto.Text,
                    txtDetalle.Text,
                    cmbMetododepago.SelectedItem,
                    txtEfectivodecaja.Text,
                    txtReserva.Text,
                    Convert.ToDecimal(txtEfectivodecaja.Text) + Convert.ToDecimal(txtReserva.Text),
                    txtObservacion.Text,
                    rutadestino.ToString());
                Ingreso_Clear();
                this.cbArchivoMultimedia.Checked = false;

                int x;
                decimal Montototal = 0;
                for (x = 0; x < dgvIngreso.Rows.Count; x++)
                {
                    decimal totales = Convert.ToDecimal(dgvIngreso.Rows[x].Cells[6].Value);
                    Montototal += totales;
                }
                this.txtMontototal.Text = Montototal.ToString("0.00");
                rutadestino = "";
                lblArchivo.Text = "No se ha seleccionado ningún archivo";
                this.pbArchivo.Image = null;
                this.txtEfectivodecaja.Text = "0.00";
                this.txtReserva.Text = "0.00";

                return;
            }

            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SeleccionarImagen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string carpeta = Path.Combine(Application.StartupPath, "Imágenes");
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                string nombreArchivo = Path.GetFileName(ofd.FileName);

                rutadestino = Path.Combine(carpeta, nombreArchivo);

                if (!File.Exists(rutadestino))
                {
                    File.Copy(ofd.FileName, rutadestino, true);
                    this.cbArchivoMultimedia.Checked = true;
                    this.lblArchivo.Text = nombreArchivo;
                }
                else
                {
                    MessageBox.Show("No puedes usar esta imagen otra vez. \nPorfavor seleccione otra imagen", "Imagen duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rutadestino = "";
                    return;
                }
            }
        }

        private void cbCambiarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCambiarFecha.Checked)
            {
                dtpIngreso.Value = DateTime.Now;
                dtpIngreso.Enabled = false;
            }
            else
            {
                dtpIngreso.Enabled = true;
            }
        }

        public void cmbDestinatario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtConcepto.Focus();
        }

        private void txtConcepto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.txtDetalle.Focus();

                    break;
            }
        }

        private void txtDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.cmbMetododepago.DroppedDown = true;
                    this.cmbMetododepago.Focus();
                    break;
            }
        }


        private void cmbMetododepago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtEfectivodecaja.Focus();
        }
        private void txtEfectivodecaja_Enter(object sender, EventArgs e)
        {
            this.txtEfectivodecaja.SelectAll();
        }

        private void txtEfectivodecaja_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.txtReserva.Focus();
                    break;
            }
        }
        private void txtEfectivodecaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (this.txtEfectivodecaja.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        private void txtEfectivodecaja_Leave(object sender, EventArgs e)
        {
            if (this.txtEfectivodecaja.Text == "")
            {
                this.txtEfectivodecaja.Text = "0.00";
            }
        }

        private void txtReserva_Enter(object sender, EventArgs e)
        {
            this.txtReserva.SelectAll();
        }

        private void txtReserva_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GuardarEnDatagridview();
                    break;

            }
        }

        private void txtReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (this.txtReserva.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        private void txtReserva_Leave(object sender, EventArgs e)
        {
            if (this.txtReserva.Text == "")
            {
                this.txtReserva.Text = "0.00";
            }
        }
        private void txtObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GuardarEnDatagridview();
                    break;

            }
        }

        private void dgvIngreso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CerrarPictureBox();
            if (dgvIngreso.CurrentRow == null)
            {
                MessageBox.Show("No hay registros para editar.", "Editar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
 
             DialogResult editarregistro = MessageBox.Show($"Desea editar el registro? \nDeberá seleccionar nuevamente la imagen de la factura", "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
             if (editarregistro == DialogResult.Yes)
             {
                if (File.Exists(rutadestino))
                { 
                    pbArchivo.Image = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(rutadestino);
                    rutadestino = "";
                    this.cbArchivoMultimedia.Checked = false;
                    this.lblArchivo.Text = "Se ha eliminado la imagen seleccionada recientemente.";
                    MessageBox.Show("Se ha eliminado una imagen almacenada. \nLa última imagen que se seleccionó ha sido eliminada para evitar llenar el almacenamiento de forma innecesaria.", "Imagen eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }
                this.cmbDestinatario.SelectedItem = dgvIngreso.CurrentRow.Cells[0].Value.ToString();
                this.txtConcepto.Text = dgvIngreso.CurrentRow.Cells[1].Value.ToString();
                this.txtDetalle.Text = dgvIngreso.CurrentRow.Cells[2].Value.ToString();
                this.cmbMetododepago.SelectedItem = dgvIngreso.CurrentRow.Cells[3].Value.ToString();
                this.txtEfectivodecaja.Text = dgvIngreso.CurrentRow.Cells[4].Value.ToString();
                this.txtReserva.Text = dgvIngreso.CurrentRow.Cells[5].Value.ToString();
                this.txtObservacion.Text = dgvIngreso.CurrentRow.Cells[7].Value.ToString();
                this.cbArchivoMultimedia.Checked = false;
                string rutaArchivo = dgvIngreso.CurrentRow.Cells[8].Value.ToString();
                  if (!string.IsNullOrEmpty(rutaArchivo))
                  {
                    CerrarPictureBox();
                    this.pbArchivo.Image = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                      File.Delete(rutaArchivo);
                  }
                   dgvIngreso.Rows.RemoveAt(dgvIngreso.CurrentRow.Index);
                   rutadestino = "";
                
             }
        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            DialogResult cancelaroperacion = MessageBox.Show($"Se eliminarán todos los datos ingresados, esta acción no se puede deshacer. \nDesea continuar?", "Eliminar datos ingresados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cancelaroperacion == DialogResult.Yes)
            {
                EliminarImagenes();
                Ingreso_Clear();
                dgvIngreso.Rows.Clear();
            }
        }

        private void btnLimpiarEntradas_Click(object sender, EventArgs e)
        {
            Ingreso_Clear();
        }
        //error: ingreso imagen en dgv, vuelvo a seleccionar varias veces la misma imagen y me borra la que se supone ya esta guardada en el dgv
        public void btnMultimedia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rutadestino))
            {
                DialogResult imagencargada = MessageBox.Show("Hay una imagen seleccionada \nQuieres seleccionar otra imagen?", "Imagen cargada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (imagencargada == DialogResult.Yes)
                {
                    CerrarPictureBox();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(rutadestino);
                    rutadestino = null;
                    cbArchivoMultimedia.Checked = false;
                    lblArchivo.Text = "No se ha seleccionado ningún archivo";
                    SeleccionarImagen();
                }
            }
            else
            {
                SeleccionarImagen();
            }
        }
        private void cbArchivoMultimedia_Click(object sender, EventArgs e)
        {
            this.cbArchivoMultimedia.Checked = !this.cbArchivoMultimedia.Checked;
            if (this.pArchivo.Enabled == true && this.pArchivo.Visible == true && this.pbArchivo.Visible == true)
            {
                this.pbArchivo.Image = null;
                this.pArchivo.Enabled = false;
                this.pArchivo.Visible = false;
                this.pbArchivo.Visible = false;
                this.pbArchivo.Enabled = false;
                return;
            }
            if (!string.IsNullOrEmpty(rutadestino))
            {
                if (File.Exists(rutadestino))
                {
                    using (Image img = Image.FromFile(rutadestino))
                    {
                        pbArchivo.Image = new Bitmap(img);
                    }
                    this.pArchivo.Enabled = true;
                    this.pArchivo.Visible = true;
                    this.pbArchivo.Visible = true;
                    pArchivo.BringToFront();
                    pArchivo.Focus();
                    pbArchivo.Image = new Bitmap(rutadestino);
                    pbArchivo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("No hay ninguna imagen contenida", "Imagen inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Aún no se ha seleccionado ninguna imagen.", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvIngreso.RowCount == 0)
            {
                MessageBox.Show("No hay datos para guardar", "No se detectaron datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fechaingreso = dtpIngreso.Value.ToString("yyyy-MM-dd");

                if (frmtotaldecierre != null && !frmtotaldecierre.IsDisposed)
                {
                    frmtotaldecierre.BringToFront();
                    frmtotaldecierre.Focus();
                    return;
                }

                frmtotaldecierre = new TotalDeCierre(this);
                frmtotaldecierre.StartPosition = FormStartPosition.CenterScreen;
                frmtotaldecierre.ShowDialog();
                frmtotaldecierre = null;
            }

        }

        private void pbArchivo_Click(object sender, EventArgs e)
        {
            pArchivo.Enabled = false;
        }
    }
}

