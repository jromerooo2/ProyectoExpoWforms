using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
   public class ControladorUsuario
    {
        public static DataTable ObtenerEmpleado()
        {
            return ModeloUsuario.CargarEmpleados();
        }

        public bool RegistrarUsuario(string user, string password, string correo,int idCargo,int idEmpleado)
        {
            //haciendolo MD5
            string passMD5 = EncryptClass.Encrypt(password);

            return ModeloUsuario.RegistrarUser(idEmpleado, user, passMD5, correo, idCargo);
        }
    }
}
