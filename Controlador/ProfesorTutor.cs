using System;
using System.Collections.Generic;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Controlador
{
    [Serializable]
    public class ProfesorTutor 
    {
        private Profesor profesor;
        private List<Alumno> listaAlumno = new List<Alumno>();
        private List<Reunion> listaReunion = new List<Reunion>();

        internal List<Alumno> ListaAlumno
        {
            get { return listaAlumno; }
            set { listaAlumno = value; }
        }
        

        public ProfesorTutor(Profesor profesor)
        {
            this.Profesor = profesor;            
        }

        public string getNodoProfesor()
        {
            return Profesor.Codigo + "-" + Profesor.Nombre;
        }

        public int Codigo
        {
            get { return Profesor.Codigo; }
        }

        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        public List<Reunion> ListaReunion
        {
            get { return listaReunion; }
            set { listaReunion = value; }
        }

        internal void agregarAlumno(Alumno alumno)
        {
            listaAlumno.Add(alumno);
        }

        public void agregarReunion(Reunion reunion) {
            this.ListaReunion.Add(reunion);
        }
    }
}
