using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    internal abstract class Persona
    {
        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        public string Apellido { get; set; }
        public int DNI { get; set; }
        public ENacionalidad Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string StringToDNI { get; set; }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        { }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        { }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }

        public override string ToString()
        { }

    }
}
