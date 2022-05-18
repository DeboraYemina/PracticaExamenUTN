using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    abstract class Persona
    {
        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        public string Apellido { get; set; }
        public int DNI 
        {
            get 
            { 
                return _dni; 
            }
            set 
            { 
                _dni = ValidarDNni(_nacionalidad, _dni); 
            } 
        }
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
        private int ValidarDni (ENacionalidad nacionalidad, int dato)
        {
            //validar dni correcto, argentino entre 1 y 89999999, sino lanzar excepcion dniinvalidoexception
            return 5;
        }
        private int ValidarDNni(ENacionalidad nacionalidad, string dato)
        { }
        private string ValidarNombreApellido (string dato)
        { }
    }
}
