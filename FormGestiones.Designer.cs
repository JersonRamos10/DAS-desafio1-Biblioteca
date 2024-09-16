namespace Biblioteca
{
    partial class FormGestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestiones));
            panelRegistroPrestamo = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnCancelarPrestamo = new Button();
            btnConfirmarPrestamo = new Button();
            dateTimeFechaPrestamo = new DateTimePicker();
            dateTimeFechaDevolucion = new DateTimePicker();
            txtLibroIdPrestamo = new TextBox();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtUsuarioId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBuscarPorId = new Button();
            btnFiltrar = new Button();
            btnConfirmarDevolucion = new Button();
            btnPrestarLibro = new Button();
            dgvLibrosDisponibles = new DataGridView();
            lstLibrosEncontrados = new ListBox();
            dgvUsuariosRegistrados = new DataGridView();
            dgvLibrosPrestados = new DataGridView();
            txtBuscarPorId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panelDevolver = new Panel();
            cbUsuarioId = new ComboBox();
            label10 = new Label();
            txtIdUsuarioDevolucion = new TextBox();
            btnCerrarPanelDevolucion = new Button();
            label9 = new Label();
            txtIdLibroDevolucion = new TextBox();
            btnAbrirPanelDevolucion = new Button();
            label11 = new Label();
            panelRegistroPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosRegistrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPrestados).BeginInit();
            panelDevolver.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistroPrestamo
            // 
            panelRegistroPrestamo.Controls.Add(label8);
            panelRegistroPrestamo.Controls.Add(label7);
            panelRegistroPrestamo.Controls.Add(label6);
            panelRegistroPrestamo.Controls.Add(btnCancelarPrestamo);
            panelRegistroPrestamo.Controls.Add(btnConfirmarPrestamo);
            panelRegistroPrestamo.Controls.Add(dateTimeFechaPrestamo);
            panelRegistroPrestamo.Controls.Add(dateTimeFechaDevolucion);
            panelRegistroPrestamo.Controls.Add(txtLibroIdPrestamo);
            panelRegistroPrestamo.Controls.Add(label3);
            panelRegistroPrestamo.Controls.Add(txtNombreUsuario);
            panelRegistroPrestamo.Controls.Add(txtUsuarioId);
            panelRegistroPrestamo.Controls.Add(label2);
            panelRegistroPrestamo.Controls.Add(label1);
            panelRegistroPrestamo.Location = new Point(0, 302);
            panelRegistroPrestamo.Name = "panelRegistroPrestamo";
            panelRegistroPrestamo.Size = new Size(323, 220);
            panelRegistroPrestamo.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 138);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 20;
            label8.Text = "Fecha de Prestamo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 184);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 19;
            label7.Text = "Fecha de Entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(92, 2);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 18;
            label6.Text = "Registro de Prestamos";
            // 
            // btnCancelarPrestamo
            // 
            btnCancelarPrestamo.BackColor = Color.FromArgb(134, 92, 233);
            btnCancelarPrestamo.FlatAppearance.BorderSize = 0;
            btnCancelarPrestamo.FlatStyle = FlatStyle.Flat;
            btnCancelarPrestamo.ForeColor = SystemColors.Control;
            btnCancelarPrestamo.Location = new Point(238, 134);
            btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            btnCancelarPrestamo.Size = new Size(75, 23);
            btnCancelarPrestamo.TabIndex = 17;
            btnCancelarPrestamo.Text = "Cancelar";
            btnCancelarPrestamo.UseVisualStyleBackColor = false;
            btnCancelarPrestamo.Click += btnCancelarPrestamo_Click_1;
            // 
            // btnConfirmarPrestamo
            // 
            btnConfirmarPrestamo.BackColor = Color.FromArgb(134, 92, 233);
            btnConfirmarPrestamo.FlatAppearance.BorderSize = 0;
            btnConfirmarPrestamo.FlatStyle = FlatStyle.Flat;
            btnConfirmarPrestamo.ForeColor = SystemColors.Control;
            btnConfirmarPrestamo.Location = new Point(236, 176);
            btnConfirmarPrestamo.Name = "btnConfirmarPrestamo";
            btnConfirmarPrestamo.Size = new Size(75, 23);
            btnConfirmarPrestamo.TabIndex = 16;
            btnConfirmarPrestamo.Text = "Confirmar";
            btnConfirmarPrestamo.UseVisualStyleBackColor = false;
            btnConfirmarPrestamo.Click += btnConfirmarPrestamo_Click;
            // 
            // dateTimeFechaPrestamo
            // 
            dateTimeFechaPrestamo.Location = new Point(126, 138);
            dateTimeFechaPrestamo.Name = "dateTimeFechaPrestamo";
            dateTimeFechaPrestamo.Size = new Size(84, 23);
            dateTimeFechaPrestamo.TabIndex = 13;
            // 
            // dateTimeFechaDevolucion
            // 
            dateTimeFechaDevolucion.Location = new Point(121, 178);
            dateTimeFechaDevolucion.Name = "dateTimeFechaDevolucion";
            dateTimeFechaDevolucion.Size = new Size(97, 23);
            dateTimeFechaDevolucion.TabIndex = 14;
            // 
            // txtLibroIdPrestamo
            // 
            txtLibroIdPrestamo.Location = new Point(116, 31);
            txtLibroIdPrestamo.Name = "txtLibroIdPrestamo";
            txtLibroIdPrestamo.Size = new Size(100, 23);
            txtLibroIdPrestamo.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 34);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 13;
            label3.Text = "ID libro";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(116, 62);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtUsuarioId
            // 
            txtUsuarioId.Location = new Point(115, 99);
            txtUsuarioId.Name = "txtUsuarioId";
            txtUsuarioId.Size = new Size(100, 23);
            txtUsuarioId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "ID usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Usuario";
            // 
            // btnBuscarPorId
            // 
            btnBuscarPorId.BackColor = Color.FromArgb(134, 92, 233);
            btnBuscarPorId.FlatAppearance.BorderSize = 0;
            btnBuscarPorId.FlatStyle = FlatStyle.Flat;
            btnBuscarPorId.ForeColor = SystemColors.Control;
            btnBuscarPorId.Location = new Point(968, 35);
            btnBuscarPorId.Name = "btnBuscarPorId";
            btnBuscarPorId.Size = new Size(75, 23);
            btnBuscarPorId.TabIndex = 15;
            btnBuscarPorId.Text = "buscar";
            btnBuscarPorId.UseVisualStyleBackColor = false;
            btnBuscarPorId.Click += btnBuscarPorId_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(134, 92, 233);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.ForeColor = SystemColors.ControlDark;
            btnFiltrar.Location = new Point(887, 66);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 14;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnConfirmarDevolucion
            // 
            btnConfirmarDevolucion.BackColor = Color.FromArgb(134, 92, 233);
            btnConfirmarDevolucion.FlatAppearance.BorderSize = 0;
            btnConfirmarDevolucion.FlatStyle = FlatStyle.Flat;
            btnConfirmarDevolucion.Location = new Point(180, 32);
            btnConfirmarDevolucion.Name = "btnConfirmarDevolucion";
            btnConfirmarDevolucion.Size = new Size(75, 23);
            btnConfirmarDevolucion.TabIndex = 9;
            btnConfirmarDevolucion.Text = "Devolver";
            btnConfirmarDevolucion.UseVisualStyleBackColor = false;
            btnConfirmarDevolucion.Click += btnDevolver_Click;
            // 
            // btnPrestarLibro
            // 
            btnPrestarLibro.BackColor = Color.FromArgb(134, 92, 233);
            btnPrestarLibro.FlatAppearance.BorderSize = 0;
            btnPrestarLibro.FlatStyle = FlatStyle.Flat;
            btnPrestarLibro.ForeColor = SystemColors.Control;
            btnPrestarLibro.ImageAlign = ContentAlignment.MiddleRight;
            btnPrestarLibro.Location = new Point(968, 66);
            btnPrestarLibro.Name = "btnPrestarLibro";
            btnPrestarLibro.Size = new Size(75, 23);
            btnPrestarLibro.TabIndex = 8;
            btnPrestarLibro.Text = "Prestar ";
            btnPrestarLibro.UseVisualStyleBackColor = false;
            btnPrestarLibro.Click += btnPrestarLibro_Click;
            // 
            // dgvLibrosDisponibles
            // 
            dgvLibrosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrosDisponibles.Location = new Point(1, 150);
            dgvLibrosDisponibles.Name = "dgvLibrosDisponibles";
            dgvLibrosDisponibles.RowTemplate.Height = 25;
            dgvLibrosDisponibles.Size = new Size(348, 142);
            dgvLibrosDisponibles.TabIndex = 5;
            // 
            // lstLibrosEncontrados
            // 
            lstLibrosEncontrados.FormattingEnabled = true;
            lstLibrosEncontrados.ItemHeight = 15;
            lstLibrosEncontrados.Location = new Point(748, 126);
            lstLibrosEncontrados.Name = "lstLibrosEncontrados";
            lstLibrosEncontrados.Size = new Size(295, 79);
            lstLibrosEncontrados.TabIndex = 6;
            // 
            // dgvUsuariosRegistrados
            // 
            dgvUsuariosRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosRegistrados.Location = new Point(1, 5);
            dgvUsuariosRegistrados.Name = "dgvUsuariosRegistrados";
            dgvUsuariosRegistrados.RowTemplate.Height = 25;
            dgvUsuariosRegistrados.Size = new Size(348, 134);
            dgvUsuariosRegistrados.TabIndex = 7;
            // 
            // dgvLibrosPrestados
            // 
            dgvLibrosPrestados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrosPrestados.Location = new Point(369, 329);
            dgvLibrosPrestados.Name = "dgvLibrosPrestados";
            dgvLibrosPrestados.RowTemplate.Height = 25;
            dgvLibrosPrestados.Size = new Size(646, 189);
            dgvLibrosPrestados.TabIndex = 12;
            // 
            // txtBuscarPorId
            // 
            txtBuscarPorId.Location = new Point(862, 35);
            txtBuscarPorId.Name = "txtBuscarPorId";
            txtBuscarPorId.Size = new Size(100, 23);
            txtBuscarPorId.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(568, 300);
            label4.Name = "label4";
            label4.Size = new Size(206, 22);
            label4.TabIndex = 18;
            label4.Text = "LIBROS EN PRESTAMO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(911, 9);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 20;
            label5.Text = "Buscar Libro";
            // 
            // panelDevolver
            // 
            panelDevolver.Controls.Add(label10);
            panelDevolver.Controls.Add(txtIdUsuarioDevolucion);
            panelDevolver.Controls.Add(btnCerrarPanelDevolucion);
            panelDevolver.Controls.Add(label9);
            panelDevolver.Controls.Add(btnConfirmarDevolucion);
            panelDevolver.Controls.Add(txtIdLibroDevolucion);
            panelDevolver.Location = new Point(386, 9);
            panelDevolver.Name = "panelDevolver";
            panelDevolver.Size = new Size(307, 118);
            panelDevolver.TabIndex = 21;
            // 
            // cbUsuarioId
            // 
            cbUsuarioId.FormattingEnabled = true;
            cbUsuarioId.Location = new Point(833, 67);
            cbUsuarioId.Name = "cbUsuarioId";
            cbUsuarioId.Size = new Size(48, 23);
            cbUsuarioId.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 61);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 26;
            label10.Text = "ID Usuario";
            // 
            // txtIdUsuarioDevolucion
            // 
            txtIdUsuarioDevolucion.Location = new Point(73, 56);
            txtIdUsuarioDevolucion.Name = "txtIdUsuarioDevolucion";
            txtIdUsuarioDevolucion.Size = new Size(100, 23);
            txtIdUsuarioDevolucion.TabIndex = 25;
            // 
            // btnCerrarPanelDevolucion
            // 
            btnCerrarPanelDevolucion.FlatAppearance.BorderSize = 0;
            btnCerrarPanelDevolucion.FlatStyle = FlatStyle.Flat;
            btnCerrarPanelDevolucion.Image = (Image)resources.GetObject("btnCerrarPanelDevolucion.Image");
            btnCerrarPanelDevolucion.Location = new Point(242, 61);
            btnCerrarPanelDevolucion.Name = "btnCerrarPanelDevolucion";
            btnCerrarPanelDevolucion.Size = new Size(75, 33);
            btnCerrarPanelDevolucion.TabIndex = 24;
            btnCerrarPanelDevolucion.UseVisualStyleBackColor = true;
            btnCerrarPanelDevolucion.Click += btnCerrarPanelDevolucion_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 17);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 23;
            label9.Text = "ID libro";
            // 
            // txtIdLibroDevolucion
            // 
            txtIdLibroDevolucion.Location = new Point(72, 9);
            txtIdLibroDevolucion.Name = "txtIdLibroDevolucion";
            txtIdLibroDevolucion.Size = new Size(100, 23);
            txtIdLibroDevolucion.TabIndex = 22;
            // 
            // btnAbrirPanelDevolucion
            // 
            btnAbrirPanelDevolucion.FlatAppearance.BorderSize = 0;
            btnAbrirPanelDevolucion.FlatStyle = FlatStyle.Flat;
            btnAbrirPanelDevolucion.Image = (Image)resources.GetObject("btnAbrirPanelDevolucion.Image");
            btnAbrirPanelDevolucion.Location = new Point(699, 4);
            btnAbrirPanelDevolucion.Name = "btnAbrirPanelDevolucion";
            btnAbrirPanelDevolucion.Size = new Size(75, 37);
            btnAbrirPanelDevolucion.TabIndex = 22;
            btnAbrirPanelDevolucion.UseVisualStyleBackColor = true;
            btnAbrirPanelDevolucion.Click += btnAbrirPanelDevolucion_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(702, 39);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 27;
            label11.Text = "Devoluciones";
            // 
            // FormGestiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 31);
            ClientSize = new Size(1056, 522);
            Controls.Add(cbUsuarioId);
            Controls.Add(label11);
            Controls.Add(btnAbrirPanelDevolucion);
            Controls.Add(panelDevolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnFiltrar);
            Controls.Add(txtBuscarPorId);
            Controls.Add(dgvLibrosPrestados);
            Controls.Add(btnBuscarPorId);
            Controls.Add(dgvUsuariosRegistrados);
            Controls.Add(lstLibrosEncontrados);
            Controls.Add(dgvLibrosDisponibles);
            Controls.Add(panelRegistroPrestamo);
            Controls.Add(btnPrestarLibro);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestiones";
            Text = "FormGestiones";
            Load += FormGestiones_Load;
            panelRegistroPrestamo.ResumeLayout(false);
            panelRegistroPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosRegistrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPrestados).EndInit();
            panelDevolver.ResumeLayout(false);
            panelDevolver.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRegistroPrestamo;
        private Label label1;
        private Label label2;
        private TextBox txtUsuarioId;
        private TextBox txtNombreUsuario;
        private DataGridView dgvLibrosDisponibles;
        private ListBox lstLibrosEncontrados;
        private DataGridView dgvUsuariosRegistrados;
        private Button btnPrestarLibro;
        private Button btnConfirmarDevolucion;
        private TextBox txtLibroIdPrestamo;
        private Label label3;
        private DataGridView dgvLibrosPrestados;
        private Button btnFiltrar;
        private DateTimePicker dateTimeFechaPrestamo;
        private DateTimePicker dateTimeFechaDevolucion;
        private Button btnBuscarPorId;
        private Button btnConfirmarPrestamo;
        private Button btnCancelarPrestamo;
        private TextBox txtBuscarPorId;
        private DataGridView dgvHistorialUsuario;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panelDevolver;
        private Label label8;
        private Label label7;
        private TextBox txtIdLibroDevolucion;
        private Label label9;
        private Button btnCerrarPanelDevolucion;
        private Button btnAbrirPanelDevolucion;
        private Label label10;
        private TextBox txtIdUsuarioDevolucion;
        private ComboBox cbUsuarioId;
        private Label label11;
    }
}