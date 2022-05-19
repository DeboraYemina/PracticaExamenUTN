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
        Queue<Gimnasio.EClases> _clasesDelDia;
        static Random _random;

        private void _randomClases()
        {
            _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(Enum.GetNames(typeof(Gimnasio.EClases)).Length));
            _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(Enum.GetNames(typeof(Gimnasio.EClases)).Length));
            //guardar dos clases al azar en clasesdeldia
        }
        private Instructor()
        {
            _clasesDelDia=new Queue<Gimnasio.EClases>();
            _random = new Random();
            _randomClases();
            //inicializar random
            //inicializar _clasesdeldia, asignar dos clases al azar con _randomclases
        }
        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }
        protected override string MostrarDatos()
        {
            //retornara una cadena con los datos del alumno
            return "a";
        }
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            if (i._clasesDelDia==clase)
                return true;
            return false;
        }
        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }
        public override string ToString()
        {
            return _clasesDelDia.ToString();
        }
        protected override string ParticiparEnClase()
        {
            return "Clase del día" + _clasesDelDia;
        }
    }
}
