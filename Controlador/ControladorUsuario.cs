﻿using System;
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

        public bool RegistrarUsuario(string user, string correo,int idCargo,int idEmpleado)
        {
            //haciendolo MD5
            string defaultt = user + "123";
            string password  = ValidacionesClass.Encrypt(defaultt);
            return ModeloUsuario.RegistrarUser(idEmpleado, user, correo, idCargo, password);
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
    }
}
