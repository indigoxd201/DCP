namespace DCP.Forms
{
    partial class TotalDeCierre
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtTotalSegunSistema = new TextBox();
            txtTotalDeCaja = new TextBox();
            txtDiferencia = new TextBox();
            txtTipoDeDiferencia = new TextBox();
            txtObservacion = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            txtPagosTransferencia = new TextBox();
            txtPagosTarjeta = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 69);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 0;
            label1.Text = "Total según sistema:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 129);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 31);
            label2.TabIndex = 1;
            label2.Text = "Total de caja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 189);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 31);
            label3.TabIndex = 2;
            label3.Text = "Diferencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 249);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 3;
            label4.Text = "Tipo de diferencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 432);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 31);
            label5.TabIndex = 4;
            label5.Text = "Observación:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(88, 482);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 76);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(332, 482);
            btnAceptar.Margin = new Padding(5, 4, 5, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(211, 76);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTotalSegunSistema
            // 
            txtTotalSegunSistema.Location = new Point(370, 66);
            txtTotalSegunSistema.Name = "txtTotalSegunSistema";
            txtTotalSegunSistema.Size = new Size(196, 37);
            txtTotalSegunSistema.TabIndex = 7;
            txtTotalSegunSistema.Click += txtTotalSegunSistema_Click;
            txtTotalSegunSistema.TextChanged += txtTotalSegunSistema_TextChanged;
            txtTotalSegunSistema.KeyPress += txtTotalSegunSistema_KeyPress;
            // 
            // txtTotalDeCaja
            // 
            txtTotalDeCaja.Location = new Point(370, 126);
            txtTotalDeCaja.Name = "txtTotalDeCaja";
            txtTotalDeCaja.ReadOnly = true;
            txtTotalDeCaja.Size = new Size(196, 37);
            txtTotalDeCaja.TabIndex = 8;
            // 
            // txtDiferencia
            // 
            txtDiferencia.Location = new Point(370, 186);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.ReadOnly = true;
            txtDiferencia.Size = new Size(196, 37);
            txtDiferencia.TabIndex = 9;
            // 
            // txtTipoDeDiferencia
            // 
            txtTipoDeDiferencia.Location = new Point(370, 246);
            txtTipoDeDiferencia.Name = "txtTipoDeDiferencia";
            txtTipoDeDiferencia.ReadOnly = true;
            txtTipoDeDiferencia.Size = new Size(196, 37);
            txtTipoDeDiferencia.TabIndex = 10;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(370, 429);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(196, 37);
            txtObservacion.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPagosTransferencia);
            groupBox1.Controls.Add(txtPagosTarjeta);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtObservacion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTipoDeDiferencia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiferencia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTotalDeCaja);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTotalSegunSistema);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Location = new Point(25, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 606);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total de cierre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 372);
            label7.Name = "label7";
            label7.Size = new Size(290, 31);
            label7.TabIndex = 15;
            label7.Text = "Pagos por transferencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 309);
            label6.Name = "label6";
            label6.Size = new Size(282, 31);
            label6.TabIndex = 14;
            label6.Text = "Total pagos con tarjeta:";
            // 
            // txtPagosTransferencia
            // 
            txtPagosTransferencia.Location = new Point(370, 369);
            txtPagosTransferencia.Name = "txtPagosTransferencia";
            txtPagosTransferencia.Size = new Size(196, 37);
            txtPagosTransferencia.TabIndex = 13;
            txtPagosTransferencia.Text = "0.00";
            txtPagosTransferencia.Click += txtPagosTransferencia_Click;
            txtPagosTransferencia.KeyPress += txtPagosTransferencia_KeyPress;
            txtPagosTransferencia.Leave += txtPagosTransferencia_Leave;
            // 
            // txtPagosTarjeta
            // 
            txtPagosTarjeta.Location = new Point(370, 306);
            txtPagosTarjeta.Name = "txtPagosTarjeta";
            txtPagosTarjeta.Size = new Size(196, 37);
            txtPagosTarjeta.TabIndex = 12;
            txtPagosTarjeta.Text = "0.00";
            txtPagosTarjeta.Click += txtPagosTarjeta_Click;
            txtPagosTarjeta.KeyPress += txtPagosTarjeta_KeyPress;
            txtPagosTarjeta.Leave += txtPagosTarjeta_Leave;
            // 
            // TotalDeCierre
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(673, 661);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "TotalDeCierre";
            Text = "CierreDeCaja";
            Load += TotalDeCierre_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtTotalSegunSistema;
        private TextBox txtTotalDeCaja;
        private TextBox txtDiferencia;
        private TextBox txtTipoDeDiferencia;
        private TextBox txtObservacion;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private TextBox txtPagosTransferencia;
        private TextBox txtPagosTarjeta;
    }
}