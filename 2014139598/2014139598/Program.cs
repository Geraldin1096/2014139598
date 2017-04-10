using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2014139598
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var evaluacion = new Evaluacion();
            List<Evaluacion> _listaevaluacion;
            _listaevaluacion = new List<Evaluacion>();

            

            //llenar la clase evaluacion
            evaluacion.Agregar(1, 1, 1, 1, 1, 0, 1);
            evaluacion.mostrarEvaluacion();

            evaluacion.Agregar(1, 1, 2, 1, 0, 1, 2);
            evaluacion.mostrarEvaluacion();

            evaluacion.Agregar(1, 1, 2, 1, 1, 0, 2);
            evaluacion.mostrarEvaluacion();


            Thread.Sleep(3000);
        }
    }
}
