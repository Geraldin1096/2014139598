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
            evaluacion.mostrarEvaluacion();
            Thread.Sleep(3000); //duracion de llamada en milisegundos
        }
    }
}
