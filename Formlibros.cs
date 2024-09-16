using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.Formlibros;

namespace Biblioteca
{  //declaracion de la clase libro


    public partial class Formlibros : Form
    {

        public Formlibros()
        {
            InitializeComponent();
        }
        //Lista para almacenanamiento de los libros registrados


        List<Libro> listaLibros = new List<Libro>();




        private void Formlibros_Load(object sender, EventArgs e)
        {
            panelActualizarLibros.Visible = true;

            // colummnas del dataGrid

            dataGridViewDatosLibros.Columns.Add("IdLibro", "ID libro");
            dataGridViewDatosLibros.Columns.Add("Titulo", "Titulo");
            dataGridViewDatosLibros.Columns.Add("Autor", "Autor");
            dataGridViewDatosLibros.Columns.Add("Categoria", "Categoría");
            dataGridViewDatosLibros.Columns.Add("FechaPublicacion", "Fecha de Publicacion");
            dataGridViewDatosLibros.Columns.Add("Idioma", "Idioma");
            dataGridViewDatosLibros.Columns.Add("NumeroEjemplares", "Número de Ejemplares");

            // arreglo para almacenar las categorias
            string[] categorias = { "Ficcion", "Misterio", "Historia", "Biografia", "Terror", "Novela", " Otros" };
            cbCategoria.Items.AddRange(categorias);

            panelActualizarLibros.Visible = false;


            MuestraLibros(); //funcion para mostrar los libros
            MostrarLibros();
            CargarFiltros(); // carga los filtros de busqueda

        }

        //seccion libros 
        //metodos para loslibors

        //los libros predterminados en la dataGrid
        private void MuestraLibros()
        {
            listaLibros.Add(new Libro
            {
                IdLibro = "001",
                Titulo = "Cien años de soledad",
                Autor = "Gabriel Garcia Márquez",
                Categoria = "Novela",
                FechaPublicacion = new DateTime(1967, 6, 5),
                Idioma = "Español",
                NumeroEjemplares = 5
            });

            listaLibros.Add(new Libro
            {
                IdLibro = "002",
                Titulo = "Don Quijote de la Mancha",
                Autor = "Miguel de Cervantes",
                Categoria = "Novela",
                FechaPublicacion = new DateTime(1605, 1, 16),
                Idioma = "Español",
                NumeroEjemplares = 3
            });

            listaLibros.Add(new Libro
            {
                IdLibro = "001",
                Titulo = "El Alquimista",
                Autor = "Paulo Coelho",
                Categoria = "Ficcion",
                FechaPublicacion = new DateTime(1988, 5, 1),
                Idioma = "Portugues",
                NumeroEjemplares = 10
            });

        }
        

        // registro de los libros en la datagrid
        private void MostrarLibros()
        {
            dataGridViewDatosLibros.Rows.Clear();

            foreach (var libro in listaLibros)
            {
                int fila = dataGridViewDatosLibros.Rows.Add();
                dataGridViewDatosLibros.Rows[fila].Cells[0].Value = libro.IdLibro;
                dataGridViewDatosLibros.Rows[fila].Cells[1].Value = libro.Titulo;
                dataGridViewDatosLibros.Rows[fila].Cells[2].Value = libro.Autor;
                dataGridViewDatosLibros.Rows[fila].Cells[3].Value = libro.Categoria;
                dataGridViewDatosLibros.Rows[fila].Cells[4].Value = libro.FechaPublicacion.ToShortDateString();
                dataGridViewDatosLibros.Rows[fila].Cells[5].Value = libro.Idioma;
                dataGridViewDatosLibros.Rows[fila].Cells[6].Value = libro.NumeroEjemplares;
            }
        }




        // seccion validaciones de libros

