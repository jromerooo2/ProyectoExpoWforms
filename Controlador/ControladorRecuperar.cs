using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorRecuperar
    {
        public static bool recuperarPassMail(string username)
        {
            bool res = ModeloRecuperar.recuperarPassMail(username);
            bool final = false;
            if (res)
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return final;
        }
    }
}
