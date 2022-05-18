using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    internal class Gimnasio
    {
        private List<Alumno> _alumnos;
        private List<Instructor> _instructores;
        private List<Jornada> _jornada;

        public Gimnasio()
        { }
        public bool Guardar(Gimnasio gim)
        { }
        private string MostrarDatos(Gimnasio gim)
        { }
        public string ToString()
        { }
        public bool operator !=(Gimnasio g, Alumno a)
        { }
        public Instructor operator !=(Gimnasio g, EClase clase)
        { }
        public bool operator !=(Gimnasio g, Instructor i)
        { }
        public Gimnasio operator +(Gimnasio g, Alumno a)
        { }
        public Gimnasio operator +(Gimnasio g, EClase clase)
        { }
        public Gimnasio operator +(Gimnasio g, Instructor i)
        { }
        public bool operator ==(Gimnasio g, Alumno a)
        { }
        public Instructor operator ==(Gimnasio g, EClase clase)
        { }
        public bool operator ==(Gimnasio g, Instructor i)
        { }
        public Gimnasio operator -(Gimnasio g, Alumno a)
        { }
        public Gimnasio operator -(Gimnasio g, EClase clase)
        { }
        public Gimnasio operator -(Gimnasio g, Instructor i)
        { }
    }
}
