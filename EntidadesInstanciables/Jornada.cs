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
        public Jornada (Gimnasio.EClases clase, Instructor instructor):this()
        {
            _clase = clase;
            _instructor = instructor;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j==a);
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno aux in j._alumnos)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)a)
                    return true;
            }
            return false;
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j._alumnos.Count==0)
                j._alumnos.Add(a);
            foreach (Alumno aux in j._alumnos)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)a)
                    return j;
            }
            j._alumnos.Add(a);
            //agrega un alumno a la clase validadnod anets que no este ya cargado
            return j;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            sb.AppendLine("CLASE DE "+_clase.ToString()+" POR "+_instructor.ToString());
            sb.AppendLine();
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno aux in _alumnos)
            {
                sb.AppendLine(aux.ToString());
            }
            sb.AppendLine("<----------------------------------------------------------------------------------->");
            return sb.ToString();
        }
    }
}
