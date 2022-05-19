using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class PersonaGimnasio:Persona
    {
        int _identificador;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        protected virtual string MostrarDatos()
        {
            return _identificador.ToString()+Apellido+Nombre+StringToDNI+Nacionalidad.ToString();
        }

        public static bool operator != (PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return !(pg1 == pg2);
        }
        public static bool operator == (PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            //ver que sean del mismo tipo
            if (pg1.DNI==pg2.DNI && pg1.GetType()==pg2.GetType())
            {
                return true;
            }
            if (pg1._identificador == pg2._identificador && pg1.GetType() == pg2.GetType())
            {
                return true;
            }
            return false;
        }

        protected abstract string ParticiparEnClase();

        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad) 
        {
            _identificador = id;
        }
        public PersonaGimnasio()
        { }
    }
}
