using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class Conexion
    {
        static string ConexionString = "server=localhost; port=3306; user id=root; password=hola1234; database=proyecto_final;";
        MySqlConnection conexion = new MySqlConnection(ConexionString);
        public MySqlConnection AbrirConexion()
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public void CerrarConexion()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            if (conexion.State == ConnectionState.Open) 
                conexion.Close();
        }
        
    }
}
