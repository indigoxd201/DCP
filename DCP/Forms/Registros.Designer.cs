namespace DCP.Forms
{
    partial class Registros
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaDesde = new DateTimePicker();
            txtTotalSistema = new TextBox();
            dgvCierreCajaRegistro = new DataGridView();
            clIDCierre = new DataGridViewTextBoxColumn();
            clFecha = new DataGridViewTextBoxColumn();
            clTotalSistema = new DataGridViewTextBoxColumn();
            clTotalCaja = new DataGridViewTextBoxColumn();
            clTipoDiferencia = new DataGridViewTextBoxColumn();
            clDiferencia = new DataGridViewTextBoxColumn();
            clObservacionCierre = new DataGridViewTextBoxColumn();
            dgvIngresoRegistro = new DataGridView();
            clIDIngreso = new DataGridViewTextBoxColumn();
            clIDCierreCaja = new DataGridViewTextBoxColumn();
            clDestinatario = new DataGridViewTextBoxColumn();
            clConcepto = new DataGridViewTextBoxColumn();
            clDetalle = new DataGridViewTextBoxColumn();
            clMetodoDePago = new DataGridViewTextBoxColumn();
            clEfectivoCaja = new DataGridViewTextBoxColumn();
            clReserva = new DataGridViewTextBoxColumn();
            clObservacionIngreso = new DataGridViewTextBoxColumn();
            clRuta = new DataGridViewTextBoxColumn();
            btnVerFoto = new Button();
            btnEliminar = new Button();
            dtpFechaHasta = new DateTimePicker();
            label2 = new Label();
            cbTipoDiferencia = new ComboBox();
            btnAplicar = new Button();
            txtTotalCaja = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox2 = new GroupBox();
            pbImagen = new PictureBox();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCierreCajaRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresoRegistro).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(121, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 0;
            label1.Text = "Buscar desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1233, 28);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 31);
            label3.TabIndex = 2;
            label3.Text = "Total según sistema:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(798, 31);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 3;
            label4.Text = "Tipo de diferencia:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Cursor = Cursors.Hand;
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(300, 17);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(177, 37);
            dtpFechaDesde.TabIndex = 4;
            // 
            // txtTotalSistema
            // 
            txtTotalSistema.Cursor = Cursors.Hand;
            txtTotalSistema.Location = new Point(1488, 25);
            txtTotalSistema.Name = "txtTotalSistema";
            txtTotalSistema.Size = new Size(116, 37);
            txtTotalSistema.TabIndex = 6;
            txtTotalSistema.Text = "0.00";
            txtTotalSistema.Click += txtTotalSistema_Click;
            txtTotalSistema.TextChanged += txtTotalSistema_TextChanged;
            txtTotalSistema.KeyPress += txtTotalSistema_KeyPress;
            // 
            // dgvCierreCajaRegistro
            // 
            dgvCierreCajaRegistro.AllowUserToAddRows = false;
            dgvCierreCajaRegistro.AllowUserToDeleteRows = false;
            dgvCierreCajaRegistro.AllowUserToResizeRows = false;
            dgvCierreCajaRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCierreCajaRegistro.BackgroundColor = SystemColors.Control;
            dgvCierreCajaRegistro.BorderStyle = BorderStyle.Fixed3D;
            dgvCierreCajaRegistro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCierreCajaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCierreCajaRegistro.Columns.AddRange(new DataGridViewColumn[] { clIDCierre, clFecha, clTotalSistema, clTotalCaja, clTipoDiferencia, clDiferencia, clObservacionCierre });
            dgvCierreCajaRegistro.GridColor = SystemColors.ActiveCaption;
            dgvCierreCajaRegistro.Location = new Point(6, 24);
            dgvCierreCajaRegistro.MultiSelect = false;
            dgvCierreCajaRegistro.Name = "dgvCierreCajaRegistro";
            dgvCierreCajaRegistro.ReadOnly = true;
            dgvCierreCajaRegistro.RowHeadersWidth = 35;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCierreCajaRegistro.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCierreCajaRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCierreCajaRegistro.Size = new Size(1908, 405);
            dgvCierreCajaRegistro.TabIndex = 8;
            dgvCierreCajaRegistro.CellClick += dgvCierreCajaRegistro_CellClick;
            // 
            // clIDCierre
            // 
            clIDCierre.HeaderText = "ID Cierre";
            clIDCierre.MinimumWidth = 6;
            clIDCierre.Name = "clIDCierre";
            clIDCierre.ReadOnly = true;
            clIDCierre.Visible = false;
            clIDCierre.Width = 125;
            // 
            // clFecha
            // 
            clFecha.HeaderText = "Fecha";
            clFecha.MinimumWidth = 6;
            clFecha.Name = "clFecha";
            clFecha.ReadOnly = true;
            clFecha.Width = 200;
            // 
            // clTotalSistema
            // 
            clTotalSistema.HeaderText = "Total Sistema";
            clTotalSistema.MinimumWidth = 6;
            clTotalSistema.Name = "clTotalSistema";
            clTotalSistema.ReadOnly = true;
            clTotalSistema.Width = 200;
            // 
            // clTotalCaja
            // 
            clTotalCaja.HeaderText = "Total Caja";
            clTotalCaja.MinimumWidth = 6;
            clTotalCaja.Name = "clTotalCaja";
            clTotalCaja.ReadOnly = true;
            clTotalCaja.Width = 200;
            // 
            // clTipoDiferencia
            // 
            clTipoDiferencia.HeaderText = "Tipo de diferencia";
            clTipoDiferencia.MinimumWidth = 6;
            clTipoDiferencia.Name = "clTipoDiferencia";
            clTipoDiferencia.ReadOnly = true;
            clTipoDiferencia.Width = 300;
            // 
            // clDiferencia
            // 
            clDiferencia.HeaderText = "Diferencia";
            clDiferencia.MinimumWidth = 6;
            clDiferencia.Name = "clDiferencia";
            clDiferencia.ReadOnly = true;
            clDiferencia.Width = 200;
            // 
            // clObservacionCierre
            // 
            clObservacionCierre.HeaderText = "Observación";
            clObservacionCierre.MinimumWidth = 6;
            clObservacionCierre.Name = "clObservacionCierre";
            clObservacionCierre.ReadOnly = true;
            clObservacionCierre.Width = 767;
            // 
            // dgvIngresoRegistro
            // 
            dgvIngresoRegistro.AllowUserToAddRows = false;
            dgvIngresoRegistro.AllowUserToDeleteRows = false;
            dgvIngresoRegistro.AllowUserToResizeRows = false;
            dgvIngresoRegistro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngresoRegistro.BackgroundColor = SystemColors.Control;
            dgvIngresoRegistro.BorderStyle = BorderStyle.Fixed3D;
            dgvIngresoRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresoRegistro.Columns.AddRange(new DataGridViewColumn[] { clIDIngreso, clIDCierreCaja, clDestinatario, clConcepto, clDetalle, clMetodoDePago, clEfectivoCaja, clReserva, clObservacionIngreso, clRuta });
            dgvIngresoRegistro.GridColor = SystemColors.InactiveCaption;
            dgvIngresoRegistro.Location = new Point(6, 452);
            dgvIngresoRegistro.MultiSelect = false;
            dgvIngresoRegistro.Name = "dgvIngresoRegistro";
            dgvIngresoRegistro.ReadOnly = true;
            dgvIngresoRegistro.RowHeadersWidth = 35;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvIngresoRegistro.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvIngresoRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngresoRegistro.Size = new Size(1908, 405);
            dgvIngresoRegistro.TabIndex = 9;
            // 
            // clIDIngreso
            // 
            clIDIngreso.HeaderText = "ID Ingreso";
            clIDIngreso.MinimumWidth = 6;
            clIDIngreso.Name = "clIDIngreso";
            clIDIngreso.ReadOnly = true;
            clIDIngreso.Visible = false;
            clIDIngreso.Width = 125;
            // 
            // clIDCierreCaja
            // 
            clIDCierreCaja.HeaderText = "ID";
            clIDCierreCaja.MinimumWidth = 6;
            clIDCierreCaja.Name = "clIDCierreCaja";
            clIDCierreCaja.ReadOnly = true;
            clIDCierreCaja.Width = 95;
            // 
            // clDestinatario
            // 
            clDestinatario.HeaderText = "Destinatario";
            clDestinatario.MinimumWidth = 6;
            clDestinatario.Name = "clDestinatario";
            clDestinatario.ReadOnly = true;
            clDestinatario.Width = 250;
            // 
            // clConcepto
            // 
            clConcepto.HeaderText = "Concepto";
            clConcepto.MinimumWidth = 6;
            clConcepto.Name = "clConcepto";
            clConcepto.ReadOnly = true;
            clConcepto.Width = 250;
            // 
            // clDetalle
            // 
            clDetalle.HeaderText = "Detalle";
            clDetalle.MinimumWidth = 6;
            clDetalle.Name = "clDetalle";
            clDetalle.ReadOnly = true;
            clDetalle.Width = 350;
            // 
            // clMetodoDePago
            // 
            clMetodoDePago.HeaderText = "Método de pago";
            clMetodoDePago.MinimumWidth = 6;
            clMetodoDePago.Name = "clMetodoDePago";
            clMetodoDePago.ReadOnly = true;
            clMetodoDePago.Width = 233;
            // 
            // clEfectivoCaja
            // 
            clEfectivoCaja.HeaderText = "Caja";
            clEfectivoCaja.MinimumWidth = 6;
            clEfectivoCaja.Name = "clEfectivoCaja";
            clEfectivoCaja.ReadOnly = true;
            clEfectivoCaja.Width = 125;
            // 
            // clReserva
            // 
            clReserva.HeaderText = "Reserva";
            clReserva.MinimumWidth = 6;
            clReserva.Name = "clReserva";
            clReserva.ReadOnly = true;
            clReserva.Width = 125;
            // 
            // clObservacionIngreso
            // 
            clObservacionIngreso.HeaderText = "Observación";
            clObservacionIngreso.MinimumWidth = 6;
            clObservacionIngreso.Name = "clObservacionIngreso";
            clObservacionIngreso.ReadOnly = true;
            clObservacionIngreso.Width = 443;
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
            // btnVerFoto
            // 
            btnVerFoto.Location = new Point(1388, 15);
            btnVerFoto.Name = "btnVerFoto";
            btnVerFoto.Size = new Size(260, 76);
            btnVerFoto.TabIndex = 11;
            btnVerFoto.Text = "Ver foto 👁";
            btnVerFoto.UseVisualStyleBackColor = true;
            btnVerFoto.Click += btnVerFoto_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1654, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(260, 76);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Cursor = Cursors.Hand;
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(593, 17);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(177, 37);
            dtpFechaHasta.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(502, 20);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 14;
            label2.Text = "Hasta:";
            // 
            // cbTipoDiferencia
            // 
            cbTipoDiferencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDiferencia.FormattingEnabled = true;
            cbTipoDiferencia.Items.AddRange(new object[] { "Sobrante", "Faltante", "Sin Diferencia" });
            cbTipoDiferencia.Location = new Point(1031, 25);
            cbTipoDiferencia.Name = "cbTipoDiferencia";
            cbTipoDiferencia.Size = new Size(193, 38);
            cbTipoDiferencia.TabIndex = 15;
            cbTipoDiferencia.SelectedIndexChanged += cbTipoDiferencia_SelectedIndexChanged;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.Gainsboro;
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.ForeColor = SystemColors.ActiveCaptionText;
            btnAplicar.Location = new Point(6, 13);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(113, 42);
            btnAplicar.TabIndex = 16;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // txtTotalCaja
            // 
            txtTotalCaja.Cursor = Cursors.Hand;
            txtTotalCaja.Location = new Point(1792, 24);
            txtTotalCaja.Name = "txtTotalCaja";
            txtTotalCaja.Size = new Size(116, 37);
            txtTotalCaja.TabIndex = 17;
            txtTotalCaja.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1622, 30);
            label5.Name = "label5";
            label5.Size = new Size(164, 31);
            label5.TabIndex = 18;
            label5.Text = "Total de caja:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(txtTotalSistema);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTotalCaja);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbTipoDiferencia);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1920, 75);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(dtpFechaHasta);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(dtpFechaDesde);
            groupBox4.Controls.Add(btnAplicar);
            groupBox4.Location = new Point(6, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(785, 67);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbImagen);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(dgvIngresoRegistro);
            groupBox2.Controls.Add(dgvCierreCajaRegistro);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1920, 975);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = SystemColors.ActiveCaption;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Enabled = false;
            pbImagen.Location = new Point(389, 27);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(1130, 763);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 11;
            pbImagen.TabStop = false;
            pbImagen.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(1914, 20);
            panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnVerFoto);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 938);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1920, 112);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1920, 1050);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Registros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCierreCajaRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresoRegistro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaDesde;
        private TextBox txtTotalSistema;
        private DataGridView dgvCierreCajaRegistro;
        private DataGridView dgvIngresoRegistro;
        private Button btnVerFoto;
        private Button btnEliminar;
        private DateTimePicker dtpFechaHasta;
        private Label label2;
        private ComboBox cbTipoDiferencia;
        private Button btnAplicar;
        private TextBox txtTotalCaja;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel panel1;
        private PictureBox pbImagen;
        private GroupBox groupBox4;
        private DataGridViewTextBoxColumn clIDCierre;
        private DataGridViewTextBoxColumn clFecha;
        private DataGridViewTextBoxColumn clTotalSistema;
        private DataGridViewTextBoxColumn clTotalCaja;
        private DataGridViewTextBoxColumn clTipoDiferencia;
        private DataGridViewTextBoxColumn clDiferencia;
        private DataGridViewTextBoxColumn clObservacionCierre;
        private DataGridViewTextBoxColumn clIDIngreso;
        private DataGridViewTextBoxColumn clIDCierreCaja;
        private DataGridViewTextBoxColumn clDestinatario;
        private DataGridViewTextBoxColumn clConcepto;
        private DataGridViewTextBoxColumn clDetalle;
        private DataGridViewTextBoxColumn clMetodoDePago;
        private DataGridViewTextBoxColumn clEfectivoCaja;
        private DataGridViewTextBoxColumn clReserva;
        private DataGridViewTextBoxColumn clObservacionIngreso;
        private DataGridViewTextBoxColumn clRuta;
    }
}