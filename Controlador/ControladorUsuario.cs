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

        public static DataTable CargarUsuarios()
        {
            return ModeloUsuario.CargarUsuarios();
        }

        public static bool EliminarDatosController(int id)
        {
            return ModeloUsuario.EliminarUsuario(id);
        }

        public static object cargarUsuario(string id_empleado)
        {
            return ModeloUsuario.CargarUsuarioInner(id_empleado);
        }
        public static object cargarCargo(string id_empleado)
        {
            return ModeloUsuario.CargarCargoInner(id_empleado);
        }

        public bool ActualizarUser(int id, int id_empleado, string user, string correo, string password, int id_cargo)
        {
            //haciendolo MD5
            string passMD5 = EncryptClass.Encrypt(password);

            return ModeloUsuario.ActualizarUser(id, id_empleado, user, correo, passMD5, id_cargo);
        }

        public static void BlockUser(string user)
        {
            ModeloUsuario.BlockUser(user);
        }
    }
}
