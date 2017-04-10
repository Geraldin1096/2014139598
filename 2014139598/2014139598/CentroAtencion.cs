using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    class CentroAtencion
    {
        string[] tipos = { "C.C San Isidro", "C.C Miraflores", "C.C Ventanilla" };


        public string leerCA(int tipo)
        {

            return tipos[tipo];
        }
    }
}
