namespace Tp_DAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.PanelSubMenu = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelhora = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            this.PanelSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.Black;
            this.MenuLateral.Controls.Add(this.btnLogOut);
            this.MenuLateral.Controls.Add(this.PanelSubMenu);
            this.MenuLateral.Controls.Add(this.btnMedia);
            this.MenuLateral.Controls.Add(this.panel1);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(250, 961);
            this.MenuLateral.TabIndex = 0;
            // 
            // PanelSubMenu
            // 
            this.PanelSubMenu.AllowDrop = true;
            this.PanelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelSubMenu.Controls.Add(this.BtnVentas);
            this.PanelSubMenu.Controls.Add(this.BtnStock);
            this.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu.Location = new System.Drawing.Point(0, 145);
            this.PanelSubMenu.Name = "PanelSubMenu";
            this.PanelSubMenu.Size = new System.Drawing.Size(250, 92);
            this.PanelSubMenu.TabIndex = 2;
            // 
            // BtnVentas
            // 
            this.BtnVentas.AllowDrop = true;
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnVentas.Location = new System.Drawing.Point(0, 45);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnVentas.Size = new System.Drawing.Size(250, 45);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Resumen Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.AllowDrop = true;
            this.BtnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnStock.Location = new System.Drawing.Point(0, 0);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnStock.Size = new System.Drawing.Size(250, 45);
            this.BtnStock.TabIndex = 0;
            this.BtnStock.Text = "Stock";
            this.BtnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.AllowDrop = true;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMedia.Size = new System.Drawing.Size(250, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Menu";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.labelFecha);
            this.panel2.Controls.Add(this.labelhora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 905);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 56);
            this.panel2.TabIndex = 1;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(967, 27);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 15);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "label2";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // labelhora
            // 
            this.labelhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.Location = new System.Drawing.Point(967, 7);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(41, 15);
            this.labelhora.TabIndex = 0;
            this.labelhora.Text = "label1";
            this.labelhora.Click += new System.EventHandler(this.labelhora_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1034, 905);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Tp_DAS.Properties.Resources.s;
            this.pictureBox1.Location = new System.Drawing.Point(348, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(12, 912);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(96, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1300, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuLateral.ResumeLayout(false);
            this.PanelSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Panel PanelSubMenu;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

