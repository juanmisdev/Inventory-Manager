using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class AdministrarProductos : Form
    {
        // Variables estaticas. Acceso a la clase conexion para obtener los datos de MySQL
        private static Conexion conexion = new Conexion(); //private para encapsular el objeto de tipo conexion.
        static MySqlDataReader leer;
        static MySqlCommand comando = new MySqlCommand();
        DataTable tabla_accesorios = new DataTable();
        DataTable tabla_productos = new DataTable();
        bool editar = false;
        List<Accesorio> accesorios = new List<Accesorio>();
        string id_producto;
        void Limpiar()
        {
            // reiniciar todos los valores de los textboxes
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
        public AdministrarProductos()
        {
            InitializeComponent();
        }

        public void AdministrarProductos_Load(object sender, EventArgs e)
        {

            tabla_accesorios = Accesorio.Mostrar(tabla_accesorios);
            dataGridView2.DataSource = tabla_accesorios;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.MultiSelect = true;

            tabla_productos = Producto.Mostrar(tabla_productos);
            dataGridView1.DataSource = tabla_productos;
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.Columns[5].Width = 200;
            dataGridView2.Columns[5].Width = 200;
        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (editar)
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;
                string stock = txtStock.Text;
                Producto.EditarProducto(nombre, descripcion, precio, stock, id_producto);
                MessageBox.Show("Se edito correctamente el producto");
                Limpiar();
                editar = false;
                btnInsert.Text = "Agregar";
                tabla_productos = Producto.Mostrar(tabla_productos);
            }
            else
            {
                try
                {
                    accesorios.Clear();
                    string nombre = txtNombre.Text;
                    string descripcion = txtDescripcion.Text;
                    string precio = txtPrecio.Text;
                    string stock = txtStock.Text;
                    Producto.InsertarProducto(nombre, descripcion, precio, stock);
                    Producto.Mostrar(tabla_productos);
                    MessageBox.Show($"Para agregar los accesorios que desea para el producto: {nombre} seleccionelo y posteriormente seleccione los accesorios y haga click en agregar accesorios (Puede seleccionar varios accesorios mantiendo la tecla control).");
                    Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Ver todos los accesorios
        private void button1_Click(object sender, EventArgs e)
        {
            tabla_accesorios = Accesorio.Mostrar(tabla_accesorios);
            dataGridView2.DataSource = tabla_accesorios;
        }

        //Ver accesorios del producto
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Si hay filas seleccionadas
            {
                string id_producto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                DataTable datos_accesorios = new DataTable();
                datos_accesorios = Producto.ObtenerAccesorios(id_producto, datos_accesorios);
                dataGridView2.DataSource = datos_accesorios;
                dataGridView2.Columns[5].Width = 200;
            }
            else
            {
                MessageBox.Show("Seleccione el producto que desea visualizar haciendo click en el lado izquierdo de este");
            }
        }

        private void btnAgregarAccesorios_Click(object sender, EventArgs e)
        {
            string cantidad_accesorios = lblCantidad.Text;
            try
            {
                if (dataGridView2.SelectedRows.Count > 0) // Si hay filas seleccionadas en accesorio
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        string id_producto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                        List<string> accesorios = new List<string>();
                        foreach (DataGridViewRow fila in dataGridView2.Rows)
                        {
                            // Verifica si la fila está seleccionada
                            if (fila.Selected)
                            {
                                // Accede al valor de la columna 'id' en la fila y agrégalo a la lista
                                string id = fila.Cells["id"].Value.ToString();
                                accesorios.Add(id);
                            }
                        }
                        Producto.InsertarTablaIntermedia(id_producto, accesorios, cantidad_accesorios);
                        MessageBox.Show("Se agrego correctamente el accesorio al producto");
                    }
                    else
                    {
                        MessageBox.Show("Seleccione al menos un producto para agregar accesorios.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione al menos un accesorio para su producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id_producto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                Producto.EliminarProducto(id_producto);
                tabla_productos = Producto.Mostrar(tabla_productos);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar haciendo click en la parte izquierda.");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Si hay filas seleccionadas
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                id_producto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                editar = true;
                btnInsert.Text = "Editar";
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar haciendo click en el lado izquierda de esta");
            }
        }

        //No permitir texto en el precio
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        // No permitir texto en el stock
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        private void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            //Aumentar cantidad.
            string cantidad_actual = lblCantidad.Text;
            string nueva_cantidad = (Convert.ToInt32(cantidad_actual) + 1).ToString();
            lblCantidad.Text = nueva_cantidad;
        }

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblCantidad.Text) > 1)
            {
                string cantidad_actual = lblCantidad.Text;
                string nueva_cantidad = (Convert.ToInt32(cantidad_actual) - 1).ToString();
                lblCantidad.Text = nueva_cantidad;
            }
        }
    }
}
