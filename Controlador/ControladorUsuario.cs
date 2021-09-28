using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Controlador
{
   public class ControladorUsuario
    {
        public static DataTable ObtenerEmpleado()
        {
            return ModeloUsuario.CargarEmpleados();
        }

        public bool RegistrarUsuario(string user, string correo,int idCargo,int idEmpleado, string img)
        {
            //haciendolo MD5
            string defaultt = user + "123";
            string password  = ValidacionesClass.Encrypt(defaultt);
            return ModeloUsuario.RegistrarUser(idEmpleado, user, correo, idCargo, password, img);
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

        public bool ActualizarUser(int id, int id_empleado, string user, string correo, int id_cargo)
        {
            //haciendolo MD5
            return ModeloUsuario.ActualizarUser(id, id_empleado, user, correo, id_cargo);
        }
        public static bool ActualizarContraPin(string contra, string pin, int id)
        {
            //haciendolo MD5
            string send = ValidacionesClass.Encrypt(contra);
            return ModeloUsuario.ActualizarContraPin(send, pin, id);
        }

        public static DataTable GetOnlineUsers()
        {
            return ModeloUsuario.GetOnlineUsers();
        }

        public static void BlockUser(string user)
        {
            ModeloUsuario.BlockUser(user);
        }

        public static void PrimerUso(int idlogged)
        {
            ModeloUsuario.PrimerUso(idlogged);
        }

        public static List<string> GetUserImg(string v)
        {
            return ModeloUsuario.GetUserImg(v);
        }

        public static void RestablecerDef(int id, string user)
        {
            string defaultt = user + "123";
            string password = ValidacionesClass.Encrypt(defaultt);
            ModeloUsuario.RestablecerDefault(id, password);
        }
    }
}
