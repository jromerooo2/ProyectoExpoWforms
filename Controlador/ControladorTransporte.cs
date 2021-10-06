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
        public int capacidad { get; set; }
        public int id_modelo { get; set; }
        public string placa { get; set; }
        public int id_tipo_placa { get; set; }
        public int id_tipo_unidad { get; set;}
        public int id_estado_unidad { get; set; }
        public string numero_chasis { get; set; }
        public string numero_motor { get; set; }

        //Constructor
        public ControladorTransporte(int pMarca, int pAnio, string pVIN, int pCapacidad, int pModelo, string pPlaca, int pTipoPlaca, int pTipoUnidad, int pEstadoUnidad,string pNumeroMotor, string pNumeroChasis)
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
            id_estado_unidad = pEstadoUnidad;
        }

        public bool IngresarUnidadesController()
        {
            return ModeloTransporte.IngresarUnidades(id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad, id_estado_unidad,numero_motor, numero_chasis);
        }

        public static DataTable ObtenerUnidadesController()
        {
            return ModeloTransporte.ObtenerUnidades();
        }
        public static bool EliminarUnidad()
        {
            return ModeloTransporte.EliminarUnidades(id_unidad_transporte);
        }

        public bool ActualizarUnidadController()
        {
            return ModeloTransporte.ActualizarUnidades(id_unidad_transporte, id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad,id_estado_unidad, numero_motor, numero_chasis);
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

        public static DataTable ObtenerEstadoUnidadController()
        {
            return ModeloTransporte.ObtenerEstadoUnidad();
        }

        public static DataTable ObtenerMarcasInner(string id)
        {
            return ModeloTransporte.ObtenerMarcasInner(id);
        }

        public static DataTable ObtenerModeloInner(string id)
        {
            return ModeloTransporte.ObtenerModelosInner(id);
        }

        public static DataTable ObtenerTipoUnidadInner(string id)
        {
            return ModeloTransporte.ObtenerTipoUnidadInner(id);
        }

        public static DataTable ObtenerEstadoUnidadInner(string id)
        {
            return ModeloTransporte.ObtenerEstadoUnidadInner(id);
        }

        public static DataTable ObtenerTipoPlacaInner(string id)
        {
            return ModeloTransporte.ObtenerTipoPlacasInner(id);
        }
    }
}
