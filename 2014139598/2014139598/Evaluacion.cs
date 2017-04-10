using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    public class Evaluacion
    {
        int id;
        int IdTrabajador;
        int IdTipoEvaluacion;
        int IdEquipoCelular;
        int IdCentroAtencion;
        DateTime FechaEvaluacion;
        int IdEstadoEvaluacion;
        int IdCliente;

        public Evaluacion() { }

        public Evaluacion(int _id, int _IdTrabajador, int _IdTipoEvaluacion, int _IdEquipoCelular, int _IdCentroAtencion,
             int _IdEstadoEvaluacion, int _IdCliente)
        {

            id = _id;
            IdTrabajador = _IdTrabajador;
            IdTipoEvaluacion = _IdTipoEvaluacion;
            IdEquipoCelular = _IdTipoEvaluacion;
            IdCentroAtencion = _IdCentroAtencion;
            //FechaEvaluacion = _FechaEvaluacion;
            IdEstadoEvaluacion = _IdEstadoEvaluacion;
            IdCliente = _IdCliente;


        }

        private string getEvaluacion(int tipoDeEvaluacion){
            string lista;
            lista = "hola";
            return lista;
        }

        public void mostrarEvaluacion(){

            Cliente cliente;
            cliente = new Cliente();

            trabajador miTrabajador;
            miTrabajador = new trabajador();

            tipoEvaluacion tipoEval;
            tipoEval = new tipoEvaluacion();

            tipoCelular tipocelular;
            tipocelular = new tipoCelular();

            CentroAtencion centroatencion;
            centroatencion = new CentroAtencion();

            EstadoEvaluacion estadoeval;
            estadoeval = new EstadoEvaluacion();

            String linea;
            linea = string.Concat("Id:",id ," Trabajador:", miTrabajador.leerTrabajador(IdTrabajador) ," Evaluacion:",
                tipoEval.leerTipoEvaluacion(IdTipoEvaluacion), " equipoCelular:",
                tipocelular.leerTipoCelular(IdEquipoCelular), " centro Atncion:", centroatencion.leerCA(IdCentroAtencion),
                " Estado:", estadoeval.leerEstado(IdEstadoEvaluacion) , ": cliente:", 
                cliente.leerCliente(IdCliente));

            Console.WriteLine(linea);

            Console.WriteLine();

            
        }



        public void Agregar(int _id, int _IdTrabajador, int _IdTipoEvaluacion, int _IdEquipoCelular, int _IdCentroAtencion,
                     int _IdEstadoEvaluacion, int _IdCliente)
        {

            id = _id;
            IdTrabajador = _IdTrabajador;
            IdTipoEvaluacion = _IdTipoEvaluacion;
            IdEquipoCelular = _IdTipoEvaluacion;
            IdCentroAtencion = _IdCentroAtencion;
            //FechaEvaluacion = _FechaEvaluacion;
            IdEstadoEvaluacion = _IdEstadoEvaluacion;
            IdCliente = _IdCliente;


        }


    }
}
