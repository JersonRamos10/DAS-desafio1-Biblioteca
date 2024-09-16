using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static Biblioteca.Formlibros;
using static Biblioteca.FormUsuario;
using Datos;


namespace Biblioteca
{
    public partial class FormGestiones : Form
    {
        private List<Prestamo> prestamos = new List<Prestamo>();
        private List<Datos.Libro> libros = new List<Datos.Libro>();

        private Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();


        public FormGestiones()
        {
            InitializeComponent();



        }
        private void FormGestiones_Load(object sender, EventArgs e)
        {
            MostrarDatos(); //carga los libros
            MostrarUsuarios(); // Carga los usuarios
            CargarUsuarios();
            // Inicializar el panel y el botón para prestar libros
            panelRegistroPrestamo.Visible = false;
            btnPrestarLibro.Enabled = false;
            cbUsuarioId.DataSource = GlobalData.Usuarios.Select(u => u.IdUsuario).ToList();

        }

        //Funcion para cargar Usuarios
        private void CargarUsuarios()
        {
            cbUsuarioId.Items.Clear();

            // Verificar que GlobalData.Usuarios no sea nulo
            if (GlobalData.Usuarios == null || !GlobalData.Usuarios.Any())
            {
                MessageBox.Show("No se encontraron usuarios.");
                return;
            }

            // Llenar el ComboBox con los IDs de usuario
            foreach (var usuario in GlobalData.Usuarios)
            {
                cbUsuarioId.Items.Add(usuario.IdUsuario);
            }

            if (cbUsuarioId.Items.Count > 0)
            {
                cbUsuarioId.SelectedIndex = 0;
            }
        }

        // funcion para el historial de usuarios

        private DataGridView GetDgvHistorialUsuario()
        {
            return dgvHistorialUsuario;
        }

        //configuracion de columnas de las dataGrid
        private void ConfigurarColumnas(DataGridView dgvHistorialUsuario)
        {
            // Limpiar las columnas existentes
            dgvLibrosDisponibles.Columns.Clear();

            // Agregar columnas
            dgvLibrosDisponibles.Columns.Add("IdLibro", "ID Libro");
            dgvLibrosDisponibles.Columns.Add("Titulo", "Título");
            dgvLibrosDisponibles.Columns.Add("Autor", "Autor");
            dgvLibrosDisponibles.Columns.Add("Categoria", "Categoría");
            dgvLibrosDisponibles.Columns.Add("FechaPublicacion", "Fecha de Publicación");
            dgvLibrosDisponibles.Columns.Add("Idioma", "Idioma");
            dgvLibrosDisponibles.Columns.Add("NumeroEjemplares", "Número de Ejemplares");
            dgvLibrosDisponibles.Columns.Add("Estado", "Estado");


            dgvLibrosPrestados.Columns.Add("idLibro", "ID libro");
            dgvLibrosPrestados.Columns.Add("Titulo", "Título");
            dgvLibrosPrestados.Columns.Add("Autor", "Autor");
            dgvLibrosPrestados.Columns.Add("Categoria", "Categoría");
            dgvLibrosPrestados.Columns.Add("FechaPublicacion", "Fecha de Publicación");
            dgvLibrosPrestados.Columns.Add("Idioma", "Idioma");
            dgvLibrosPrestados.Columns.Add("NumeroEjemplares", "Número de Ejemplares");
            dgvLibrosPrestados.Columns.Add("Estado", "Estado");

            dgvUsuariosRegistrados.Columns.Clear();
            dgvUsuariosRegistrados.Columns.Add("IdUsuario", "ID Usuario");
            dgvUsuariosRegistrados.Columns.Add("Nombre", "Nombre");
            dgvUsuariosRegistrados.Columns.Add("Apellido", "Apellido");
            dgvUsuariosRegistrados.Columns.Add("Email", "Email");
            dgvUsuariosRegistrados.Columns.Add("Telefono", "Teléfono");
            dgvUsuariosRegistrados.Columns.Add("TipoUsuario", "Tipo de Usuario");
            dgvUsuariosRegistrados.Columns.Add("FechaRegistro", "Fecha de Registro");


        }
       
        // visualizcion de datos
        private void MostrarDatos()
        {


            ConfigurarColumnas(GetDgvHistorialUsuario());

            // Limpiar el DataGridView antes de llenarlo con nuevos datos
            dgvLibrosDisponibles.Rows.Clear();
            if (GlobalData.Libros == null || !GlobalData.Libros.Any())
            {
                MessageBox.Show("No hay libros registrados.");
                return;
            }

            // Filtra los libros para eliminar duplicados basados en ID
            var librosUnicos = GlobalData.Libros
                .GroupBy(libro => libro.IdLibro)
                .Select(grp => grp.First())
                .ToList();

            // llenado de libros registrados en la grid
            foreach (var libro in GlobalData.Libros)
            {
                int fila = dgvLibrosDisponibles.Rows.Add();
                dgvLibrosDisponibles.Rows[fila].Cells["IdLibro"].Value = libro.IdLibro;
                dgvLibrosDisponibles.Rows[fila].Cells["Titulo"].Value = libro.Titulo;
                dgvLibrosDisponibles.Rows[fila].Cells["Autor"].Value = libro.Autor;
                dgvLibrosDisponibles.Rows[fila].Cells["Categoria"].Value = libro.Categoria;
                dgvLibrosDisponibles.Rows[fila].Cells["FechaPublicacion"].Value = libro.FechaPublicacion.ToShortDateString();
                dgvLibrosDisponibles.Rows[fila].Cells["Idioma"].Value = libro.Idioma;
                dgvLibrosDisponibles.Rows[fila].Cells["NumeroEjemplares"].Value = libro.NumeroEjemplares;

            }


        }

