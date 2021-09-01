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
                string passwordMD5 = EncryptClass.Encrypt(password);               
                return ModeloLogin.Login(username, passwordMD5);
            }
        static List<int> res = new List<int>();
        public static int GetCargo()
        {
            res = ModeloLogin.getUserInfo(username);
            return res[0];
        }
    }

        public class AtributosLogin
        {
            //atributos
            public static string username { get; set; }
            public static string password { get; set; }
        }


    
}
