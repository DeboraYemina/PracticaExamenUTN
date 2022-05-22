using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;
        private Gimnasio.EClases _clase;
        private Instructor _instructor;

        public Jornada this[int i] 
        { 
            get
            {
                return this[i];
            }
        }
        //prop que no entiendo this [int i] {get;} : Jornada

        public static bool Guardar (Jornada jornada)
        {
            //guarda la jornada en un txt
            return true;
        }
        public static bool Leer(Jornada jornada)
        {
            //lee la jornada de un txt
            return true;
        }
        private Jornada()
        {
            _alumnos = new List<Alumno>();
        }
        public Jornada (Gimnasio.EClases clase, Instructor instructor)
        { }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j==a);
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno aux in j._alumnos)
            {
                if (aux == a)
                    return true;
            }
            return false;
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            //agrega un alumno a la clase validadnod anets que no este ya cargado
            return j;
        }
        public override string ToString()
        {
            return _instructor.ToString() + _clase.ToString() + _alumnos.ToString();
        }
    }
}
