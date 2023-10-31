using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Accesorio
    {
        // Variables estaticas. Acceso a la clase conexion para obtener los datos de MySQL
        private static Conexion conexion = new Conexion(); //private para encapsular el objeto de tipo conexion.
        static MySqlDataReader leer;
        static MySqlCommand comando = new MySqlCommand();
        static DataTable tabla = new DataTable();

        // Campos (variables de instancia)
        public string id;
        public string nombre;
        public string descripcion;
        public string precio;
        public string stock;
        public DateTime last_update;

        // Constructor con parámetros
        public Accesorio(string nombre, string descripcion, string precio, string stock)
        {
            // no pongo el id se genera AI.
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.last_update = DateTime.Now;
            this.stock = stock;
        }
        public Accesorio(string id)
        {
            this.id = id;
        }

        

        // Funcion para mostrar todos los accesorios (estatico para que no hay necesidad de tener un objeto instanciado):
        public static DataTable Mostrar(DataTable tabla)
        {
            // usando query:
            //comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "SELECT  id_accesorio, nombre, descripcion, precio, stock, last_update AS ultima_modificacion FROM accesorio;";
            //comando.CommandType = CommandType.Text;
            //leer = comando.ExecuteReader();
            //tabla.Load(leer);
            //conexion.CerrarConexion();
            //leer.Close();
            //return tabla;

            tabla.Clear();
            //usando stored procedure:
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAccesorios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        // Funcion insert:
        public static void InsertarAccesorio(string nombre, string descripcion, string precio, string stock)
        {
            Accesorio accesorio = new Accesorio(nombre, descripcion, precio, stock);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"INSERT INTO accesorio (nombre, descripcion, precio, stock) VALUES ('{accesorio.nombre}', '{accesorio.descripcion}', '{accesorio.precio}', '{accesorio.stock}');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Funcion Delete:
        public static void EliminarAccesorio(string id)
        {
            Accesorio accesorio = new Accesorio(id);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $" DELETE FROM producto_accesorio WHERE id_accesorio = {accesorio.id};" +
                $"DELETE FROM accesorio WHERE id = {accesorio.id};";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //    Accesorio accesorio = new Accesorio(id);
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = $"EliminarAccesorio;" ;
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("id", accesorio.id_accesorio);
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    conexion.CerrarConexion();
        //}

        //Funcion Update:
        public static void EditarAccesorio(string nombre, string descripcion, string precio,  string stock, string id)
        {
            Accesorio accesorio = new Accesorio(nombre, descripcion, precio, stock);
            accesorio.id = id;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"UPDATE accesorio SET nombre = '{accesorio.nombre}', descripcion = '{accesorio.descripcion}', precio = {accesorio.precio}, stock = {accesorio.stock}, last_update = CURDATE() WHERE id = {accesorio.id};";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
