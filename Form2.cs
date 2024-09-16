using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.FormGestiones;
using static Biblioteca.Formlibros;
using static Biblioteca.FormUsuario;

namespace Biblioteca
{
    public partial class PagePrincipalBiblio : Form
    {
        public PagePrincipalBiblio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            if (sidebar.Width == 250)
            {
                sidebar.Width = 70;
            }
            else
            {
                sidebar.Width = 250;
            }

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirPanel(object Formhijo)
        {
            // Cerrar el formulario actual en el panel si existe
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formh = Formhijo as Form;
            formh.TopLevel = false;
            formh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formh);
            this.panelContenedor.Tag = formh;
            formh.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirPanel(new Formlibros());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FormUsuario());
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {


            // Abrir el formulario en el panel
            AbrirPanel(new FormGestiones());
        }

        private void btnVerGraficos_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FormGraficos());
        }
    }
}
