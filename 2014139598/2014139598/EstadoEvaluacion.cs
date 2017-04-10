using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    class EstadoEvaluacion
    {
        string[] tipos = { "Aprobado", "Desaprobado", "Pendiente" };


        public string leerEstado(int tipo)
        {

            return tipos[tipo];
        }
    }
}
