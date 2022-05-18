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
        public enum EEstadoCuenta
        {
            Deudor,
            MesPrueba,
            AlDia
        }

        public Gimnasio.EClases _claseQueToma;
        EEstadoCuenta _estadoCuenta;

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma)
        { }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta)
        { }
        protected override string MostrarDatos()
        {
            return _claseQueToma.ToString() + _estadoCuenta.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return "Toma clase de " + _claseQueToma;
        }

        public static bool operator != (Alumno a, EClases clase)
        {
            if (a._claseQueToma != clase)
                return true;
            return false;
        }
        public static bool operator ==(Alumno a, EClases clase)
        {
            if (a._estadoCuenta != EEstadoCuenta.Deudor && a._claseQueToma == clase)
                return true;
            return false;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
    }
}
