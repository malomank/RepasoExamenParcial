using System.Collections.Generic;
using Modelo;
using System;

namespace Controlador
{
    [Serializable]
    class GestorAlumnos
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public static List<Alumno> Alumnos
        {
            get { return GestorAlumnos.alumnos; }
            set { GestorAlumnos.alumnos = value; }
        }
                
        /// <summary>
        /// Este método busca un alumno en la lista
        /// dado su código.
        /// </summary>
        /// <param name="p"> Código del alumno
        public static Alumno buscarAlumno(int codigo)
        {
            //Falta completar
            Alumno alumnoBuscado = alumnos.Find(delegate (Alumno al) { return al.Codigo == codigo; });
            if (alumnoBuscado.Codigo == codigo)
                return alumnoBuscado;
            else
                return null;
        }
    }
}
