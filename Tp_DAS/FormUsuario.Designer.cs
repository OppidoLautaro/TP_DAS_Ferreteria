namespace Tp_DAS
{
    partial class FormUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnmedia = new System.Windows.Forms.Button();
            this.PanelSubMenú = new System.Windows.Forms.Panel();
            this.BtnAgregarClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFec = new System.Windows.Forms.Label();
            this.labelhor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuLateral.SuspendLayout();
            this.PanelSubMenú.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1245, 848);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Tp_DAS.Properties.Resources.s;
            this.pictureBox1.Location = new System.Drawing.Point(553, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.Black;
            this.MenuLateral.Controls.Add(this.btnLogOut);
            this.MenuLateral.Controls.Add(this.btnmedia);
            this.MenuLateral.Controls.Add(this.PanelSubMenú);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(252, 848);
            this.MenuLateral.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 811);
            this.btnLogOut.MaximumSize = new System.Drawing.Size(86, 37);
            this.btnLogOut.MinimumSize = new System.Drawing.Size(86, 37);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 37);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnmedia
            // 
            this.btnmedia.AllowDrop = true;
            this.btnmedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedia.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnmedia.Location = new System.Drawing.Point(-1, 106);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmedia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnmedia.Size = new System.Drawing.Size(253, 45);
            this.btnmedia.TabIndex = 2;
            this.btnmedia.Text = "Menú";
            this.btnmedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // PanelSubMenú
            // 
            this.PanelSubMenú.AllowDrop = true;
            this.PanelSubMenú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelSubMenú.Controls.Add(this.BtnAgregarClientes);
            this.PanelSubMenú.Controls.Add(this.BtnProductos);
            this.PanelSubMenú.Location = new System.Drawing.Point(0, 148);
            this.PanelSubMenú.Name = "PanelSubMenú";
            this.PanelSubMenú.Size = new System.Drawing.Size(252, 101);
            this.PanelSubMenú.TabIndex = 2;
            // 
            // BtnAgregarClientes
            // 
            this.BtnAgregarClientes.AllowDrop = true;
            this.BtnAgregarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgregarClientes.FlatAppearance.BorderSize = 0;
            this.BtnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnAgregarClientes.Location = new System.Drawing.Point(0, 49);
            this.BtnAgregarClientes.Name = "BtnAgregarClientes";
            this.BtnAgregarClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAgregarClientes.Size = new System.Drawing.Size(252, 47);
            this.BtnAgregarClientes.TabIndex = 2;
            this.BtnAgregarClientes.Text = "Alta Cliente";
            this.BtnAgregarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarClientes.UseVisualStyleBackColor = true;
            this.BtnAgregarClientes.Click += new System.EventHandler(this.BtnAgregarClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.AllowDrop = true;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnProductos.Location = new System.Drawing.Point(0, 0);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnProductos.Size = new System.Drawing.Size(252, 49);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.labelFec);
            this.panel2.Controls.Add(this.labelhor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(252, 792);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 56);
            this.panel2.TabIndex = 5;
            // 
            // labelFec
            // 
            this.labelFec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFec.AutoSize = true;
            this.labelFec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFec.Location = new System.Drawing.Point(926, 27);
            this.labelFec.Name = "labelFec";
            this.labelFec.Size = new System.Drawing.Size(41, 15);
            this.labelFec.TabIndex = 1;
            this.labelFec.Text = "label2";
            // 
            // labelhor
            // 
            this.labelhor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelhor.AutoSize = true;
            this.labelhor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelhor.Location = new System.Drawing.Point(926, 7);
            this.labelhor.Name = "labelhor";
            this.labelhor.Size = new System.Drawing.Size(41, 15);
            this.labelhor.TabIndex = 0;
            this.labelhor.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 848);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuLateral);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1120, 886);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuLateral.ResumeLayout(false);
            this.PanelSubMenú.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Panel PanelSubMenú;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFec;
        private System.Windows.Forms.Label labelhor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnAgregarClientes;
        private System.Windows.Forms.Button btnLogOut;
    }
}