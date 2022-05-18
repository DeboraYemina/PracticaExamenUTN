using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    internal class Gimnasio
    {
        private List<Alumno> _alumnos; //inscriptos
        private List<Instructor> _instructores; //quienes dan clases
        private List<Jornada> _jornada; //se accede a una jornada especifica por medio de indexador

        public Gimnasio()
        { }
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
            return "a;";
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
            //retorna el primer instructor que no puee dar la clase
            return g._instructores[3];
        }
        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g==i);
        }
        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            //se agrega el alumno validando que no exista ya
            return g;
        }
        public static Gimnasio operator +(Gimnasio g, EClases clase)
        {
            //se debe generar y agregar una nueva jornada indicando clase, isntructor (seghun atributo clasedeldia) 
            //y la lioista de alumnos (segun coincidan cion clases que toma)
            return g;
        }
        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            //se agrega el instructor validando que no exista ya
            return g;
        }
        public static bool operator ==(Gimnasio g, Alumno a)
        {
            //son iuales si el alumno esta inscripto en el
            return true;
        }
        public static Instructor operator ==(Gimnasio g, EClases clase)
        {
            //retorna el primer instructor capaz de dar la clase, sino lanza sininstructorexception
            return g._instructores[1];
        }
        public static bool operator ==(Gimnasio g, Instructor i)
        {
            //si el instructor da clases en el gim
            return true;
        }
    }
}