        private void MostrarUsuarios()
        {
            dgvUsuariosRegistrados.Rows.Clear();

            if (GlobalData.Usuarios == null || !GlobalData.Usuarios.Any())
            {
                MessageBox.Show("No hay usuarios registrados.");
                return;
            }

            // Llenado de usuarios registrados en el DataGridView
            foreach (var usuario in GlobalData.Usuarios)
            {
                int fila = dgvUsuariosRegistrados.Rows.Add();
                dgvUsuariosRegistrados.Rows[fila].Cells["IdUsuario"].Value = usuario.IdUsuario;
                dgvUsuariosRegistrados.Rows[fila].Cells["Nombre"].Value = usuario.Nombre;
                dgvUsuariosRegistrados.Rows[fila].Cells["Apellido"].Value = usuario.Apellido;
                dgvUsuariosRegistrados.Rows[fila].Cells["Email"].Value = usuario.Email;
                dgvUsuariosRegistrados.Rows[fila].Cells["Telefono"].Value = usuario.Telefono;
                dgvUsuariosRegistrados.Rows[fila].Cells["TipoUsuario"].Value = usuario.TipoUsuario;
                dgvUsuariosRegistrados.Rows[fila].Cells["FechaRegistro"].Value = usuario.FechaRegistro.ToShortDateString();
            }
        }
       
        // botones 
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (lstLibrosEncontrados.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un libro de la lista.");
                return;
            }

            if (cbUsuarioId.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para el préstamo.");
                return;
            }

            string idLibro = lstLibrosEncontrados.SelectedItem.ToString();
            string idUsuario = cbUsuarioId.SelectedItem.ToString();

            if (string.IsNullOrEmpty(idLibro) || string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Por favor, seleccione un libro y un usuario.");
                return;
            }

            // Agregar préstamo a la lista
            GlobalData.Prestamos.Add(new Prestamo
            {
                IdUsuario = idUsuario,
                IdLibro = idLibro,
                Titulo = "Título del libro",  // obtener el ttulo real del libro
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = DateTime.Now.AddDays(15)
            });

            MessageBox.Show("Prestamo registrado con éxito.");

            // Ocultar panel después de registrar el préstamo
            panelRegistroPrestamo.Visible = false;

            // Verificar los datos en GlobalData.Prestamos
            string prestamosInfo = string.Join("\n", GlobalData.Prestamos.Select(p => $"{p.IdUsuario} - {p.IdLibro}"));
            MessageBox.Show($"Prestamos registrados:\n{prestamosInfo}");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbUsuarioId.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para filtrar.");
                return;
            }

