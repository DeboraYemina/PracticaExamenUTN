using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Alumno:PersonaGimnasio
    {
        public enum EEstadoCuenta
        {
            Deudor,
            MesPrueba,
            AlDia
        }

        public Gimnasio.EClases _claseQueToma;
        EEstadoCuenta _estadoCuenta;

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma):base(id, nombre,apellido,dni,nacionalidad)
        {
            _claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            _estadoCuenta = estadoCuenta;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine();
            sb.AppendLine("ESTADO DE CUENTA: "+_estadoCuenta.ToString());
            sb.AppendLine(ParticiparEnClase());
            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            return "Toma clase de " + _claseQueToma;
        }
        public static bool operator != (Alumno a, Gimnasio.EClases clase)
        {
            if (a._claseQueToma != clase)
                return true;
            return false;
        }
        public static bool operator ==(Alumno a, Gimnasio.EClases clase)
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
