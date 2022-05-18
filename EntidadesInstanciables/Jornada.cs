using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    internal class Jornada
    {
        private List<Alumno> _alumnos;
        private EClases _clase;
        private Instructor _instructor;
        //prop que no entiendo this [int i] {get;} : Jornada

        public bool Guardar (Jornada jornada)
        { }
        private Jornada()
        { }
        public Jornada(EClases clase, Instructor instructor)
        { }
        public static bool operator !=(Jornada j, Alumno a)
        { }
        public static bool operator ==(Jornada j, Alumno a)
        { }
        public static Jornada operator +(Jornada j, Alumno a)
        { }
        public static Jornada operator -(Jornada j, Alumno a)
        { }
        public string ToString()
        { }
    }
}
