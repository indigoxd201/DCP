using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCP.Forms
{
    public partial class Registros : Form
    {
        public string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"]?.ConnectionString;
        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dtpFechaDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
            string fechadesde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            int ultimoDia = DateTime.DaysInMonth(hoy.Year, hoy.Month);
            dtpFechaHasta.Value = new DateTime(hoy.Year, hoy.Month, ultimoDia);
            string fechahasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd");
            CargarCierreCajaRegistro();
        }
        public void CargarCierreCajaRegistro()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string fechadesde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
                string fechahasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd");
                cn.Open();
                string sql = "select IDCierreDeCaja, Fecha, TotalSistema, TotalCaja, TipoDiferencia, Diferencia, ObservacionCierreDeCaja from CierreDeCaja WHERE Fecha BETWEEN @Desde AND @Hasta";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Desde", fechadesde);
                cmd.Parameters.AddWithValue("@Hasta", fechahasta);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clIDCierre.DataPropertyName = "IDCierreDeCaja";
                clFecha.DataPropertyName = "Fecha";
                clTotalSistema.DataPropertyName = "TotalSistema";
                clTotalCaja.DataPropertyName = "TotalCaja";
                clTipoDiferencia.DataPropertyName = "TipoDiferencia";
                clDiferencia.DataPropertyName = "Diferencia";
                clObservacionCierre.DataPropertyName = "ObservacionCierreDeCaja";
                dgvCierreCajaRegistro.DataSource = dt;
            }
        }

        public void CerrarImagen()
        {
            pbImagen.Enabled = false;
            pbImagen.Visible = false;
            pbImagen.Image = null;
        }

        private void dgvCierreCajaRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcierre = Convert.ToString(dgvCierreCajaRegistro.CurrentRow.Cells[0].Value);

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                string cmd = "select IDingreso,Destinatario,Concepto,Detalle,MetodoDePago,EfectivoCaja,Reserva,ObservacionIngreso,Ruta,IDCierreDeCaja FROM Ingreso where IDCierreDeCaja = " + idcierre;

                SqlDataAdapter da = new SqlDataAdapter(cmd, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clIDIngreso.DataPropertyName = "IDingreso";
                clIDCierreCaja.DataPropertyName = "IDCierreDeCaja";
                clDestinatario.DataPropertyName = "Destinatario";
                clConcepto.DataPropertyName = "Concepto";
                clDetalle.DataPropertyName = "Detalle";
                clMetodoDePago.DataPropertyName = "MetodoDePago";
                clEfectivoCaja.DataPropertyName = "EfectivoCaja";
                clReserva.DataPropertyName = "Reserva";
                clObservacionIngreso.DataPropertyName = "ObservacionIngreso";
                clRuta.DataPropertyName = "Ruta";
                dgvIngresoRegistro.DataSource = dt;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.cbTipoDiferencia.SelectedItem = null;
            this.txtTotalSistema.Text = "0.00";
            this.txtTotalCaja.Text = "0.00";
            CargarCierreCajaRegistro();
            dtOriginal = (DataTable)dgvCierreCajaRegistro.DataSource;
            if (dtOriginal != null)
            {
                dtOriginal = dtOriginal.Copy();
            }
        }

        private void btnVerFoto_Click(object sender, EventArgs e)
        {
            if (pbImagen.Enabled == false && pbImagen.Visible == false)
            {
                string archivobuscar = Convert.ToString(dgvIngresoRegistro.CurrentRow.Cells[8].Value);
                if (archivobuscar != "Sin Imagen")
                {
                    pbImagen.Enabled = true;
                    pbImagen.Visible = true;
                    using (Image img = Image.FromFile(archivobuscar))
                    {
                        pbImagen.Image = new Bitmap(img);
                    }
                }
                else
                {
                    MessageBox.Show("Este registro no contiene imagen", "Sin Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CerrarImagen();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public DataTable dtOriginal = null;
        public DataTable dtFiltrada = null;
        public void ValidardtOriginal()
        {
            if (dtOriginal == null)
            {
                dtOriginal = (DataTable)dgvCierreCajaRegistro.DataSource;
                if (dtOriginal != null)
                {
                    dtOriginal = dtOriginal.Copy();
                }
            }
        }
        private void cbTipoDiferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalSistema.Text = "0.00";
            txtTotalCaja.Text = "0.00";
            if (cbTipoDiferencia.SelectedItem == null)
            {
                return;
            }

            string tipodiferencia = cbTipoDiferencia.SelectedItem.ToString();
            ValidardtOriginal();

            if (dtOriginal != null)
            {
                dtFiltrada = dtOriginal.Clone();

                foreach (DataRow row in dtOriginal.Rows)
                {
                    if (row["TipoDiferencia"].ToString() == tipodiferencia)
                    {
                        dtFiltrada.ImportRow(row);
                    }
                }
                dgvCierreCajaRegistro.DataSource = dtFiltrada;
            }
        }
        private void txtTotalSistema_Click(object sender, EventArgs e)
        {
            txtTotalSistema.SelectAll();
        }
        private void txtTotalSistema_TextChanged(object sender, EventArgs e)
        {
            ValidardtOriginal();
            if (string.IsNullOrWhiteSpace(txtTotalSistema.Text))
            {
                if (dtFiltrada == null)
                {
                    txtTotalSistema.Text = "0.00";
                    txtTotalSistema.SelectAll();
                    return;
                }
            }
            decimal filtroTotalSistema = Convert.ToDecimal(txtTotalSistema.Text);
            if (dtFiltrada == null)
            {
                DataTable dtFiltradaTotalSistema = dtOriginal.Clone();
                foreach (DataRow row in dtOriginal.Rows)
                {
                    if (Convert.ToDecimal(row["TotalSistema"]) == filtroTotalSistema)
                    {
                        dtFiltradaTotalSistema.ImportRow(row);
                    }
                }
                dgvCierreCajaRegistro.DataSource = dtFiltradaTotalSistema;
            }
            if (dtFiltrada != null)
            {
                DataTable dtFiltradaTotalSistema = dtFiltrada.Clone();
                foreach (DataRow row in dtFiltrada.Rows)
                {
                    if (Convert.ToDecimal(row["TotalSistema"]) == filtroTotalSistema)
                    {
                        dtFiltradaTotalSistema.ImportRow(row);
                    }
                }
                dgvCierreCajaRegistro.DataSource = dtFiltradaTotalSistema;
            }
        }

        private void txtTotalSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (this.txtTotalSistema.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
    }
}
