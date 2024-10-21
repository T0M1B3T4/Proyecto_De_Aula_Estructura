using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Museo
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "tienda";
            string usuario = "root";
            string password = "password";
            string CadenaConexion = "Database = " + bd + "; Data Source = " + servidor + "; User ID = " + usuario + "; Password = " + password;
            try
            {
                MySqlConnection conexionDB = new MySqlConnection(CadenaConexion);
                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}