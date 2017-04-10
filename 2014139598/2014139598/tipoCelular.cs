using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    class tipoCelular
    {
        string[] tipos = { "Andriod", "Apple", "Microsoft" };


        public string leerTipoCelular(int tipo)
        {

            return tipos[tipo];
        }
    }
}
