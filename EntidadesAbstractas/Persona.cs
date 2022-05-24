using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

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
                _apellido = ValidarNombreApellido(value);
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
                _dni = ValidarDni(Nacionalidad, value); 
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
                _nombre = ValidarNombreApellido(value);
            }
        }
        public string StringToDNI 
        {
            get
            {
                return _dni.ToString();
            }
            set
            {
                _dni = ValidarDni(Nacionalidad, value);
            }
        }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringToDNI = dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("NOMBRE COMPLETO: " + Apellido + ", " + Nombre);
            sb.AppendLine();
            sb.AppendLine("NACIONALIDAD: " + Nacionalidad);

            return sb.ToString();
        }
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            
            if (1 < dato && 89999999 > dato && nacionalidad == Persona.ENacionalidad.Argentino)
            {
                return dato;
            }
            else if (nacionalidad == Persona.ENacionalidad.Extranjero && dato > 89999999)
            {
                return dato;
            }
            else
                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
            
            //validar dni correcto, argentino entre 1 y 89999999, sino lanzar excepcion dniinvalidoexception
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                int.Parse(dato);
            }
            catch (DniInvalidoException e)
            { 
                Console.WriteLine(e.Message);
            }
            return ValidarDni(nacionalidad, int.Parse(dato));
        }
        private string ValidarNombreApellido (string dato)
        {
            if (!Regex.IsMatch(dato, "^[A-Z][a-zA-Z]*$"))
            {
                Console.WriteLine("el nombre solo debe contener letras");
            }
            return dato;
        }
        public Persona()
        { }
    }
}
