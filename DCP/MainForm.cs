using DCP.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DCP
{
    public partial class MainForm : Form
    {
        private Ingreso frmingreso;
        private Registros frmregistros;

        private SqlConnection connection;

        //variable conexion a la base de datos
        public string conexion = ConfigurationManager.ConnectionStrings["Conexion"]?.ConnectionString;


        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirIngresoForm();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                await connection.OpenAsync(cts.Token);

                MessageBox.Show("Conexión establecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection?.State != ConnectionState.Closed)
                {
                    await connection.CloseAsync();
                }
            }
        }

        /*private void CargarCaja()
        {
            using SqlConnection cn = new SqlConnection(conexion);
            cn.Open();
            string sql = "select fecha, VentasSistema, EfectivoContado, TipoDiferencia, MontoDiferencia, Observacion from CajaDiaria";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clFechaCaja.DataPropertyName = "Fecha";
            clVentasSistema.DataPropertyName = "VentasSistema";
            clEfectivoContado.DataPropertyName = "EfectivoContado";
            clTipoDiferencia.DataPropertyName = "TipoDiferencia";
            clMontoDiferencia.DataPropertyName = "MontoDiferencia";
            clObservacionCaja.DataPropertyName = "Observacion";
            dgvCaja.DataSource = dt;
        }*/

        public void AbrirIngresoForm()
        {
            frmingreso = new Ingreso();
            frmingreso.TopLevel = false;
            frmingreso.FormBorderStyle = FormBorderStyle.None;
            frmingreso.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frmingreso);
            frmingreso.Show();
        }

        public void AbrirRegistrosForm()
        {
            Registros frm = new Registros();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();

        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.WaitForPendingFinalizers();
            AbrirIngresoForm();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingreso.EliminarImagenes();
            frmingreso.LimpiarFormulario();
            GC.WaitForPendingFinalizers();
            AbrirRegistrosForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmingreso.CerrarPictureBox();
            DialogResult salir = MessageBox.Show($"Deseas cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (salir == DialogResult.Yes)
            {
                frmingreso.EliminarImagenes();
                GC.WaitForPendingFinalizers();
                MainForm.ActiveForm.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }
    }
}
