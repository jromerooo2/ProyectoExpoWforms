using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Net.Mail;

namespace Controlador
{
    public class ControladorRecuperar
    {
        public static bool recuperarPassMail(string username)
        {
            //respuesta con el username del modelo
            bool res = ModeloRecuperar.recuperarPassMail(username);

            bool final = false;
            if (res)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("");
                    //sustituir por lo que responda el modelo
                    mail.To.Add("hellojuancho75@gmail.com");
                    mail.Subject = "Test Mail";
                    mail.Body = "This is for testing SMTP mail from GMAIL";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("", "");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    final = true;
                }
                catch (Exception ex)
                {
                    final = false;
                }
            }
            return final;
        }
    }
}
