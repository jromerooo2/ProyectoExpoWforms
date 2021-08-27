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
            public static bool Login()
            {
                string passwordMD5 = EncryptClass.Encrypt(password);

                return ModeloLogin.Login(username, passwordMD5);
            }

    }

        public class AtributosLogin
        {
            //atributos
            public static string username { get; set; }
            public static string password { get; set; }
        }


    
}
