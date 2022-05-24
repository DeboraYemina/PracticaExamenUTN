using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Instructor : PersonaGimnasio
    {
        private Queue<Gimnasio.EClases> _clasesDelDia;
        static Random _random;

        private void _randomClases()
        {
            _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(Enum.GetNames(typeof(Gimnasio.EClases)).Length));
            _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(Enum.GetNames(typeof(Gimnasio.EClases)).Length));
            //guardar dos clases al azar en clasesdeldia
        }
        private Instructor()
        {
        }
        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            _clasesDelDia=new Queue<Gimnasio.EClases>();
            _random = new Random();
            _randomClases();
            //inicializar random
            //inicializar _clasesdeldia, asignar dos clases al azar con _randomclases
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("CLASES DEL DIA:");
            foreach (Gimnasio.EClases aux in _clasesDelDia)
            {
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();
            //retornara una cadena con los datos del alumno
            
        }
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            foreach (Gimnasio.EClases aux in i._clasesDelDia)
            {
                if (aux == clase)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }
        public override string ToString()
        {
            return MostrarDatos();
        }
        protected override string ParticiparEnClase()
        {
            string a="";

            foreach (Gimnasio.EClases aux in _clasesDelDia)
            {
                a += aux.ToString();
            }
            return "Clases del día: " + a;
        }
    }
}
