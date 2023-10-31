using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Producto
    {
        // Variables estaticas. Acceso a la clase conexion para obtener los datos de MySQL
        private static Conexion conexion = new Conexion(); //private para encapsular el objeto de tipo conexion.
        static MySqlDataReader leer;
        static MySqlCommand comando = new MySqlCommand();
        static DataTable tabla = new DataTable();

        // Campos (variables de instancia)
        private string id_producto;
        private string nombre;
        private string descripcion;
        private string precio;
        private string stock;
        private DateTime last_update;
        private List<Accesorio> accesorios; // lista de tipo accesorio

        // Constructor con parámetros
        public Producto(string nombre, string descripcion, string precio, string stock, List<Accesorio> accesorios)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.last_update = DateTime.Now;
            this.accesorios = accesorios;
        }

        // Funcion para mostrar todos los accesorios (estatico para que no hay necesidad de tener un objeto instanciado):
        public static DataTable Mostrar(DataTable tabla)
        {
            tabla.Clear();
            // usando query:
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT id, nombre, descripcion, precio, stock, last_update AS ultima_modificacion FROM producto;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            leer.Close();
            return tabla;
        }

        public static DataTable ObtenerAccesorios(string id_producto, DataTable tabla)
        {
            tabla.Clear();
            string query = $"SELECT A.id, A.nombre, A.descripcion, A.precio, A.stock, PA.cantidad_accesorios FROM Producto AS P JOIN Producto_Accesorio AS PA ON P.id = PA.id_producto JOIN Accesorio AS A ON PA.id_accesorio = A.id WHERE P.id = {id_producto};";
            // Este query devuelve una tabla con los accesorios del producto
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = query;
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            leer.Close();
            return tabla;
        }


        // TOmar desde aqui.
        // Funcion insert:
        public static void InsertarProducto(string nombre, string descripcion, string precio, string stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"INSERT INTO producto (nombre, descripcion, precio, stock) VALUES ('{nombre}', '{descripcion}', '{precio}', '{stock}');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        // Funcion Delete:
        public static void EliminarProducto(string id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"DELETE FROM producto_accesorio WHERE id_producto = {id};" +
                $"DELETE FROM producto WHERE id = {id};";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Funcion Update:
        public static void EditarProducto(string nombre, string descripcion, string precio, string stock, string id)
        {
            Accesorio accesorio = new Accesorio(nombre, descripcion, precio, stock);
            accesorio.id = id;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"UPDATE producto SET nombre = '{accesorio.nombre}', descripcion = '{accesorio.descripcion}', precio = {accesorio.precio}, stock = {accesorio.stock}, last_update = CURDATE() WHERE id = {accesorio.id};";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Funcion para insertar en la tabla intermedia:
        public static void InsertarTablaIntermedia(string id_producto, List<string> lista_accesorios, string cantidad_accesorios)
        {
            comando.Connection = conexion.AbrirConexion();
            foreach(string id_accesorio in lista_accesorios) 
            {
                comando.CommandText = $"INSERT INTO producto_accesorio (id_accesorio, id_producto, cantidad_accesorios) VALUES ({id_accesorio}, {id_producto}, {cantidad_accesorios});";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            
            conexion.CerrarConexion();
        }
        public static string HallarUltimoDato()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"SELECT MAX(id) FROM producto;";
            comando.CommandType = CommandType.Text;
            string id = (string)comando.ExecuteScalar().ToString();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return id;
        }
    }
}
