using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
       public class ControladorLogin : AtributosLogin
        {
            public static int Login()
            {
                string passwordMD5 = ValidacionesClass.Encrypt(password);               
                return ModeloLogin.Login(username, passwordMD5);
            }
        public static List<int> res = new List<int>();
        public static int GetCargo()
        {
            res = ModeloLogin.getUserInfo(username);
            return res[0];
        }
        public static int GetId()
        {
            res = ModeloLogin.getUserInfo(username);
            return res[1];
        }

        public static void LogOut(int idUser)
        {
            ModeloLogin.LogOut(idUser);
        }

        public static string getCargostring(int idcargo)
        {
            return ModeloLogin.getCargoString(idcargo);
        }
    }

        public class AtributosLogin
        {
            //atributos
            public static string username { get; set; }
            public static string password { get; set; }
        }


    
}
