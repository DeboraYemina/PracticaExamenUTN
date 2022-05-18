using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Xml<T>:IArchivo
    {
        public bool guardar(string archivo, T datos)
        {
            return true;
        }
        public bool leer(string archivo, out T datos)
        {
            return true;
        }
    }
}
