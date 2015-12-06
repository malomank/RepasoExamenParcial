using Modelo;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Controlador
{
    [Serializable]
    class GestorTutores
    {
        private static List<ProfesorTutor> tutores = new List<ProfesorTutor>();

        public static List<ProfesorTutor> Tutores
        {
            get { return GestorTutores.tutores; }
            set { GestorTutores.tutores = value; }
        }
        
        public void agregarProfesorTutor(Profesor profesor)
        {
            ProfesorTutor prof=new ProfesorTutor(profesor);
            Tutores.Add(prof);
        }

        /// <summary>
        /// Este método busca un profesor en la lista
        /// dado su código.
        /// </summary>
        /// <param name="p"> Código del tutor
        public static ProfesorTutor buscarTutor(int codigo)
        {
            //Busca al profesor
            ProfesorTutor profeBuscado = tutores.Find(delegate (ProfesorTutor al) { return al.Codigo == codigo; });

            if (profeBuscado != null)
            {
                if (profeBuscado.Codigo == codigo)
                    return profeBuscado;
                else return null;
            }
            else return null;
        }
    }   
}
