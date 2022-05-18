using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        public string Apellido 
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = ValidarNombreApellido(_apellido);
            }
        }
        public int DNI 
        {
            get 
            { 
                return _dni; 
            }
            set 
            { 
                _dni = ValidarDni(_nacionalidad, _dni); 
            } 
        }
        public ENacionalidad Nacionalidad { get; set; }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = ValidarNombreApellido(_nombre);
            }
        }
        public string StringToDNI { get; set; }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        { }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        { }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }

        public override string ToString()
        {
            return Nacionalidad.ToString()+Nombre+DNI.ToString()+Apellido;
        }
        private int ValidarDni (ENacionalidad nacionalidad, int dato)
        {
            //validar dni correcto, argentino entre 1 y 89999999, sino lanzar excepcion dniinvalidoexception
            return 5;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            //validar dni correcto, argentino entre 1 y 89999999, sino lanzar excepcion dniinvalidoexception
            return 5;
        }
        private string ValidarNombreApellido (string dato)
        {
            //validara que sean carateres validos opara nombe y apellido
            return "a";
        }
        public Persona()
        { }
    }
}
