using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    class tipoEvaluacion
    {
        string[] tipos = {"Renovación de Contrato", "Portabilidad", "Línea Nueva"};


        public string leerTipoEvaluacion(int tipo)
        {

            return tipos[tipo];
        }
    }

}