        //campos obligatorios de registro 
        private bool ValidarLibros()
        {

            if (string.IsNullOrEmpty(txtIdLibro.Text))
            {
                MessageBox.Show("ID el libro obligatorio.", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Título del libro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Autor del libro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        //errores duplicaciones de libros

        private bool DuplicadosLibros()

        {
            string idLibro = txtIdLibro.Text;
            foreach (var Libro in listaLibros)
            {
                if (Libro.IdLibro == txtIdLibro.Text)
                {
                    MessageBox.Show("El ID del Libro ya existe. Ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnAñadirLibro_Click(object sender, EventArgs e)
        {
            // Validar datos del libro
            if (ValidarLibros() && DuplicadosLibros())
            {
                Libro nuevoLibro = new Libro
                {
                    IdLibro = txtIdLibro.Text,
                    Titulo = txtTitulo.Text,
                    Autor = txtAutor.Text,
                    Categoria = cbCategoria.SelectedItem?.ToString(),
                    FechaPublicacion = dateTimeFecha.Value,
                    Idioma = txtIdioma.Text,
                    NumeroEjemplares = int.Parse(txtNumEjemplares.Text),
                    Prestado = false // Por defecto, el libro no está prestado
                };

                // Agregar nuevo libro a la lista global
                GlobalData.Libros.Add(nuevoLibro);

                // Actualizar DataGridView
                MostrarLibros(); // este metodo usa GlobalData.Libros para llenar el DataGridView

                MessageBox.Show("Libro registrado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                LimpiarCampos();
            }
            else
            {
                // Mostrar mensaje de error si la validación falla
                MessageBox.Show("Por favor, revise los datos ingresados o el libro ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //metodo para limpiar los campos
        private void LimpiarCampos()
        {

            txtIdLibro.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtIdioma.Clear();
            txtNumEjemplares.Clear();
            cbCategoria.SelectedIndex = -1;
            dateTimeFecha.Value = DateTime.Today;
        }


        //botones de la aplicacion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDatosLibros.SelectedRows.Count > 0)
            {
                // Deshabilitar el campo ID para evitar modificaciones
                txtIdLibroActualizar.ReadOnly = true;

                // Obtener el ID del libro seleccionado
                string idLibroSeleccionado = dataGridViewDatosLibros.SelectedRows[0].Cells[0].Value.ToString();

                // Buscar el libro en la lista global
                Libro libroSeleccionado = GlobalData.Libros.FirstOrDefault(libro => libro.IdLibro == idLibroSeleccionado);

                if (libroSeleccionado != null)
                {
                    // Actualizar los detalles del libro
                    libroSeleccionado.Titulo = txtTituloActualizar.Text;
                    libroSeleccionado.Autor = txtAutorActualizar.Text;
                    libroSeleccionado.Categoria = cbCategoriaActualizar.SelectedItem?.ToString();
                    libroSeleccionado.FechaPublicacion = dateTimeFechaActualizar.Value;
                    libroSeleccionado.Idioma = txtIdiomaActualizar.Text;
                    libroSeleccionado.NumeroEjemplares = int.Parse(txtNumEjemplaresActualizar.Text);

                    // Actualizar el DataGridView
                    MostrarLibros();

                    MessageBox.Show("Libro actualizado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos 
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontro el libro con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningún libro para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void btnAbrirPanel_Click(object sender, EventArgs e)
        {
            panelRegistroLibros.Visible = true;
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            panelRegistroLibros.Visible = false;
        }

        private void dataGridViewDatosLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarPanelAct_Click(object sender, EventArgs e)
        {
            panelActualizarLibros.Visible = false;
        }

        private void btnAbrirPanelAct_Click(object sender, EventArgs e)
        {
            panelActualizarLibros.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idLibroEliminar = txtLIbroIdEliminar.Text;

            if (string.IsNullOrEmpty(idLibroEliminar))
            {
                MessageBox.Show("Ingrese un ID de libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libro libroAEliminar = GlobalData.Libros.FirstOrDefault(libro => libro.IdLibro == idLibroEliminar);

            if (libroAEliminar != null)
            {
                GlobalData.Libros.Remove(libroAEliminar);
                MostrarLibros();
                MessageBox.Show("Libro eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLIbroIdEliminar.Clear();
                panelEliminar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el libro con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //FILTROS DE BUSQUEDA
        private void CargarFiltros()
        {
            // opciones para el filtro principal
            cbFiltroPrincipal.Items.Clear();
            cbFiltroPrincipal.Items.AddRange(new string[] { "Vacio", "Categoria", "Autor" });
            cbFiltroPrincipal.SelectedIndex = 0; // Por defecto seleccionar "Vacio"
        }
        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {

            // Obtener la selección del filtro principal
            string filtroPrincipalSeleccionado = cbFiltroPrincipal.SelectedItem.ToString();
            string filtroSecundarioSeleccionado = cbFiltroSecundario.SelectedItem != null ? cbFiltroSecundario.SelectedItem.ToString() : string.Empty;

            List<Libro> librosFiltrados = new List<Libro>();

            // Si el filtro principal es "Vacio", realizar búsqueda general por el texto ingresado en txtBuscar
            if (filtroPrincipalSeleccionado == "Vacio")
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    MessageBox.Show("Debe ingresar un valor para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listResultados.Items.Clear(); // Limpiar la ListBox
                    return;
                }

                string busquedaGeneral = txtBuscar.Text.ToLower();
                librosFiltrados = listaLibros.Where(libro =>
                    libro.IdLibro.ToLower().Contains(busquedaGeneral) ||
                    libro.Titulo.ToLower().Contains(busquedaGeneral) ||
                    libro.Autor.ToLower().Contains(busquedaGeneral) ||
                    libro.Categoria.ToLower().Contains(busquedaGeneral)).ToList();
            }
            // Filtrar por Categoría
            else if (filtroPrincipalSeleccionado == "Categoria")
            {
                if (filtroSecundarioSeleccionado == "Vacio")
                {
                    listResultados.Items.Clear(); // Limpiar la ListBox
                    return;
                }

                if (filtroSecundarioSeleccionado == "Todas")
                {
                    librosFiltrados = listaLibros.ToList(); // Mostrar todos los libros
                }
                else
                {
                    librosFiltrados = listaLibros.Where(libro => libro.Categoria == filtroSecundarioSeleccionado).ToList();
                }
            }
            // Filtrar por Autor
            else if (filtroPrincipalSeleccionado == "Autor")
            {
                if (filtroSecundarioSeleccionado == "Vacio")
                {
                    listResultados.Items.Clear(); // Limpiar la ListBox
                    return;
                }

                if (filtroSecundarioSeleccionado == "Todos")
                {
                    librosFiltrados = listaLibros.ToList(); // Mostrar todos los libros
                }
                else
                {
                    librosFiltrados = listaLibros.Where(libro => libro.Autor == filtroSecundarioSeleccionado).ToList();
                }
            }

            // Limpiar el ListBox y mostrar los resultados
            listResultados.Items.Clear();
            foreach (var libro in librosFiltrados)
            {
                listResultados.Items.Add($"{libro.Titulo} - {libro.Autor}");
            }

            // Mostrar mensaje si no se encuentran libros
            if (librosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron libros que coincidan con los criterios de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void listResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listResultados.SelectedIndex == -1)
            {
                return;
            }

            string libroSeleccionado = listResultados.SelectedItem.ToString();
            string[] partes = libroSeleccionado.Split(new[] { " - " }, StringSplitOptions.None);
            string tituloSeleccionado = partes[0];

            var libro = listaLibros.FirstOrDefault(l => l.Titulo == tituloSeleccionado);

            if (libro != null)
            {
                dataGridViewDatosLibros.Rows.Clear();
                dataGridViewDatosLibros.Rows.Add(libro.IdLibro, libro.Titulo, libro.Autor, libro.Categoria, libro.FechaPublicacion.ToShortDateString(), libro.Idioma, libro.NumeroEjemplares);
            }
        }

        private void cbFiltroPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cbFiltroPrincipal.SelectedItem.ToString();

            // Limpiar el ComboBox secundario
            cbFiltroSecundario.Items.Clear();

            if (opcionSeleccionada == "Categoria")
            {
                // Cargar las categorías
                cbFiltroSecundario.Items.Add("Vacio");
                cbFiltroSecundario.Items.AddRange(new string[] { "Todas", "Ficcion", "Misterio", "Historia", "Biografia", "Terror", "Novela", "Otros" });
            }
            else if (opcionSeleccionada == "Autor")
            {
                // Obtener autores únicos
                var autores = listaLibros.Select(libro => libro.Autor).Distinct().ToList();
                cbFiltroSecundario.Items.Add("Vacio");
                cbFiltroSecundario.Items.Add("Todos");
                cbFiltroSecundario.Items.AddRange(autores.ToArray());
            }
            else
            {
                // Si se selecciona "Vacio", no cargar nada
                cbFiltroSecundario.Items.Add("Vacio");
            }

            cbFiltroSecundario.SelectedIndex = 0; // Seleccionar la primera opción por defecto
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
