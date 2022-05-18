using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    sealed class Instructor : PersonaGimnasio
    {
        Queue<EClases> _clasesDelDia;
        Random _random;

        private void _randomClases()
        { }
        private Instructor()
        { }
        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        { }
        protected string MostrarDatos()
        { }
        public bool operator ==(Instructor i,  EClase clase)
        { }
        public bool operator !=(Instructor i, EClase clase)
        { }
        protected string ParticiparEnClase()
        { }
        public string ToString()
        { 
        }
    }
}
