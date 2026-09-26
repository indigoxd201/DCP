namespace DCP.Forms
{
    partial class Ingreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtpIngreso = new DateTimePicker();
            cbCambiarFecha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbDestinatario = new ComboBox();
            cmbMetododepago = new ComboBox();
            txtConcepto = new TextBox();
            txtDetalle = new TextBox();
            txtEfectivodecaja = new TextBox();
            txtReserva = new TextBox();
            dgvIngreso = new DataGridView();
            clDestinatario = new DataGridViewTextBoxColumn();
            clConcepto = new DataGridViewTextBoxColumn();
            clDetalle = new DataGridViewTextBoxColumn();
            clMetodoDePago = new DataGridViewTextBoxColumn();
            clCaja = new DataGridViewTextBoxColumn();
            clReserva = new DataGridViewTextBoxColumn();
            clTotal = new DataGridViewTextBoxColumn();
            clObservacion = new DataGridViewTextBoxColumn();
            clRuta = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            txtObservacion = new TextBox();
            label7 = new Label();
            btnLimpiarEntradas = new Button();
            btnCancelarOperacion = new Button();
            label8 = new Label();
            txtMontototal = new TextBox();
            btnMultimedia = new Button();
            groupBox1 = new GroupBox();
            lblArchivo = new Label();
            cbArchivoMultimedia = new CheckBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            pArchivo = new Panel();
            pbArchivo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngreso).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArchivo).BeginInit();
            SuspendLayout();
            // 
            // dtpIngreso
            // 
            dtpIngreso.Anchor = AnchorStyles.Left;
            dtpIngreso.Enabled = false;
            dtpIngreso.Location = new Point(621, 13);
            dtpIngreso.Margin = new Padding(5, 4, 5, 4);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(443, 37);
            dtpIngreso.TabIndex = 0;
            dtpIngreso.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // cbCambiarFecha
            // 
            cbCambiarFecha.Anchor = AnchorStyles.Left;
            cbCambiarFecha.AutoSize = true;
            cbCambiarFecha.Location = new Point(1074, 13);
            cbCambiarFecha.Margin = new Padding(5, 4, 5, 4);
            cbCambiarFecha.Name = "cbCambiarFecha";
            cbCambiarFecha.Size = new Size(204, 35);
            cbCambiarFecha.TabIndex = 1;
            cbCambiarFecha.Text = "Cambiar Fecha";
            cbCambiarFecha.UseVisualStyleBackColor = true;
            cbCambiarFecha.CheckedChanged += cbCambiarFecha_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(50, 60);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 2;
            label1.Text = "Destinatario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(353, 60);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 3;
            label2.Text = "Concepto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(826, 60);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 4;
            label3.Text = "Detalle:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(1249, 59);
            label4.Name = "label4";
            label4.Size = new Size(212, 31);
            label4.TabIndex = 5;
            label4.Text = "Método de pago:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(1531, 60);
            label5.Name = "label5";
            label5.Size = new Size(68, 31);
            label5.TabIndex = 6;
            label5.Text = "Caja:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(1672, 61);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 7;
            label6.Text = "Reserva:";
            // 
            // cmbDestinatario
            // 
            cmbDestinatario.Anchor = AnchorStyles.Left;
            cmbDestinatario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinatario.FormattingEnabled = true;
            cmbDestinatario.Items.AddRange(new object[] { "Bolsa", "Delmor", "Don Douglas", "Don Marvin", "Doña Heidi", "LALA", "Queso Emilio", "Queso Erick", "Scarleth", "TipTop", "Otro" });
            cmbDestinatario.Location = new Point(4, 94);
            cmbDestinatario.Name = "cmbDestinatario";
            cmbDestinatario.Size = new Size(263, 38);
            cmbDestinatario.TabIndex = 8;
            cmbDestinatario.SelectionChangeCommitted += cmbDestinatario_SelectionChangeCommitted;
            // 
            // cmbMetododepago
            // 
            cmbMetododepago.Anchor = AnchorStyles.Left;
            cmbMetododepago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetododepago.FormattingEnabled = true;
            cmbMetododepago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta", "Cheque" });
            cmbMetododepago.Location = new Point(1206, 93);
            cmbMetododepago.Name = "cmbMetododepago";
            cmbMetododepago.Size = new Size(286, 38);
            cmbMetododepago.TabIndex = 9;
            cmbMetododepago.SelectionChangeCommitted += cmbMetododepago_SelectionChangeCommitted;
            // 
            // txtConcepto
            // 
            txtConcepto.Anchor = AnchorStyles.Left;
            txtConcepto.AutoCompleteCustomSource.AddRange(new string[] { "luz", "agua", "internet", "gps", "mantenimiento", "gasolina", "pago", "compra", "ferretería", "préstamo" });
            txtConcepto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtConcepto.Location = new Point(273, 93);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(309, 37);
            txtConcepto.TabIndex = 10;
            txtConcepto.KeyDown += txtConcepto_KeyDown;
            // 
            // txtDetalle
            // 
            txtDetalle.Anchor = AnchorStyles.Left;
            txtDetalle.Location = new Point(588, 93);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(612, 37);
            txtDetalle.TabIndex = 11;
            txtDetalle.KeyDown += txtDetalle_KeyDown;
            // 
            // txtEfectivodecaja
            // 
            txtEfectivodecaja.Anchor = AnchorStyles.Left;
            txtEfectivodecaja.Location = new Point(1498, 94);
            txtEfectivodecaja.Name = "txtEfectivodecaja";
            txtEfectivodecaja.Size = new Size(147, 37);
            txtEfectivodecaja.TabIndex = 12;
            txtEfectivodecaja.Text = "0.00";
            txtEfectivodecaja.TextAlign = HorizontalAlignment.Right;
            txtEfectivodecaja.Enter += txtEfectivodecaja_Enter;
            txtEfectivodecaja.KeyDown += txtEfectivodecaja_KeyDown;
            txtEfectivodecaja.KeyPress += txtEfectivodecaja_KeyPress;
            txtEfectivodecaja.Leave += txtEfectivodecaja_Leave;
            // 
            // txtReserva
            // 
            txtReserva.Anchor = AnchorStyles.Left;
            txtReserva.Location = new Point(1651, 95);
            txtReserva.Name = "txtReserva";
            txtReserva.Size = new Size(147, 37);
            txtReserva.TabIndex = 13;
            txtReserva.Text = "0.00";
            txtReserva.TextAlign = HorizontalAlignment.Right;
            txtReserva.Enter += txtReserva_Enter;
            txtReserva.KeyDown += txtReserva_KeyDown;
            txtReserva.KeyPress += txtReserva_KeyPress;
            txtReserva.Leave += txtReserva_Leave;
            // 
            // dgvIngreso
            // 
            dgvIngreso.AllowUserToAddRows = false;
            dgvIngreso.AllowUserToDeleteRows = false;
            dgvIngreso.AllowUserToResizeRows = false;
            dgvIngreso.BackgroundColor = SystemColors.ButtonFace;
            dgvIngreso.BorderStyle = BorderStyle.None;
            dgvIngreso.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvIngreso.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngreso.Columns.AddRange(new DataGridViewColumn[] { clDestinatario, clConcepto, clDetalle, clMetodoDePago, clCaja, clReserva, clTotal, clObservacion, clRuta });
            dgvIngreso.Cursor = Cursors.Hand;
            dgvIngreso.Location = new Point(-60, 150);
            dgvIngreso.MaximumSize = new Size(1980, 693);
            dgvIngreso.MinimumSize = new Size(1980, 693);
            dgvIngreso.MultiSelect = false;
            dgvIngreso.Name = "dgvIngreso";
            dgvIngreso.ReadOnly = true;
            dgvIngreso.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvIngreso.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngreso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngreso.Size = new Size(1980, 693);
            dgvIngreso.TabIndex = 14;
            dgvIngreso.CellDoubleClick += dgvIngreso_CellDoubleClick;
            // 
            // clDestinatario
            // 
            clDestinatario.HeaderText = "Destinatario";
            clDestinatario.MinimumWidth = 275;
            clDestinatario.Name = "clDestinatario";
            clDestinatario.ReadOnly = true;
            clDestinatario.Width = 275;
            // 
            // clConcepto
            // 
            clConcepto.HeaderText = "Concepto";
            clConcepto.MinimumWidth = 310;
            clConcepto.Name = "clConcepto";
            clConcepto.ReadOnly = true;
            clConcepto.Width = 310;
            // 
            // clDetalle
            // 
            clDetalle.HeaderText = "Detalle";
            clDetalle.MinimumWidth = 620;
            clDetalle.Name = "clDetalle";
            clDetalle.ReadOnly = true;
            clDetalle.Width = 620;
            // 
            // clMetodoDePago
            // 
            clMetodoDePago.HeaderText = "Método de pago";
            clMetodoDePago.MinimumWidth = 290;
            clMetodoDePago.Name = "clMetodoDePago";
            clMetodoDePago.ReadOnly = true;
            clMetodoDePago.Width = 290;
            // 
            // clCaja
            // 
            clCaja.HeaderText = "Caja";
            clCaja.MinimumWidth = 150;
            clCaja.Name = "clCaja";
            clCaja.ReadOnly = true;
            clCaja.Width = 150;
            // 
            // clReserva
            // 
            clReserva.HeaderText = "Reserva";
            clReserva.MinimumWidth = 150;
            clReserva.Name = "clReserva";
            clReserva.ReadOnly = true;
            clReserva.Width = 150;
            // 
            // clTotal
            // 
            clTotal.HeaderText = "Total";
            clTotal.MinimumWidth = 6;
            clTotal.Name = "clTotal";
            clTotal.ReadOnly = true;
            clTotal.Width = 123;
            // 
            // clObservacion
            // 
            clObservacion.HeaderText = "Observación";
            clObservacion.MinimumWidth = 125;
            clObservacion.Name = "clObservacion";
            clObservacion.ReadOnly = true;
            clObservacion.Visible = false;
            clObservacion.Width = 125;
            // 
            // clRuta
            // 
            clRuta.HeaderText = "Ruta";
            clRuta.MinimumWidth = 6;
            clRuta.Name = "clRuta";
            clRuta.ReadOnly = true;
            clRuta.Visible = false;
            clRuta.Width = 125;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1749, 126);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 51);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacion.Location = new Point(1334, 15);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(580, 105);
            txtObservacion.TabIndex = 16;
            txtObservacion.KeyDown += txtObservacion_KeyDown;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1126, 26);
            label7.Name = "label7";
            label7.Size = new Size(202, 39);
            label7.TabIndex = 17;
            label7.Text = "Observación:";
            // 
            // btnLimpiarEntradas
            // 
            btnLimpiarEntradas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiarEntradas.Font = new Font("Microsoft YaHei UI", 18F);
            btnLimpiarEntradas.Location = new Point(344, 86);
            btnLimpiarEntradas.Name = "btnLimpiarEntradas";
            btnLimpiarEntradas.Size = new Size(332, 91);
            btnLimpiarEntradas.TabIndex = 18;
            btnLimpiarEntradas.Text = "Limpiar entradas";
            btnLimpiarEntradas.UseVisualStyleBackColor = true;
            btnLimpiarEntradas.Click += btnLimpiarEntradas_Click;
            // 
            // btnCancelarOperacion
            // 
            btnCancelarOperacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelarOperacion.Font = new Font("Microsoft YaHei UI", 18F);
            btnCancelarOperacion.Location = new Point(6, 86);
            btnCancelarOperacion.Name = "btnCancelarOperacion";
            btnCancelarOperacion.Size = new Size(332, 91);
            btnCancelarOperacion.TabIndex = 19;
            btnCancelarOperacion.Text = "Cancelar Operación";
            btnCancelarOperacion.UseVisualStyleBackColor = true;
            btnCancelarOperacion.Click += btnCancelarOperacion_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 26);
            label8.Name = "label8";
            label8.Size = new Size(195, 39);
            label8.TabIndex = 20;
            label8.Text = "Monto total:";
            // 
            // txtMontototal
            // 
            txtMontototal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMontototal.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMontototal.Location = new Point(216, 26);
            txtMontototal.Name = "txtMontototal";
            txtMontototal.ReadOnly = true;
            txtMontototal.Size = new Size(220, 41);
            txtMontototal.TabIndex = 21;
            // 
            // btnMultimedia
            // 
            btnMultimedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMultimedia.Location = new Point(682, 86);
            btnMultimedia.Name = "btnMultimedia";
            btnMultimedia.Size = new Size(332, 91);
            btnMultimedia.TabIndex = 23;
            btnMultimedia.Text = "Seleccionar Archivo multimedia 👁";
            btnMultimedia.UseVisualStyleBackColor = true;
            btnMultimedia.Click += btnMultimedia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblArchivo);
            groupBox1.Controls.Add(cbArchivoMultimedia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLimpiarEntradas);
            groupBox1.Controls.Add(btnCancelarOperacion);
            groupBox1.Controls.Add(btnMultimedia);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMontototal);
            groupBox1.Controls.Add(txtObservacion);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 844);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1920, 206);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(1036, 126);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(449, 31);
            lblArchivo.TabIndex = 25;
            lblArchivo.Text = "No se ha seleccionado ningún archivo";
            // 
            // cbArchivoMultimedia
            // 
            cbArchivoMultimedia.AutoSize = true;
            cbArchivoMultimedia.BackColor = SystemColors.Menu;
            cbArchivoMultimedia.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbArchivoMultimedia.ForeColor = Color.Black;
            cbArchivoMultimedia.Location = new Point(1036, 86);
            cbArchivoMultimedia.Name = "cbArchivoMultimedia";
            cbArchivoMultimedia.Size = new Size(271, 34);
            cbArchivoMultimedia.TabIndex = 24;
            cbArchivoMultimedia.Text = "Archivo seleccionado";
            cbArchivoMultimedia.UseVisualStyleBackColor = false;
            cbArchivoMultimedia.Click += cbArchivoMultimedia_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbCambiarFecha);
            groupBox2.Controls.Add(dtpIngreso);
            groupBox2.Controls.Add(cmbDestinatario);
            groupBox2.Controls.Add(txtReserva);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtEfectivodecaja);
            groupBox2.Controls.Add(cmbMetododepago);
            groupBox2.Controls.Add(txtConcepto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDetalle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1920, 144);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 19);
            label9.Name = "label9";
            label9.Size = new Size(870, 31);
            label9.TabIndex = 14;
            label9.Text = "pendiente arreglar error de alt + f4 (hay que eliminar la imagen si se subio)";
            // 
            // pArchivo
            // 
            pArchivo.Controls.Add(pbArchivo);
            pArchivo.Enabled = false;
            pArchivo.Location = new Point(303, 193);
            pArchivo.Name = "pArchivo";
            pArchivo.Size = new Size(1189, 660);
            pArchivo.TabIndex = 26;
            pArchivo.Visible = false;
            // 
            // pbArchivo
            // 
            pbArchivo.Location = new Point(3, 3);
            pbArchivo.Name = "pbArchivo";
            pbArchivo.Size = new Size(1183, 654);
            pbArchivo.TabIndex = 1;
            pbArchivo.TabStop = false;
            pbArchivo.Visible = false;
            pbArchivo.Click += pbArchivo_Click;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1920, 1050);
            Controls.Add(pArchivo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvIngreso);
            Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Ingreso";
            Text = "Ingreso";
            WindowState = FormWindowState.Maximized;
            Load += Ingreso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngreso).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pArchivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArchivo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpIngreso;
        private CheckBox cbCambiarFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbDestinatario;
        private ComboBox cmbMetododepago;
        private TextBox txtConcepto;
        private TextBox txtDetalle;
        private TextBox txtEfectivodecaja;
        private TextBox txtReserva;
        private DataGridView dgvIngreso;
        private Button btnGuardar;
        private TextBox txtObservacion;
        private Label label7;
        private Button btnLimpiarEntradas;
        private Button btnCancelarOperacion;
        private Label label8;
        private TextBox txtMontototal;
        private Button btnMultimedia;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cbArchivoMultimedia;
        private DataGridViewTextBoxColumn clDestinatario;
        private DataGridViewTextBoxColumn clConcepto;
        private DataGridViewTextBoxColumn clDetalle;
        private DataGridViewTextBoxColumn clMetodoDePago;
        private DataGridViewTextBoxColumn clCaja;
        private DataGridViewTextBoxColumn clReserva;
        private DataGridViewTextBoxColumn clTotal;
        private DataGridViewTextBoxColumn clObservacion;
        private DataGridViewTextBoxColumn clRuta;
        private Label lblArchivo;
        private Panel pArchivo;
        private PictureBox pbArchivo;
        private Label label9;
    }
}