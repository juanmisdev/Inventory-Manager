using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class AdministrarAccesorios : Form
    {
        Conexion conexion = new Conexion();
        string id_accesorio = "";
        bool editar = false;
        DataTable tabla = new DataTable();
        //Funcion para limpiar formulario:
        void Limpiar()
        {
            // reiniciar todos los valores de los textboxes
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
        public AdministrarAccesorios()
        {
            InitializeComponent();
        }

        private void btnAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ProductoAccesorio_Load(object sender, EventArgs e)
        {
            
            tabla = Accesorio.Mostrar(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[5].Width = 200;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    string nombre = txtNombre.Text;
                    string descripcion = txtDescripcion.Text;
                    string precio = txtPrecio.Text;
                    string stock = txtStock.Text;
                    Accesorio.EditarAccesorio(nombre, descripcion, precio, stock, id_accesorio);
                    MessageBox.Show("Se edito correctamente el accesorio");
                    editar = false;
                    btnInsert.Text = "Agregar";
                    Accesorio.Mostrar(tabla);
                    // reiniciar todos los valores de los textboxes
                    Limpiar();
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string descripcion = txtDescripcion.Text;
                    string precio = txtPrecio.Text;
                    string stock = txtStock.Text;
                    Accesorio.InsertarAccesorio(nombre, descripcion, precio, stock);
                    MessageBox.Show("Se agrego correctamente el accesorio");
                    Accesorio.Mostrar(tabla);
                    // reiniciar todos los valores de los textboxes
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Si hay filas seleccionadas
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                id_accesorio = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                editar = true;
                btnInsert.Text = "Editar";
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar haciendo click en el lado izquierda de esta");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int indice_seleccionado = dataGridView1.SelectedRows[0].Index;
                    id_accesorio = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    Accesorio.EliminarAccesorio(id_accesorio);
                    dataGridView1.Rows.RemoveAt(indice_seleccionado);
                    MessageBox.Show("Se ha eliminado el accesorio. Vuelva a abrir el programa para ver los cambios");
                    Accesorio.Mostrar(tabla);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar haciendo click en el lado izquierda de esta");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }
    }
}
