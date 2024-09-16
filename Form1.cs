namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // progress bar con panel
            
            int porcentajePanel = (panel2.Width * 100) / 320;         
            panel2.Width += 5; 
            label2.Text = porcentajePanel.ToString() + "%";

            if (panel2.Width >= 320)
            {
                label2.Text = label2.ToString()+ "%";
     
                timer1.Stop();
                this.Hide();

                //abrir el formulario principal Biblioteca
                PagePrincipalBiblio pagePrincipal = new PagePrincipalBiblio();
                pagePrincipal.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
