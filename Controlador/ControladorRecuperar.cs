using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using System.Net;
using System.Net.Mail;

namespace Controlador
{
    public class ControladorRecuperar
    {
        //Atributos para recuperar contraseña por medio del admin
        public string usuarioadmin { get; set; }
        public string claveadmin { get; set; }
        public string usuariorecu { get; set; }
        public string documentoempleado { get; set; }
        public string nuevacontra { get; set; }
        public string PINseguridad { get; set; }

        //Metodo para recuperar por PIN
        public bool RecuperarByPIN_Controller()
        {
            return ModeloRecuperar.RestaurarClave(usuariorecu, PINseguridad);
        }

        public bool ValidarCredenciales_Controller()
        {
            return ModeloRecuperar.ValidarCredenciales(usuarioadmin, claveadmin);
        }

        //public bool ValidarCredencialesPIN_Controller()
        //{
        //    //return ModeloRecuperar.ValidarCredencialesPIN(usuarioadmin, claveadmin);
        //}

        public bool ValidarCredencialesUsuario_Controller()
        {
            return ModeloRecuperar.ValidarCredencialesUsuarios(usuariorecu, documentoempleado);
        }

        public bool RestaurarContra_Controller()
        {
            string contraMD5 = EncryptClass.Encrypt(nuevacontra);
            return ModeloRecuperar.RestaurarClave(usuariorecu, contraMD5);
        }

        public bool ValidarCredencialesUsuario(string pin)
        {
            return ModeloRecuperar.ValidarCredencialesPIN(pin);
        }

        static List<string> res = new List<string>();
        public static bool RecuperarMail(string user)
        {
             res = ModeloRecuperar.recuperarPassMail(user);
            mail(res[1]);
            return true;
        }
        public bool ActualizarContra(string contra)
        {
            //haciendolo MD5
            string passMD5 = EncryptClass.Encrypt(contra);
            return ModeloRecuperar.ActualizarContra(passMD5, res[0]);
        }

        public bool ActualizarContraPIN()
        {
            string passMD5 = EncryptClass.Encrypt(nuevacontra);
            return ModeloRecuperar.RecuperarByPIN(PINseguridad, passMD5);
        }


        static Random rnd = new Random();
        public static  int code;

        public static void mail(string mail)
        {

            code = rnd.Next(123123, 999999);
            const string p = "trackonyou";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("systemlocus@gmail.com");

            //Enter your email blow and also change in database too

            message.To.Add(new MailAddress(mail));
            message.Subject = "Cambia tu contraseña";
            message.Body = "Escribe este codigo en el espacio de texto para verificar tu identidad\n" + code + "\n Gracias!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("systemlocus@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

        }
        public static bool ConfirmCodes(int codeFromLaVista)
        {
            if (codeFromLaVista == code)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
