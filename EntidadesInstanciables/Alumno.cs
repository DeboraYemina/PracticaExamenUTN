using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    internal sealed class Alumno:PersonaGimnasio
    {
        EClases _claseQueToma;
        EEstadoCuenta _estadoCuenta;

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma)
        { }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta)
        { }
        protected string MostrarDatos()
        { }

        protected override string ParticiparEnClase()
        { }

        public bool operator != (Alumno a, EClase clase)
        { }
        public bool operator ==(Alumno a, EClase clase)
        { }

        public string ToString()
        { }
    }
}
