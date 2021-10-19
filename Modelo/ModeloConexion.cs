using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloConexion
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection rtrn;
            string server, database, user, password, puerto;
            server = "127.0.0.1";
            database = "dbsistemaviajes";
            user = "root";
            password = "";
            puerto = "3306";
            try
            {
                rtrn = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + user +
                                              "; pwd = " + password +
                                              "; port = " + puerto+
                                              ";convert zero datetime=True");
                rtrn.Open();
                return rtrn;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
