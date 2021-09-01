using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorTransporte
    {

        //Atributos
        public static int id_unidad_transporte { get; set; }
        public int id_marca { get; set; }
        public int anio { get; set; }
        public string VIN { get; set; }
        public string capacidad { get; set; }
        public int id_modelo { get; set; }
        public string placa { get; set; }
        public int id_tipo_placa { get; set; }
        public int id_tipo_unidad { get; set;}
        public string numero_chasis { get; set; }
        public string numero_motor { get; set; }

        //Constructor
        ControladorTransporte(int pMarca, int pAnio, string pVIN, string pCapacidad, int pModelo, string pPlaca, int pTipoPlaca, int pTipoUnidad, string pNumeroChasis, string pNumeroMotor)
        {
            id_marca = pMarca;
            anio = pAnio;
            VIN = pVIN;
            capacidad = pCapacidad;
            id_modelo = pModelo;
            placa = pPlaca;
            id_tipo_placa = pTipoPlaca;
            id_tipo_unidad = pTipoUnidad;
            numero_chasis = pNumeroChasis;
            numero_motor = pNumeroMotor;
        }

        public static DataTable ObtenerUnidadesController()
        {
            return ModeloTransporte.ObtenerUnidades();
        }

        //CMB
        public static DataTable ObtenerTipoPlacasController()
        {
            return ModeloTransporte.ObtenerTipoPlacas();
        }

        public static DataTable ObtenerModelosController()
        {
            return ModeloTransporte.ObtenerModelos();
        }

        public static DataTable ObtenerMarcasController()
        {
            return ModeloTransporte.ObtenerMarcas();
        }

        public static DataTable ObtenerTipoUnidadController()
        {
            return ModeloTransporte.ObtenerTipoUnidad();
        }
    }
}
