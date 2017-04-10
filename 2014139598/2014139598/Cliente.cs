using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598
{
    

    class Cliente
    {
        string[] misclientes = { "Dandy Soto", "Elsa Ferreyra", "Ximena Saldarriaga" };

        public string leerCliente(int _id) { 
            return misclientes[_id];
        }
    }
}
