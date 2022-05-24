using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Gimnasio
    {
        public enum EClases
        {
            CrossFit,
            Natacion,
            Pilates,
            Yoga
        }

        private List<Alumno> _alumnos; //inscriptos
        private List<Instructor> _instructores; //quienes dan clases
        private List<Jornada> _jornada = new List<Jornada>(); //se accede a una jornada especifica por medio de indexador

        public Jornada this[int i]
        {
            get
            {
                return _jornada[i];
            }
        }

        public Gimnasio()
        { 
            _alumnos = new List<Alumno>(); 
            _instructores = new List<Instructor>();
        }
        public static bool Leer()
        {
            //retorna la clase gim guardada en guardar()
            return true;
        }
        public static bool Guardar(Gimnasio gim)
        {
            //serializa los datos de gim en xml, con instructores, aluonos y jornadas
            return true;
        }
        private static string MostrarDatos(Gimnasio gim)
        {
            string a = "";
            foreach (Jornada aux in gim._jornada)
                a+=aux.ToString();
            return a;
        }
        public override string ToString()
        {
           return MostrarDatos(this);
        }
        public static bool operator !=(Gimnasio g, Alumno a)
        {
            return !(g==a);
        }
        public static Instructor operator !=(Gimnasio g, EClases clase)
        {
            foreach (Instructor aux in g._instructores)
            {
                if (aux != clase)
                    return aux;
            }
            throw new SinInstructorException();
        }
        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g==i);
        }
        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            //se agrega el alumno validando que no exista ya
            foreach (Alumno aux in g._alumnos)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)a)
                    throw new AlumnoRepetidoException();
            }
            g._alumnos.Add(a);
            return g;
        }
        public static Gimnasio operator +(Gimnasio g, EClases clase)
        {
            Jornada j = new Jornada(clase, g == clase);
            foreach (Alumno aux in g._alumnos)
                if(aux._claseQueToma==clase)
                    j += aux;
            g._jornada.Add(j);
            //se debe generar y agregar una nueva jornada indicando clase, isntructor (segun atributo clasedeldia) 
            //y la lioista de alumnos (segun coincidan cion clases que toma)
            return g;
        }
        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            foreach (Instructor aux in g._instructores)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)i)
                    break;
            }
            //se agrega el instructor validando que no exista ya
            g._instructores.Add(i);
            return g;
        }
        public static bool operator ==(Gimnasio g, Alumno a)
        {
            foreach (Alumno aux in g._alumnos)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)a)
                    return true;
            }
            //son iuales si el alumno esta inscripto en el
            return false;
        }
        public static Instructor operator ==(Gimnasio g, EClases clase)
        {
            foreach (Instructor aux in g._instructores)
            {
                if (aux == clase)
                    return aux;
            }
            //retorna el primer instructor capaz de dar la clase, sino lanza sininstructorexception
            throw new SinInstructorException();
        }
        public static bool operator ==(Gimnasio g, Instructor i)
        {
            foreach (Instructor aux in g._instructores)
            {
                if ((PersonaGimnasio)aux == (PersonaGimnasio)i)
                    return true;
            }
            //si el instructor da clases en el gim
            return false;
        }
    }
}
