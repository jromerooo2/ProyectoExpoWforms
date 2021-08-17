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
        public static bool RecuperarMail(string user)
        {
            string res = ModeloRecuperar.recuperarPassMail(user);
            mail(res);
            return true;
        }
        static Random rnd = new Random();
        public static  int code;

        public static void mail(string mail)
        {

            code = rnd.Next(123123, 999999);
            const string p = "JuanRomero>10";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("juan.romeroramos9@gmail.com");

            //Enter your email blow and also change in database too

            message.To.Add(new MailAddress(mail));
            message.Subject = "Cambia tu contraseña";
            message.Body = "Escribe este codigo en el espacio de texto para verificar tu identidad\n" + code + "\n Gracias!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("juan.romeroramos9@gmail.com", p);
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
