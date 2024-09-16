using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Biblioteca
{

    public partial class FormUsuario : Form
    {


        public FormUsuario()
        {
            InitializeComponent();


        }
       


        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            dataGridViewUsuarios.Columns.Add("IdUsuario", "ID Usuario");
            dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
            dataGridViewUsuarios.Columns.Add("Apellido", "Apellido");
            dataGridViewUsuarios.Columns.Add("Email", "Correo Electrónico");
            dataGridViewUsuarios.Columns.Add("Telefono", "Teléfono");
            dataGridViewUsuarios.Columns.Add("TipoUsuario", "Tipo de Usuario");
            dataGridViewUsuarios.Columns.Add("FechaRegistro", "Fecha de Registro");

            // Cargar datos del GlobalData en el DataGridView
            foreach (var usuario in GlobalData.Usuarios)
            {
                int fila = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[fila].Cells[0].Value = usuario.IdUsuario;
                dataGridViewUsuarios.Rows[fila].Cells[1].Value = usuario.Nombre;
                dataGridViewUsuarios.Rows[fila].Cells[2].Value = usuario.Apellido;
                dataGridViewUsuarios.Rows[fila].Cells[3].Value = usuario.Email;
                dataGridViewUsuarios.Rows[fila].Cells[4].Value = usuario.Telefono;
                dataGridViewUsuarios.Rows[fila].Cells[5].Value = usuario.TipoUsuario;
                dataGridViewUsuarios.Rows[fila].Cells[6].Value = usuario.FechaRegistro.ToShortDateString();
            }

            // Configuración del ComboBox
            string[] tiposUsuarios = { "Administrador", "Usuario Regular", "Invitado" };
            cbTipoUsuario.Items.AddRange(tiposUsuarios);

            txtIdUsuarioActualizar.ReadOnly = true;
            chkCambiarId.Checked = false;
        }



        //Diccionario para almacenar los datos de los usuarios 
        Dictionary<string, Usuario> diccionarioUsuarios = new Dictionary<string, Usuario>();

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {

            //evalua las validaciones para realizar el proceso de registro
            if (ValidacionDeCampos() && DuplicacionUsuario())
            {

                // proceso para registrar usuario
                Usuario nuevoUsuario = new Usuario
                {
                    IdUsuario = txtIdUsuario.Text,
                    Nombre = txtNombreUsuario.Text,
                    Apellido = txtApellidoUsuario.Text,
                    Email = txtEmailUsuario.Text,
                    Telefono = txtTelefonoUsuario.Text,
                    TipoUsuario = cbTipoUsuario.SelectedItem?.ToString(),
                    FechaRegistro = dateTimeFechaRegistro.Value
                };


                // Añadir el nuevo usuario al GlobalData
                // Añadir el nuevo usuario al GlobalData y al diccionario
                GlobalData.Usuarios.Add(nuevoUsuario);
                diccionarioUsuarios[nuevoUsuario.IdUsuario] = nuevoUsuario;

                // Actualiza el DataGridView
                int fila = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[fila].Cells[0].Value = nuevoUsuario.IdUsuario;
                dataGridViewUsuarios.Rows[fila].Cells[1].Value = nuevoUsuario.Nombre;
                dataGridViewUsuarios.Rows[fila].Cells[2].Value = nuevoUsuario.Apellido;
                dataGridViewUsuarios.Rows[fila].Cells[3].Value = nuevoUsuario.Email;
                dataGridViewUsuarios.Rows[fila].Cells[4].Value = nuevoUsuario.Telefono;
                dataGridViewUsuarios.Rows[fila].Cells[5].Value = nuevoUsuario.TipoUsuario;
                dataGridViewUsuarios.Rows[fila].Cells[6].Value = nuevoUsuario.FechaRegistro.ToShortDateString();

                

                MessageBox.Show("Usuario registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                //funcion que limpia los campos
                clearCampos();
            }
        }

        

        // validaciones para el registrio

        private bool ValidacionDeCampos()
        {

            //verificaciones para campos obligatorios

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                MessageBox.Show("ID de usuario es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((string.IsNullOrWhiteSpace(txtNombreUsuario.Text)) && (string.IsNullOrWhiteSpace(txtApellidoUsuario.Text)))
            {
                MessageBox.Show("Nombre y Apellido de usuario es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefonoUsuario.Text))
            {
                MessageBox.Show("Telefono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbTipoUsuario.SelectedIndex == -1) // Si no hay ningún elemento seleccionado
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
       
        private bool DuplicacionUsuario()
        {
            string idUsuario = txtIdUsuario.Text;
            if (diccionarioUsuarios.ContainsKey(idUsuario))
            {
                MessageBox.Show("El ID de Usuario ya existe. Ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (DataGridViewRow row in dataGridViewUsuarios.Rows)
            {
                if (!row.IsNewRow && row.Cells[1].Value?.ToString() == txtNombreUsuario.Text && row.Cells[2].Value?.ToString() == txtApellidoUsuario.Text)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre y apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }


        //Seccion Actualizar datos 
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelActualizar.Visible = true;


                txtIdUsuarioActualizar.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreActualizar.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtApellidoActualizar.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmailActualizar.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefonoActualizar.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimeRegistroActualizar.Value = DateTime.Parse(dataGridViewUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString());

            }

        }
        private void btnActaulizarUsuario_Click(object sender, EventArgs e)
        {
            // Verifica que haya alguna fila seleccionada
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                bool cambiarId = chkCambiarId.Checked;
                string nuevoIdUsuario = txtIdUsuarioActualizar.Text;

                foreach (DataGridViewRow row in dataGridViewUsuarios.SelectedRows)
                {
                    var cellValue = row.Cells[0].Value;
                    if (cellValue == null)
                    {
                        MessageBox.Show("El ID del usuario antiguo es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string idUsuarioAntiguo = cellValue.ToString();

                    if (cambiarId)
                    {
                        if (string.IsNullOrWhiteSpace(nuevoIdUsuario))
                        {
                            MessageBox.Show("El nuevo ID de usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (diccionarioUsuarios.ContainsKey(nuevoIdUsuario))
                        {
                            MessageBox.Show("El nuevo ID de usuario ya existe. Ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        diccionarioUsuarios.Remove(idUsuarioAntiguo);
                        diccionarioUsuarios[nuevoIdUsuario] = new Usuario
                        {
                            IdUsuario = nuevoIdUsuario,
                            Nombre = txtNombreActualizar.Text,
                            Apellido = txtApellidoActualizar.Text,
                            Email = txtEmailActualizar.Text,
                            Telefono = txtTelefonoActualizar.Text,
                            FechaRegistro = dateTimeRegistroActualizar.Value
                        };

                        row.Cells[0].Value = nuevoIdUsuario;
                    }
                    else
                    {
                        if (idUsuarioAntiguo != nuevoIdUsuario && diccionarioUsuarios.ContainsKey(nuevoIdUsuario))
                        {
                            MessageBox.Show("El nuevo ID de usuario ya existe. Ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        diccionarioUsuarios[idUsuarioAntiguo] = new Usuario
                        {
                            IdUsuario = idUsuarioAntiguo,
                            Nombre = txtNombreActualizar.Text,
                            Apellido = txtApellidoActualizar.Text,
                            Email = txtEmailActualizar.Text,
                            Telefono = txtTelefonoActualizar.Text,
                            FechaRegistro = dateTimeRegistroActualizar.Value
                        };

                        row.Cells[0].Value = idUsuarioAntiguo;
                    }

                    row.Cells[1].Value = txtNombreActualizar.Text;
                    row.Cells[2].Value = txtApellidoActualizar.Text;
                    row.Cells[3].Value = txtEmailActualizar.Text;
                    row.Cells[4].Value = txtTelefonoActualizar.Text;
                    row.Cells[6].Value = dateTimeRegistroActualizar.Value.ToShortDateString();
                }

                MessageBox.Show("Usuarios actualizados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearCampos();
                panelActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCambiarId_CheckedChanged(object sender, EventArgs e)
        {
            // Desbloquear o bloquear el TextBox según el estado del CheckBox
            txtIdUsuarioActualizar.ReadOnly = !chkCambiarId.Checked;

            // Si el CheckBox está desmarcado, restablece el TextBox a su valor original
            if (!chkCambiarId.Checked)
            {
                txtIdUsuarioActualizar.Text = dataGridViewUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //funcion para limpiar los campos 
        private void clearCampos()
        {
            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtApellidoUsuario.Clear();
            txtTelefonoUsuario.Clear();
            txtEmailUsuario.Clear();
            cbTipoUsuario.SelectedIndex = -1;
            dateTimeFechaRegistro.Value = DateTime.Today;
            // chkCambiarId.Checked = false;
            // txtIdUsuarioActualizar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrirPanelEliminar_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = true;
        }

        private void btnCerrarPanelEliminar_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = false;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string idUsuario = txtIdEliminar.Text.Trim();

            if (string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Ingrese un ID de usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el usuario en GlobalData.Usuarios
            var usuarioParaEliminar = GlobalData.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuarioParaEliminar != null)
            {
                // Eliminar del GlobalData
                GlobalData.Usuarios.Remove(usuarioParaEliminar);

                // Eliminar del diccionario
                diccionarioUsuarios.Remove(idUsuario);

                // Eliminar del DataGridView
                foreach (DataGridViewRow row in dataGridViewUsuarios.Rows)
                {
                    if (!row.IsNewRow && string.Equals(row.Cells[0].Value.ToString(), idUsuario, StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridViewUsuarios.Rows.Remove(row);
                        break;
                    }
                }

                MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdEliminar.Clear();
                panelEliminar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelEliminar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
