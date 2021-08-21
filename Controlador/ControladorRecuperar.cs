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