            string idUsuarioSeleccionado = cbUsuarioId.SelectedItem.ToString();
            FiltrarHistorial(idUsuarioSeleccionado);
        }

        // metodo de filtros
        private void FiltrarHistorial(string idUsuario)
        {
            dgvHistorialUsuario.Rows.Clear();

            if (GlobalData.Prestamos == null || !GlobalData.Prestamos.Any())
            {
                MessageBox.Show("No hay registros de prestamos.");
                return;
            }

            var prestamosUsuario = GlobalData.Prestamos
                .Where(p => p.IdUsuario == idUsuario)
                .ToList();

            if (!prestamosUsuario.Any())
            {
                MessageBox.Show("No se encontraron prestamos para el usuario seleccionado.");
                return;
            }

            foreach (var prestamo in prestamosUsuario)
            {
                int fila = dgvHistorialUsuario.Rows.Add();
                dgvHistorialUsuario.Rows[fila].Cells["IdLibro"].Value = prestamo.IdLibro;
                dgvHistorialUsuario.Rows[fila].Cells["Titulo"].Value = prestamo.Titulo;
                dgvHistorialUsuario.Rows[fila].Cells["FechaPrestamo"].Value = prestamo.FechaPrestamo.ToShortDateString();
                dgvHistorialUsuario.Rows[fila].Cells["FechaDevolucion"].Value = prestamo.FechaDevolucion.ToShortDateString() ?? "Pendiente";
            }
        }

        private void btnConfirmarPrestamo_Click(object sender, EventArgs e)
        {
            string idLibro = txtLibroIdPrestamo.Text.Trim();
            string idUsuario = txtUsuarioId.Text.Trim();
            string nombreUsuario = txtNombreUsuario.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(idLibro) || string.IsNullOrEmpty(idUsuario) || string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (ID del libro, ID del usuario, y nombre).");
                return;
            }

            bool libroEncontrado = false;

            // Search for the book in dgvLibrosDisponibles
            foreach (DataGridViewRow row in dgvLibrosDisponibles.Rows)
            {
                if (row.Cells["IdLibro"].Value != null && row.Cells["IdLibro"].Value.ToString() == idLibro)
                {
                    int numeroEjemplares = Convert.ToInt32(row.Cells["NumeroEjemplares"].Value);

                    // Check if the book has available copies
                    if (numeroEjemplares > 0)
                    {
                        libroEncontrado = true;

                        // Register the loan in dgvLibrosPrestados
                        dgvLibrosPrestados.Rows.Add(idLibro, row.Cells["Titulo"].Value.ToString(), idUsuario, nombreUsuario, DateTime.Now.ToShortDateString(), dateTimeFechaDevolucion.Value.ToShortDateString());

                        // Reduce the number of copies available
                        row.Cells["NumeroEjemplares"].Value = numeroEjemplares - 1;

                        MessageBox.Show("Prestamo registrado con éxito.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("No hay mas ejemplares disponibles para este libro.");
                        return;
                    }
                }
            }

            if (!libroEncontrado)
            {
                MessageBox.Show("ID del libro no encontrada.");
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {

            string idLibro = txtBuscarPorId.Text.Trim();

            if (string.IsNullOrEmpty(idLibro))
            {
                MessageBox.Show("Por favor, ingrese la ID del libro.");
                return;
            }

            bool libroEncontrado = false;

            foreach (DataGridViewRow row in dgvLibrosDisponibles.Rows)
            {
                if (row.Cells["IdLibro"].Value != null && row.Cells["IdLibro"].Value.ToString() == idLibro)
                {
                    libroEncontrado = true;
                    lstLibrosEncontrados.Items.Clear();
                    lstLibrosEncontrados.Items.Add("Libro encontrado: " + row.Cells["Titulo"].Value.ToString());
                    btnPrestarLibro.Enabled = true; // Habilitar el botón de préstamo
                    MessageBox.Show("Libro encontrado.");
                    break;
                }
            }

            if (!libroEncontrado)
            {
                MessageBox.Show("ID del libro no encontrada.");
            }
        }

        // boton para realizar prestamo
        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            if (lstLibrosEncontrados.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un libro de la lista.");
                return;
            }

            // Mostrar el panel de prestamo
            panelRegistroPrestamo.Visible = true;
        }



        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {

            panelRegistroPrestamo.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestarLibro_Click_1(object sender, EventArgs e)
        {
            if (lstLibrosEncontrados.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un libro de la lista.");
                return;
            }

            // Mostrar el panel de solicitud de préstamo
            panelRegistroPrestamo.Visible = true;
        }

        private void btnPrestarLibro_Click_2(object sender, EventArgs e)
        {

        }
      
        private void btnCancelarPrestamo_Click_1(object sender, EventArgs e)
        {
            panelRegistroPrestamo.Visible = false;
            txtLibroIdPrestamo.Clear();
            txtUsuarioId.Clear();
            txtNombreUsuario.Clear();
            MessageBox.Show("El prestamo ha sido cancelado.");
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string idLibro = txtIdLibroDevolucion.Text.Trim();
            string idUsuario = txtIdUsuarioDevolucion.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(idLibro))
            {
                MessageBox.Show("Por favor, ingrese la ID del libro.");
                return;
            }

            if (string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Por favor, ingrese la ID del usuario.");
                return;
            }

            // Buscar el préstamo
            var prestamo = GlobalData.Prestamos
                .FirstOrDefault(p => p.IdLibro == idLibro && p.IdUsuario == idUsuario);

            if (prestamo == null)
            {
                MessageBox.Show("No se encontro un prestamo para el libro y usuario seleccionados.");
                return;
            }

            // Actualizar el libro
            var libro = GlobalData.Libros.FirstOrDefault(l => l.IdLibro == idLibro);
            if (libro != null)
            {
                libro.Prestado = false; // Marcar el libro como disponible
            }

            // Eliminar el préstamo
            GlobalData.Prestamos.Remove(prestamo);

            // Actualizar el DataGridView
            LoadLibros();

            // Mensaje de éxito
            MessageBox.Show("Devolucion realizada con exito.");
        }
        // Método para cargar los usuarios en el ComboBox
       

        // Método para cargar los libros en el DataGridView
        private void LoadLibros()
        {
            dgvLibrosDisponibles.DataSource = null;
            dgvLibrosDisponibles.DataSource = GlobalData.Libros
                .Where(l => !l.Prestado) // Filtrar libros disponibles
                .ToList();
        }

        private void btnAbrirPanelDevolucion_Click(object sender, EventArgs e)
        {
            panelDevolver.Visible = true;
        }

        private void btnCerrarPanelDevolucion_Click(object sender, EventArgs e)
        {
            panelDevolver.Visible = false;
        }
    }
}

