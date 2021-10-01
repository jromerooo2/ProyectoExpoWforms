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
        public string DUI { get; set; }
        public string nuevacontra { get; set; }
        public string PINseguridad { get; set; }
        public string NIT { get; set; }

        #region MetodoPIN
        public bool ValidarPINusuario(string pin)
        {
            return ModeloRecuperar.ValidarCredencialesPIN(pin, usuariorecu);
        }

        public bool ActualizarContraPIN()
        {
            string passMD5 = ValidacionesClass.Encrypt(nuevacontra);
            return ModeloRecuperar.RecuperarByPIN(PINseguridad, passMD5, usuariorecu);
        }

        public bool ValidarDocumentosPIN()
        {
            return ModeloRecuperar.ValidarCredencialesUsuariosPIN(usuariorecu, DUI, NIT);
        }
        #endregion

        #region MetodoAdmin
        public bool ValidarCredenciales_Controller()
        {
            return ModeloRecuperar.ValidarCredenciales(usuarioadmin, claveadmin);
        }

        public bool ValidarCredencialesUsuario_Controller()
        {
            return ModeloRecuperar.ValidarCredencialesUsuarios(usuariorecu, DUI);
        }

        public bool RestaurarContra_Controller()
        {
            string contraMD5 = ValidacionesClass.Encrypt(nuevacontra);
            return ModeloRecuperar.RestaurarClave(usuariorecu, contraMD5);
        }
        #endregion

        #region Correo
        static List<string> res = new List<string>();
        public static bool RecuperarMail(string user)
        {
            if (res.Count != 0)
            {
                res = ModeloRecuperar.recuperarPassMail(user);
                mail(res[1]);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool ActualizarContra(string contra)
        {
            //haciendolo MD5
            string passMD5 = ValidacionesClass.Encrypt(contra);
            return ModeloRecuperar.ActualizarContra(passMD5, res[0]);
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
        public static bool ConfirmCode(int codeFromLaVista)
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
        #endregion

        #region PrimerUso
        public static void confirmMailFirstUse(string mail)
        {

            code = rnd.Next(123123, 999999);
            const string p = "trackonyou";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("systemlocus@gmail.com");

            //Enter your email blow and also change in database too

            message.To.Add(new MailAddress(mail));
            message.Subject = "Confirma tu cuenta";
            message.Body = "Escribe este codigo en el espacio de texto para verificar tu identidad\n" + code + "\n Gracias!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("systemlocus@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
        public static bool CodeFirstUse(int codeFromLaVista)
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
        #endregion
    }
}
