namespace Biblioteca
{
    partial class Formlibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlibros));
            txtIdLibro = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtIdioma = new TextBox();
            txtNumEjemplares = new TextBox();
            txtBuscar = new TextBox();
            dateTimeFecha = new DateTimePicker();
            panelActualizarLibros = new Panel();
            label18 = new Label();
            label9 = new Label();
            btnCerrarPanelAct = new Button();
            label15 = new Label();
            txtIdiomaActualizar = new TextBox();
            btnActualizar = new Button();
            label10 = new Label();
            txtAutorActualizar = new TextBox();
            txtNumEjemplaresActualizar = new TextBox();
            label11 = new Label();
            txtTituloActualizar = new TextBox();
            dateTimeFechaActualizar = new DateTimePicker();
            label12 = new Label();
            txtIdLibroActualizar = new TextBox();
            label13 = new Label();
            cbCategoriaActualizar = new ComboBox();
            label14 = new Label();
            btnAbrirPanel = new Button();
            btnCerrarPanel = new Button();
            cbCategoria = new ComboBox();
            dataGridViewDatosLibros = new DataGridView();
            btnAñadirLibro = new Button();
            btnEliminar = new Button();
            panelRegistroLibros = new Panel();
            label19 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAbrirPanelAct = new Button();
            panelEliminar = new Panel();
            label16 = new Label();
            txtLIbroIdEliminar = new TextBox();
            cbFiltroPrincipal = new ComboBox();
            cbFiltroSecundario = new ComboBox();
            btnBuscarLibro = new Button();
            listResultados = new ListBox();
            label17 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            panelActualizarLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatosLibros).BeginInit();
            panelRegistroLibros.SuspendLayout();
            panelEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdLibro
            // 
            txtIdLibro.Location = new Point(62, 75);
            txtIdLibro.Name = "txtIdLibro";
            txtIdLibro.Size = new Size(100, 23);
            txtIdLibro.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(62, 128);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(62, 183);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 2;
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(59, 375);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(100, 23);
            txtIdioma.TabIndex = 3;
            // 
            // txtNumEjemplares
            // 
            txtNumEjemplares.Location = new Point(59, 443);
            txtNumEjemplares.Name = "txtNumEjemplares";
            txtNumEjemplares.Size = new Size(100, 23);
            txtNumEjemplares.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(448, 9);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 5;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Location = new Point(51, 316);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(129, 23);
            dateTimeFecha.TabIndex = 6;
            // 
            // panelActualizarLibros
            // 
            panelActualizarLibros.BackColor = Color.FromArgb(44, 44, 44);
            panelActualizarLibros.Controls.Add(label18);
            panelActualizarLibros.Controls.Add(label9);
            panelActualizarLibros.Controls.Add(btnCerrarPanelAct);
            panelActualizarLibros.Controls.Add(label15);
            panelActualizarLibros.Controls.Add(txtIdiomaActualizar);
            panelActualizarLibros.Controls.Add(btnActualizar);
            panelActualizarLibros.Controls.Add(label10);
            panelActualizarLibros.Controls.Add(txtAutorActualizar);
            panelActualizarLibros.Controls.Add(txtNumEjemplaresActualizar);
            panelActualizarLibros.Controls.Add(label11);
            panelActualizarLibros.Controls.Add(txtTituloActualizar);
            panelActualizarLibros.Controls.Add(dateTimeFechaActualizar);
            panelActualizarLibros.Controls.Add(label12);
            panelActualizarLibros.Controls.Add(txtIdLibroActualizar);
            panelActualizarLibros.Controls.Add(label13);
            panelActualizarLibros.Controls.Add(cbCategoriaActualizar);
            panelActualizarLibros.Controls.Add(label14);
            panelActualizarLibros.ForeColor = Color.Snow;
            panelActualizarLibros.Location = new Point(12, 136);
            panelActualizarLibros.Name = "panelActualizarLibros";
            panelActualizarLibros.Size = new Size(255, 463);
            panelActualizarLibros.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(66, 5);
            label18.Name = "label18";
            label18.Size = new Size(118, 21);
            label18.TabIndex = 29;
            label18.Text = "Actualizar Libro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 353);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 34;
            label9.Text = "N°Ejemplares";
            // 
            // btnCerrarPanelAct
            // 
            btnCerrarPanelAct.FlatAppearance.BorderSize = 0;
            btnCerrarPanelAct.FlatStyle = FlatStyle.Flat;
            btnCerrarPanelAct.Image = (Image)resources.GetObject("btnCerrarPanelAct.Image");
            btnCerrarPanelAct.Location = new Point(194, 2);
            btnCerrarPanelAct.Name = "btnCerrarPanelAct";
            btnCerrarPanelAct.Size = new Size(75, 23);
            btnCerrarPanelAct.TabIndex = 20;
            btnCerrarPanelAct.UseVisualStyleBackColor = true;
            btnCerrarPanelAct.Click += btnCerrarPanelAct_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 50);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 28;
            label15.Text = "ID libro";
            // 
            // txtIdiomaActualizar
            // 
            txtIdiomaActualizar.Location = new Point(120, 295);
            txtIdiomaActualizar.Name = "txtIdiomaActualizar";
            txtIdiomaActualizar.Size = new Size(100, 23);
            txtIdiomaActualizar.TabIndex = 24;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(134, 92, 233);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(82, 405);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 303);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 33;
            label10.Text = "Idioma";
            // 
            // txtAutorActualizar
            // 
            txtAutorActualizar.Location = new Point(138, 146);
            txtAutorActualizar.Name = "txtAutorActualizar";
            txtAutorActualizar.Size = new Size(100, 23);
            txtAutorActualizar.TabIndex = 23;
            // 
            // txtNumEjemplaresActualizar
            // 
            txtNumEjemplaresActualizar.Location = new Point(120, 353);
            txtNumEjemplaresActualizar.Name = "txtNumEjemplaresActualizar";
            txtNumEjemplaresActualizar.Size = new Size(100, 23);
            txtNumEjemplaresActualizar.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 249);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 32;
            label11.Text = "Fecha de Publicacion";
            // 
            // txtTituloActualizar
            // 
            txtTituloActualizar.Location = new Point(128, 91);
            txtTituloActualizar.Name = "txtTituloActualizar";
            txtTituloActualizar.Size = new Size(100, 23);
            txtTituloActualizar.TabIndex = 22;
            // 
            // dateTimeFechaActualizar
            // 
            dateTimeFechaActualizar.Location = new Point(130, 247);
            dateTimeFechaActualizar.Name = "dateTimeFechaActualizar";
            dateTimeFechaActualizar.Size = new Size(108, 23);
            dateTimeFechaActualizar.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 204);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 31;
            label12.Text = "Categoria";
            // 
            // txtIdLibroActualizar
            // 
            txtIdLibroActualizar.Location = new Point(128, 49);
            txtIdLibroActualizar.Name = "txtIdLibroActualizar";
            txtIdLibroActualizar.Size = new Size(100, 23);
            txtIdLibroActualizar.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 149);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 30;
            label13.Text = "Autor";
            // 
            // cbCategoriaActualizar
            // 
            cbCategoriaActualizar.FormattingEnabled = true;
            cbCategoriaActualizar.Location = new Point(128, 196);
            cbCategoriaActualizar.Name = "cbCategoriaActualizar";
            cbCategoriaActualizar.Size = new Size(121, 23);
            cbCategoriaActualizar.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 98);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 29;
            label14.Text = "Titulo Del Libro";
            // 
            // btnAbrirPanel
            // 
            btnAbrirPanel.Location = new Point(-1, -25);
            btnAbrirPanel.Name = "btnAbrirPanel";
            btnAbrirPanel.Size = new Size(75, 23);
            btnAbrirPanel.TabIndex = 8;
            btnAbrirPanel.Text = "button1";
            btnAbrirPanel.UseVisualStyleBackColor = true;
            btnAbrirPanel.Click += btnAbrirPanel_Click;
            // 
            // btnCerrarPanel
            // 
            btnCerrarPanel.FlatAppearance.BorderSize = 0;
            btnCerrarPanel.FlatStyle = FlatStyle.Flat;
            btnCerrarPanel.Image = (Image)resources.GetObject("btnCerrarPanel.Image");
            btnCerrarPanel.Location = new Point(-16, 3);
            btnCerrarPanel.Name = "btnCerrarPanel";
            btnCerrarPanel.Size = new Size(75, 31);
            btnCerrarPanel.TabIndex = 9;
            btnCerrarPanel.UseVisualStyleBackColor = true;
            btnCerrarPanel.Click += btnCerrarPanel_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(51, 254);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 10;
            // 
            // dataGridViewDatosLibros
            // 
            dataGridViewDatosLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatosLibros.Location = new Point(378, 291);
            dataGridViewDatosLibros.Name = "dataGridViewDatosLibros";
            dataGridViewDatosLibros.RowTemplate.Height = 25;
            dataGridViewDatosLibros.Size = new Size(452, 255);
            dataGridViewDatosLibros.TabIndex = 11;
            dataGridViewDatosLibros.CellContentClick += dataGridViewDatosLibros_CellContentClick;
            // 
            // btnAñadirLibro
            // 
            btnAñadirLibro.Location = new Point(78, 493);
            btnAñadirLibro.Name = "btnAñadirLibro";
            btnAñadirLibro.Size = new Size(75, 23);
            btnAñadirLibro.TabIndex = 12;
            btnAñadirLibro.Text = "Añadir";
            btnAñadirLibro.UseVisualStyleBackColor = true;
            btnAñadirLibro.Click += btnAñadirLibro_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(134, 92, 233);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(118, 61);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelRegistroLibros
            // 
            panelRegistroLibros.BackColor = Color.FromArgb(44, 44, 44);
            panelRegistroLibros.Controls.Add(label19);
            panelRegistroLibros.Controls.Add(label8);
            panelRegistroLibros.Controls.Add(label6);
            panelRegistroLibros.Controls.Add(label5);
            panelRegistroLibros.Controls.Add(label4);
            panelRegistroLibros.Controls.Add(label3);
            panelRegistroLibros.Controls.Add(btnCerrarPanel);
            panelRegistroLibros.Controls.Add(label2);
            panelRegistroLibros.Controls.Add(btnAbrirPanel);
            panelRegistroLibros.Controls.Add(label1);
            panelRegistroLibros.Controls.Add(btnAñadirLibro);
            panelRegistroLibros.Controls.Add(cbCategoria);
            panelRegistroLibros.Controls.Add(txtIdLibro);
            panelRegistroLibros.Controls.Add(txtTitulo);
            panelRegistroLibros.Controls.Add(txtAutor);
            panelRegistroLibros.Controls.Add(txtIdioma);
            panelRegistroLibros.Controls.Add(txtNumEjemplares);
            panelRegistroLibros.Controls.Add(dateTimeFecha);
            panelRegistroLibros.Dock = DockStyle.Right;
            panelRegistroLibros.Location = new Point(906, 0);
            panelRegistroLibros.Name = "panelRegistroLibros";
            panelRegistroLibros.Size = new Size(223, 603);
            panelRegistroLibros.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(41, 14);
            label19.Name = "label19";
            label19.Size = new Size(134, 25);
            label19.TabIndex = 29;
            label19.Text = "Registrar Libro";
            label19.Click += label19_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(71, 411);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 20;
            label8.Text = "N°Ejemplares";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(85, 352);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 18;
            label6.Text = "Idioma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(52, 291);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 17;
            label5.Text = "Fecha de Publicacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(81, 227);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 16;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(89, 165);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 15;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(66, 108);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 14;
            label2.Text = "Titulo Del Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(81, 57);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 13;
            label1.Text = "ID libro";
            // 
            // btnAbrirPanelAct
            // 
            btnAbrirPanelAct.BackColor = Color.Transparent;
            btnAbrirPanelAct.FlatAppearance.BorderSize = 0;
            btnAbrirPanelAct.FlatStyle = FlatStyle.Flat;
            btnAbrirPanelAct.Image = (Image)resources.GetObject("btnAbrirPanelAct.Image");
            btnAbrirPanelAct.Location = new Point(271, 565);
            btnAbrirPanelAct.Name = "btnAbrirPanelAct";
            btnAbrirPanelAct.Size = new Size(75, 36);
            btnAbrirPanelAct.TabIndex = 21;
            btnAbrirPanelAct.UseVisualStyleBackColor = false;
            btnAbrirPanelAct.Click += btnAbrirPanelAct_Click;
            // 
            // panelEliminar
            // 
            panelEliminar.Controls.Add(label16);
            panelEliminar.Controls.Add(txtLIbroIdEliminar);
            panelEliminar.Controls.Add(btnEliminar);
            panelEliminar.Location = new Point(41, 30);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(200, 100);
            panelEliminar.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(5, 31);
            label16.Name = "label16";
            label16.Size = new Size(61, 21);
            label16.TabIndex = 16;
            label16.Text = "ID libro";
            // 
            // txtLIbroIdEliminar
            // 
            txtLIbroIdEliminar.Location = new Point(71, 30);
            txtLIbroIdEliminar.Name = "txtLIbroIdEliminar";
            txtLIbroIdEliminar.Size = new Size(100, 23);
            txtLIbroIdEliminar.TabIndex = 15;
            // 
            // cbFiltroPrincipal
            // 
            cbFiltroPrincipal.FormattingEnabled = true;
            cbFiltroPrincipal.Location = new Point(563, 10);
            cbFiltroPrincipal.Name = "cbFiltroPrincipal";
            cbFiltroPrincipal.Size = new Size(69, 23);
            cbFiltroPrincipal.TabIndex = 23;
            cbFiltroPrincipal.SelectedIndexChanged += cbFiltroPrincipal_SelectedIndexChanged;
            // 
            // cbFiltroSecundario
            // 
            cbFiltroSecundario.FormattingEnabled = true;
            cbFiltroSecundario.Location = new Point(653, 8);
            cbFiltroSecundario.Name = "cbFiltroSecundario";
            cbFiltroSecundario.Size = new Size(82, 23);
            cbFiltroSecundario.TabIndex = 24;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.BackColor = Color.FromArgb(134, 92, 233);
            btnBuscarLibro.FlatAppearance.BorderSize = 0;
            btnBuscarLibro.FlatStyle = FlatStyle.Flat;
            btnBuscarLibro.ForeColor = Color.Snow;
            btnBuscarLibro.Location = new Point(755, 9);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(75, 23);
            btnBuscarLibro.TabIndex = 25;
            btnBuscarLibro.Text = "Buscar";
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // listResultados
            // 
            listResultados.FormattingEnabled = true;
            listResultados.ItemHeight = 15;
            listResultados.Location = new Point(336, 56);
            listResultados.Name = "listResultados";
            listResultados.Size = new Size(525, 229);
            listResultados.TabIndex = 26;
            listResultados.SelectedIndexChanged += listResultados_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(380, 14);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 27;
            label17.Text = "Busqueda ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(267, 549);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 28;
            label7.Text = "Actualizar Libro";
            // 
            // Formlibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(1129, 603);
            Controls.Add(label7);
            Controls.Add(label17);
            Controls.Add(listResultados);
            Controls.Add(btnBuscarLibro);
            Controls.Add(cbFiltroSecundario);
            Controls.Add(cbFiltroPrincipal);
            Controls.Add(panelEliminar);
            Controls.Add(btnAbrirPanelAct);
            Controls.Add(panelRegistroLibros);
            Controls.Add(dataGridViewDatosLibros);
            Controls.Add(panelActualizarLibros);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formlibros";
            Text = "Formlibros";
            Load += Formlibros_Load;
            panelActualizarLibros.ResumeLayout(false);
            panelActualizarLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatosLibros).EndInit();
            panelRegistroLibros.ResumeLayout(false);
            panelRegistroLibros.PerformLayout();
            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdLibro;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtIdioma;
        private TextBox txtNumEjemplares;
        private TextBox txtBuscar;
        private DateTimePicker dateTimeFecha;
        private Panel panelActualizarLibros;
        private Button btnAbrirPanel;
        private Button btnCerrarPanel;
        private ComboBox cbCategoria;
        private DataGridView dataGridViewDatosLibros;
        private Button btnAñadirLibro;
        private Button btnActualizar;
        private Button btnEliminar;
        private Panel panelRegistroLibros;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label15;
        private TextBox txtIdiomaActualizar;
        private Label label10;
        private TextBox txtAutorActualizar;
        private TextBox txtNumEjemplaresActualizar;
        private Label label11;
        private TextBox txtTituloActualizar;
        private DateTimePicker dateTimeFechaActualizar;
        private Label label12;
        private TextBox txtIdLibroActualizar;
        private Label label13;
        private ComboBox cbCategoriaActualizar;
        private Label label14;
        private Button btnCerrarPanelAct;
        private Button btnAbrirPanelAct;
        private Panel panelEliminar;
        private Label label16;
        private TextBox txtLIbroIdEliminar;
        private ComboBox cbFiltroPrincipal;
        private ComboBox cbFiltroSecundario;
        private Button btnBuscarLibro;
        private ListBox listResultados;
        private Label label17;
        private Label label18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label19;
        private Label label7;
    }
}