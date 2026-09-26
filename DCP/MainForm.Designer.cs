namespace DCP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cajaDiariaToolStripMenuItem = new ToolStripMenuItem();
            ingresoToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cajaDiariaToolStripMenuItem, movimientosToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(351, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cajaDiariaToolStripMenuItem
            // 
            cajaDiariaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresoToolStripMenuItem, registrosToolStripMenuItem });
            cajaDiariaToolStripMenuItem.Name = "cajaDiariaToolStripMenuItem";
            cajaDiariaToolStripMenuItem.Size = new Size(141, 36);
            cajaDiariaToolStripMenuItem.Text = "Caja Diaria";
            // 
            // ingresoToolStripMenuItem
            // 
            ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            ingresoToolStripMenuItem.Size = new Size(198, 36);
            ingresoToolStripMenuItem.Text = "Ingreso";
            ingresoToolStripMenuItem.Click += ingresoToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(198, 36);
            registrosToolStripMenuItem.Text = "Registros";
            registrosToolStripMenuItem.Click += registrosToolStripMenuItem_Click;
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(168, 36);
            movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(35, 36);
            toolStripMenuItem1.Text = " ";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1059);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1875, 0);
            button1.Name = "button1";
            button1.Size = new Size(45, 33);
            button1.TabIndex = 0;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1824, 0);
            button2.Name = "button2";
            button2.Size = new Size(45, 33);
            button2.TabIndex = 2;
            button2.Text = "_";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1920, 1102);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cajaDiariaToolStripMenuItem;
        private ToolStripMenuItem ingresoToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button button1;
        private Button button2;
    }
}
