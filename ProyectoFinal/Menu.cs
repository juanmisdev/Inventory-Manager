using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Text.Encodings;
namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AdministrarAccesorios newForm = new AdministrarAccesorios();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdministrarProductos newForm = new AdministrarProductos();
            newForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NuevoProyecto newForm = new NuevoProyecto();
            newForm.Show();
        }
    }
}