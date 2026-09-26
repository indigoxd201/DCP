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
    public partial class TotalDeCierre : Form
    {

        public string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"]?.ConnectionString;
        private Ingreso frmIngreso;

        public int IdCierre { get; set; }

        public TotalDeCierre()
        {
            InitializeComponent();
        }

        public TotalDeCierre(Ingreso _frmIngreso)
        {
            InitializeComponent();
            this.frmIngreso = _frmIngreso;
        }

        private void TotalDeCierre_Load(object sender, EventArgs e)
        {
            if (frmIngreso != null)
            {
                txtTotalDeCaja.Text = frmIngreso.SumarEfectivo().ToString();
                txtTotalSegunSistema.Text = "0.00";
                decimal totalSistema = Convert.ToDecimal(txtTotalSegunSistema.Text);
                decimal totalCaja = Convert.ToDecimal(txtTotalDeCaja.Text);
                decimal diferencia = 0;
                txtDiferencia.Text = diferencia.ToString("0.00");
                txtTipoDeDiferencia.Text = "Sin Diferencia";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "Sin Observación";
            }
            if (txtTotalSegunSistema.Text == null && txtTotalDeCaja.Text == null && txtDiferencia.Text == null && txtTipoDeDiferencia.Text == null)
            {
                MessageBox.Show("No puede proceder a guardar datos si tiene campos vacíos. \nRellene todos los datos para poder continuar.", "Rellenar campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("GuardarCierre", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", frmIngreso.fechaingreso);
                cmd.Parameters.AddWithValue("@TotalSistema", txtTotalSegunSistema.Text);
                cmd.Parameters.AddWithValue("@TotalCaja", txtTotalDeCaja.Text);
                cmd.Parameters.AddWithValue("@Diferencia", txtDiferencia.Text);
                cmd.Parameters.AddWithValue("@TipoDiferencia", txtTipoDeDiferencia.Text);
                cmd.Parameters.AddWithValue("@TotalPagosTarjeta", txtPagosTarjeta.Text);
                cmd.Parameters.AddWithValue("@TotalTransferencia", txtPagosTransferencia.Text);
                cmd.Parameters.AddWithValue("@ObservacionCierreDeCaja", txtObservacion.Text);
                decimal tcaja = Convert.ToDecimal(txtTotalDeCaja.Text);
                decimal ptarjeta = Convert.ToDecimal(txtPagosTarjeta.Text);
                decimal ptransferencia = Convert.ToDecimal(txtPagosTransferencia.Text);
                cmd.Parameters.AddWithValue("@TotalDia", tcaja + ptarjeta + ptransferencia);

                IdCierre = Convert.ToInt32(cmd.ExecuteScalar());
            }
            frmIngreso.GuardarIngreso();
            GC.WaitForPendingFinalizers();
            frmIngreso.LimpiarFormularioIngreso();
            this.DialogResult = DialogResult.OK;
        }

        private void txtTotalSegunSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtTotalSegunSistema_Click(object sender, EventArgs e)
        {
            txtTotalSegunSistema.SelectAll();
        }

        private void txtTotalSegunSistema_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalSegunSistema.Text))
            {
                txtTotalSegunSistema.Text = "0.00";
                txtTotalSegunSistema.SelectAll();
                return;
            }
            decimal totalSistema = Convert.ToDecimal(txtTotalSegunSistema.Text);
            decimal totalCaja = Convert.ToDecimal(txtTotalDeCaja.Text);
            decimal diferencia = totalSistema - totalCaja;

            if (diferencia > 0)
            {
                this.txtTipoDeDiferencia.Text = "Faltante";
                txtDiferencia.Text = diferencia.ToString("0.00");
            }
            else if (diferencia < 0)
            {
                this.txtTipoDeDiferencia.Text = "Sobrante";
                diferencia = diferencia * -1;
                txtDiferencia.Text = diferencia.ToString("0.00");
            }
            else
            {
                this.txtTipoDeDiferencia.Text = "Sin Diferencia";
                txtDiferencia.Text = diferencia.ToString("0.00");
            }
        }
        private void txtPagosTarjeta_Click(object sender, EventArgs e)
        {
            txtPagosTarjeta.SelectAll();
        }
        private void txtPagosTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPagosTarjeta_Leave(object sender, EventArgs e)
        {
            if (txtPagosTarjeta.Text == "")
            {
                txtPagosTarjeta.Text = "0.00";
            }
        }
        private void txtPagosTransferencia_Click(object sender, EventArgs e)
        {
            txtPagosTransferencia.SelectAll();
        }
        private void txtPagosTransferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPagosTransferencia_Leave(object sender, EventArgs e)
        {
            if (txtPagosTransferencia.Text == "")
            {
                txtPagosTransferencia.Text = "0.00";
            }
        }
    }
}
