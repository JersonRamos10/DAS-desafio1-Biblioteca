namespace Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            txtTelefonoUsuario = new TextBox();
            txtApellidoUsuario = new TextBox();
            label6 = new Label();
            cbTipoUsuario = new ComboBox();
            dateTimeFechaRegistro = new DateTimePicker();
            label7 = new Label();
            btnAñadirUsuario = new Button();
            btnActaulizarUsuario = new Button();
            btnEliminarUsuario = new Button();
            dataGridViewUsuarios = new DataGridView();
            chkCambiarId = new CheckBox();
            panelActualizar = new Panel();
            label16 = new Label();
            label15 = new Label();
            dateTimeRegistroActualizar = new DateTimePicker();
            txtTelefonoActualizar = new TextBox();
            txtEmailActualizar = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtApellidoActualizar = new TextBox();
            txtNombreActualizar = new TextBox();
            txtIdUsuarioActualizar = new TextBox();
            label9 = new Label();
            label8 = new Label();
            panelEliminar = new Panel();
            label18 = new Label();
            txtIdEliminar = new TextBox();
            btnCerrarPanelEliminar = new Button();
            btnAbrirPanelEliminar = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelActualizar.SuspendLayout();
            panelEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(89, 88);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(196, 85);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(132, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(335, 41);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 2;
            label2.Text = "Correo (Email)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(335, 87);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(333, 133);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 4;
            label4.Text = "Tipo de Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(85, 39);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 5;
            label5.Text = "ID Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(196, 41);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(132, 23);
            txtIdUsuario.TabIndex = 6;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Location = new Point(464, 43);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(100, 23);
            txtEmailUsuario.TabIndex = 7;
            // 
            // txtTelefonoUsuario
            // 
            txtTelefonoUsuario.Location = new Point(465, 87);
            txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            txtTelefonoUsuario.Size = new Size(100, 23);
            txtTelefonoUsuario.TabIndex = 8;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Location = new Point(195, 133);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(132, 23);
            txtApellidoUsuario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(91, 131);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
            // 
            // cbTipoUsuario
            // 
            cbTipoUsuario.FormattingEnabled = true;
            cbTipoUsuario.Location = new Point(461, 132);
            cbTipoUsuario.Name = "cbTipoUsuario";
            cbTipoUsuario.Size = new Size(121, 23);
            cbTipoUsuario.TabIndex = 12;
            // 
            // dateTimeFechaRegistro
            // 
            dateTimeFechaRegistro.Location = new Point(755, 42);
            dateTimeFechaRegistro.Name = "dateTimeFechaRegistro";
            dateTimeFechaRegistro.Size = new Size(109, 23);
            dateTimeFechaRegistro.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(598, 43);
            label7.Name = "label7";
            label7.Size = new Size(144, 21);
            label7.TabIndex = 14;
            label7.Text = "Fecha de Registro";
            // 
            // btnAñadirUsuario
            // 
            btnAñadirUsuario.BackColor = Color.FromArgb(134, 92, 233);
            btnAñadirUsuario.Cursor = Cursors.Hand;
            btnAñadirUsuario.FlatAppearance.BorderColor = Color.FromArgb(58, 29, 127);
            btnAñadirUsuario.FlatAppearance.BorderSize = 0;
            btnAñadirUsuario.FlatStyle = FlatStyle.Flat;
            btnAñadirUsuario.ForeColor = Color.White;
            btnAñadirUsuario.Location = new Point(667, 83);
            btnAñadirUsuario.Name = "btnAñadirUsuario";
            btnAñadirUsuario.Size = new Size(75, 25);
            btnAñadirUsuario.TabIndex = 15;
            btnAñadirUsuario.Text = "Añadir";
            btnAñadirUsuario.UseVisualStyleBackColor = false;
            btnAñadirUsuario.Click += btnAñadirUsuario_Click;
            // 
            // btnActaulizarUsuario
            // 
            btnActaulizarUsuario.BackColor = Color.FromArgb(134, 92, 233);
            btnActaulizarUsuario.FlatAppearance.BorderColor = Color.FromArgb(134, 92, 233);
            btnActaulizarUsuario.FlatAppearance.BorderSize = 0;
            btnActaulizarUsuario.FlatStyle = FlatStyle.Flat;
            btnActaulizarUsuario.ForeColor = Color.White;
            btnActaulizarUsuario.Location = new Point(91, 537);
            btnActaulizarUsuario.Name = "btnActaulizarUsuario";
            btnActaulizarUsuario.Size = new Size(75, 23);
            btnActaulizarUsuario.TabIndex = 16;
            btnActaulizarUsuario.Text = "Actualizar";
            btnActaulizarUsuario.UseVisualStyleBackColor = false;
            btnActaulizarUsuario.Click += btnActaulizarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.FlatAppearance.BorderColor = Color.White;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.Location = new Point(155, 68);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 17;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(44, 44, 44);
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(91, 218);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowTemplate.Height = 25;
            dataGridViewUsuarios.Size = new Size(731, 268);
            dataGridViewUsuarios.TabIndex = 18;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            // 
            // chkCambiarId
            // 
            chkCambiarId.AutoSize = true;
            chkCambiarId.BackColor = Color.Transparent;
            chkCambiarId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCambiarId.ForeColor = Color.LightGray;
            chkCambiarId.Location = new Point(33, 153);
            chkCambiarId.Name = "chkCambiarId";
            chkCambiarId.Size = new Size(204, 25);
            chkCambiarId.TabIndex = 19;
            chkCambiarId.Text = "Cambiar ID de Usuario";
            chkCambiarId.UseVisualStyleBackColor = false;
            chkCambiarId.CheckedChanged += chkCambiarId_CheckedChanged;
            // 
            // panelActualizar
            // 
            panelActualizar.BackColor = Color.FromArgb(44, 44, 44);
            panelActualizar.Controls.Add(label16);
            panelActualizar.Controls.Add(label15);
            panelActualizar.Controls.Add(chkCambiarId);
            panelActualizar.Controls.Add(dateTimeRegistroActualizar);
            panelActualizar.Controls.Add(txtTelefonoActualizar);
            panelActualizar.Controls.Add(txtEmailActualizar);
            panelActualizar.Controls.Add(label14);
            panelActualizar.Controls.Add(label13);
            panelActualizar.Controls.Add(label12);
            panelActualizar.Controls.Add(label11);
            panelActualizar.Controls.Add(label10);
            panelActualizar.Controls.Add(txtApellidoActualizar);
            panelActualizar.Controls.Add(txtNombreActualizar);
            panelActualizar.Controls.Add(txtIdUsuarioActualizar);
            panelActualizar.Controls.Add(label9);
            panelActualizar.Controls.Add(label8);
            panelActualizar.Controls.Add(btnActaulizarUsuario);
            panelActualizar.Dock = DockStyle.Right;
            panelActualizar.Location = new Point(888, 0);
            panelActualizar.Name = "panelActualizar";
            panelActualizar.Size = new Size(257, 642);
            panelActualizar.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.LightGray;
            label16.Location = new Point(110, 33);
            label16.Name = "label16";
            label16.Size = new Size(44, 24);
            label16.TabIndex = 30;
            label16.Text = "de ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(62, 6);
            label15.Name = "label15";
            label15.Size = new Size(154, 24);
            label15.TabIndex = 29;
            label15.Text = "Actualizacion ";
            // 
            // dateTimeRegistroActualizar
            // 
            dateTimeRegistroActualizar.Location = new Point(51, 493);
            dateTimeRegistroActualizar.Name = "dateTimeRegistroActualizar";
            dateTimeRegistroActualizar.Size = new Size(146, 23);
            dateTimeRegistroActualizar.TabIndex = 28;
            // 
            // txtTelefonoActualizar
            // 
            txtTelefonoActualizar.Location = new Point(51, 430);
            txtTelefonoActualizar.Name = "txtTelefonoActualizar";
            txtTelefonoActualizar.Size = new Size(146, 23);
            txtTelefonoActualizar.TabIndex = 27;
            // 
            // txtEmailActualizar
            // 
            txtEmailActualizar.Location = new Point(51, 358);
            txtEmailActualizar.Name = "txtEmailActualizar";
            txtEmailActualizar.Size = new Size(146, 23);
            txtEmailActualizar.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.LightGray;
            label14.Location = new Point(51, 462);
            label14.Name = "label14";
            label14.Size = new Size(150, 21);
            label14.TabIndex = 26;
            label14.Text = "Fecha de Registro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(97, 57);
            label13.Name = "label13";
            label13.Size = new Size(69, 24);
            label13.TabIndex = 25;
            label13.Text = "Datos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.LightGray;
            label12.Location = new Point(51, 397);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 24;
            label12.Text = "Telefono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(46, 322);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 23;
            label11.Text = "Correo (Email)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(51, 257);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 22;
            label10.Text = "Apellido";
            // 
            // txtApellidoActualizar
            // 
            txtApellidoActualizar.Location = new Point(51, 296);
            txtApellidoActualizar.Name = "txtApellidoActualizar";
            txtApellidoActualizar.Size = new Size(146, 23);
            txtApellidoActualizar.TabIndex = 21;
            // 
            // txtNombreActualizar
            // 
            txtNombreActualizar.Location = new Point(51, 231);
            txtNombreActualizar.Name = "txtNombreActualizar";
            txtNombreActualizar.Size = new Size(146, 23);
            txtNombreActualizar.TabIndex = 20;
            // 
            // txtIdUsuarioActualizar
            // 
            txtIdUsuarioActualizar.BorderStyle = BorderStyle.None;
            txtIdUsuarioActualizar.Location = new Point(55, 131);
            txtIdUsuarioActualizar.Name = "txtIdUsuarioActualizar";
            txtIdUsuarioActualizar.Size = new Size(146, 16);
            txtIdUsuarioActualizar.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(51, 199);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 18;
            label9.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(51, 99);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 17;
            label8.Text = "ID Usuario";
            // 
            // panelEliminar
            // 
            panelEliminar.BackColor = Color.FromArgb(44, 44, 44);
            panelEliminar.Controls.Add(label18);
            panelEliminar.Controls.Add(txtIdEliminar);
            panelEliminar.Controls.Add(btnCerrarPanelEliminar);
            panelEliminar.Controls.Add(btnEliminarUsuario);
            panelEliminar.Location = new Point(13, 525);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(270, 98);
            panelEliminar.TabIndex = 22;
            panelEliminar.Paint += panelEliminar_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Silver;
            label18.Location = new Point(28, 26);
            label18.Name = "label18";
            label18.Size = new Size(90, 21);
            label18.TabIndex = 26;
            label18.Text = "ID Usuario";
            label18.Click += label18_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(28, 68);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(100, 23);
            txtIdEliminar.TabIndex = 25;
            txtIdEliminar.TextChanged += textBox1_TextChanged;
            // 
            // btnCerrarPanelEliminar
            // 
            btnCerrarPanelEliminar.BackColor = Color.Transparent;
            btnCerrarPanelEliminar.BackgroundImage = (Image)resources.GetObject("btnCerrarPanelEliminar.BackgroundImage");
            btnCerrarPanelEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnCerrarPanelEliminar.Cursor = Cursors.Hand;
            btnCerrarPanelEliminar.FlatAppearance.BorderSize = 0;
            btnCerrarPanelEliminar.FlatStyle = FlatStyle.Flat;
            btnCerrarPanelEliminar.Location = new Point(207, 0);
            btnCerrarPanelEliminar.Name = "btnCerrarPanelEliminar";
            btnCerrarPanelEliminar.Size = new Size(75, 46);
            btnCerrarPanelEliminar.TabIndex = 24;
            btnCerrarPanelEliminar.UseVisualStyleBackColor = false;
            btnCerrarPanelEliminar.Click += btnCerrarPanelEliminar_Click;
            // 
            // btnAbrirPanelEliminar
            // 
            btnAbrirPanelEliminar.BackColor = Color.Transparent;
            btnAbrirPanelEliminar.FlatAppearance.BorderSize = 0;
            btnAbrirPanelEliminar.FlatStyle = FlatStyle.Flat;
            btnAbrirPanelEliminar.Image = (Image)resources.GetObject("btnAbrirPanelEliminar.Image");
            btnAbrirPanelEliminar.Location = new Point(-14, 477);
            btnAbrirPanelEliminar.Name = "btnAbrirPanelEliminar";
            btnAbrirPanelEliminar.Size = new Size(60, 41);
            btnAbrirPanelEliminar.TabIndex = 23;
            btnAbrirPanelEliminar.UseVisualStyleBackColor = false;
            btnAbrirPanelEliminar.Click += btnAbrirPanelEliminar_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 33);
            panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(1145, 642);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAbrirPanelEliminar);
            Controls.Add(panelEliminar);
            Controls.Add(panelActualizar);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(btnAñadirUsuario);
            Controls.Add(label7);
            Controls.Add(dateTimeFechaRegistro);
            Controls.Add(cbTipoUsuario);
            Controls.Add(label6);
            Controls.Add(txtApellidoUsuario);
            Controls.Add(txtTelefonoUsuario);
            Controls.Add(txtEmailUsuario);
            Controls.Add(txtIdUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuario";
            Opacity = 0.9D;
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelActualizar.ResumeLayout(false);
            panelActualizar.PerformLayout();
            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdUsuario;
        private TextBox txtEmailUsuario;
        private TextBox txtTelefonoUsuario;
        private TextBox txtApellidoUsuario;
        private Label label6;
        private ComboBox cbTipoUsuario;
        private DateTimePicker dateTimeFechaRegistro;
        private Label label7;
        private Button btnAñadirUsuario;
        private Button btnActaulizarUsuario;
        private Button btnEliminarUsuario;
        private DataGridView dataGridViewUsuarios;
        private CheckBox chkCambiarId;
        private Panel panelActualizar;
        private TextBox txtTelefonoActualizar;
        private TextBox txtEmailActualizar;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtApellidoActualizar;
        private TextBox txtNombreActualizar;
        private TextBox txtIdUsuarioActualizar;
        private Label label9;
        private Label label8;
        private Label label15;
        private DateTimePicker dateTimeRegistroActualizar;
        private Label label16;
        private Panel panelEliminar;
        private Label label18;
        private TextBox txtIdEliminar;
        private Button btnCerrarPanelEliminar;
        private Button btnAbrirPanelEliminar;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}