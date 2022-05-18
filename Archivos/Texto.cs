using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Texto:IArchivo
    {
        public bool guardar(string archivo, string datos)
        {
            return true;
        }
        public bool leer(string archivo, out string datos)
        {
            return true;
        }
    }

}
