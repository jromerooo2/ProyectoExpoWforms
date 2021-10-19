using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemGestionBuses.Idiomas
{
    class Idioma
    {
        //Atributos
        public string Nombre { get; set; }
        public string Abrev_Idioma { get; set; }
        public string Pais { get; set; }
        public string Abrev_Pais { get; set; }

        //CargarIdioma
        public string CargarNombre_Pais
        {
            get 
            {
                return Nombre + "(" + Pais + ")";

            }
        }

        //Capturando Ab_Nombre y Ab_Pais
        public string CultureInfo
        {
            get
            {
                return Abrev_Idioma + "_" + Abrev_Pais;
            }
        }

        //Procesos
        public static List<Idioma> ObtenerIdiomas()
        {
            return new List<Idioma>
            {
                new Idioma
                {
                    Nombre = "Español",
                    Abrev_Idioma = "es",
                    Pais = "El Salvador",
                    Abrev_Pais = "SV"
                },
                new Idioma
                {
                    Nombre = "English",
                    Abrev_Idioma = "en",
                    Pais = "Estados Unidos",
                    Abrev_Pais = "US"
                },
            };
        }
    }
}
