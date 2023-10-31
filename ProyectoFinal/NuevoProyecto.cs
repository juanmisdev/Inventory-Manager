using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class NuevoProyecto : Form
    {
        DataTable tabla_productos = new DataTable();
        DataTable tabla_proyecto = new DataTable();
        public NuevoProyecto()
        {
            InitializeComponent();
        }

        public void NuevoProyecto_Load(object sender, EventArgs e)
        {
            Producto.Mostrar(tabla_productos);
            dataGridView1.DataSource = tabla_productos;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 200;

            tabla_proyecto.Columns.Add("cantidad", typeof(int));
            tabla_proyecto.Columns.Add("id", typeof(int));
            tabla_proyecto.Columns.Add("nombre", typeof(string));
            tabla_proyecto.Columns.Add("descripcion", typeof(string));
            tabla_proyecto.Columns.Add("precio", typeof(decimal));
            tabla_proyecto.Columns.Add("stock", typeof(int));

            dataGridView2.DataSource = tabla_proyecto;
            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 50;
            dataGridView2.Columns[5].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aumentar cantidad.
            string cantidad_actual = lblCantidad.Text;
            string nueva_cantidad = (Convert.ToInt32(cantidad_actual) + 1).ToString();
            lblCantidad.Text = nueva_cantidad;
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Disminuir cantidad
            if (Convert.ToInt32(lblCantidad.Text) > 1)
            {
                string cantidad_actual = lblCantidad.Text;
                string nueva_cantidad = (Convert.ToInt32(cantidad_actual) - 1).ToString();
                lblCantidad.Text = nueva_cantidad;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Si hay filas seleccionadas
            {
                string cantidad = lblCantidad.Text;
                string nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                string descripcion = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                string precio = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                string stock = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();


                tabla_proyecto.Rows.Add(cantidad, id, nombre, descripcion, precio, stock);
            }
            else
            {
                MessageBox.Show("Seleccione al menos un producto para agregar al proyecto");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelConexion.ExportDataTableToExcel(tabla_proyecto);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
