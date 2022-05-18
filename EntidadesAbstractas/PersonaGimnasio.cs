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
        protected string MostrarDatos()
        { 
        }

        public static bool operator != (PersonaGimnasio pg1, PersonaGimnasio pg2)
        { }
        public static bool operator == (PersonaGimnasio pg1, PersonaGimnasio pg2)
        { }

        protected abstract string ParticiparEnClase()
        { }

        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
        { }
    }
}
