using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException()
        { }
        public NacionalidadInvalidaException(string message)
        { }
    }
}
