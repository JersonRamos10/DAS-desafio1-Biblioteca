namespace Biblioteca
{
    partial class PagePrincipalBiblio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePrincipalBiblio));
            sidebar = new Panel();
            btnVerGraficos = new Button();
            btnGestionPrestamos = new Button();
            btnUser = new Button();
            btnLibros = new Button();
            panel1 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            btnHamburger = new PictureBox();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHamburger).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(15, 15, 15);
            sidebar.Controls.Add(btnVerGraficos);
            sidebar.Controls.Add(btnGestionPrestamos);
            sidebar.Controls.Add(btnUser);
            sidebar.Controls.Add(btnLibros);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(212, 692);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
            // 
            // btnVerGraficos
            // 
            btnVerGraficos.FlatAppearance.BorderSize = 0;
            btnVerGraficos.FlatStyle = FlatStyle.Flat;
            btnVerGraficos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerGraficos.ForeColor = Color.White;
            btnVerGraficos.Image = (Image)resources.GetObject("btnVerGraficos.Image");
            btnVerGraficos.Location = new Point(13, 432);
            btnVerGraficos.Name = "btnVerGraficos";
            btnVerGraficos.Size = new Size(148, 67);
            btnVerGraficos.TabIndex = 0;
            btnVerGraficos.Text = "Graficos";
            btnVerGraficos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerGraficos.UseVisualStyleBackColor = true;
            btnVerGraficos.Click += btnVerGraficos_Click;
            // 
            // btnGestionPrestamos
            // 
            btnGestionPrestamos.BackColor = Color.Transparent;
            btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            btnGestionPrestamos.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGestionPrestamos.FlatStyle = FlatStyle.Flat;
            btnGestionPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionPrestamos.ForeColor = SystemColors.ControlLight;
            btnGestionPrestamos.Image = (Image)resources.GetObject("btnGestionPrestamos.Image");
            btnGestionPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionPrestamos.Location = new Point(-16, 357);
            btnGestionPrestamos.Name = "btnGestionPrestamos";
            btnGestionPrestamos.Padding = new Padding(30, 0, 0, 0);
            btnGestionPrestamos.Size = new Size(250, 40);
            btnGestionPrestamos.TabIndex = 2;
            btnGestionPrestamos.Text = "      Gestion";
            btnGestionPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionPrestamos.UseVisualStyleBackColor = false;
            btnGestionPrestamos.Click += btnGestionPrestamos_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.ControlLight;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(-16, 264);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(30, 0, 0, 0);
            btnUser.Size = new Size(250, 40);
            btnUser.TabIndex = 1;
            btnUser.Text = "       Gestion Usuarios";
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.Transparent;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibros.ForeColor = SystemColors.ControlLight;
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(-16, 171);
            btnLibros.Name = "btnLibros";
            btnLibros.Padding = new Padding(30, 0, 0, 0);
            btnLibros.Size = new Size(250, 40);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "       Libros";
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(-9, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 54);
            label1.TabIndex = 0;
            label1.Text = "BV";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 15, 15);
            panel2.Controls.Add(btnHamburger);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(212, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 50);
            panel2.TabIndex = 1;
            // 
            // btnHamburger
            // 
            btnHamburger.Cursor = Cursors.Hand;
            btnHamburger.Image = (Image)resources.GetObject("btnHamburger.Image");
            btnHamburger.Location = new Point(6, 3);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(35, 35);
            btnHamburger.SizeMode = PictureBoxSizeMode.Zoom;
            btnHamburger.TabIndex = 0;
            btnHamburger.TabStop = false;
            btnHamburger.Click += btnHamburger_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(44, 44, 44);
            panelContenedor.BackgroundImageLayout = ImageLayout.None;
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(212, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1145, 642);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(398, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 256);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PagePrincipalBiblio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 692);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "PagePrincipalBiblio";
            Text = "formBiblioteca";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHamburger).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panelContenedor;
        private Panel panel1;
        private Label label1;
        private PictureBox btnHamburger;
        private Button btnLibros;
        private PictureBox pictureBox1;
        private Button btnUser;
        private Button btnGestionPrestamos;
        private Button btnVerGraficos;
        private PictureBox pictureBox2;
    }
}