using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public class Reunion
    {
        Alumno alumno;
        Profesor profesor;
        DateTime fecha;
        string tema;
        string sugerencias;

        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }

        public string Sugerencias
        {
            get
            {
                return sugerencias;
            }

            set
            {
                sugerencias = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Alumno Alumno
        {
            get
            {
                return alumno;
            }

            set
            {
                alumno = value;
            }
        }

        public Profesor Profesor
        {
            get
            {
                return profesor;
            }

            set
            {
                profesor = value;
            }
        }

        public Reunion() { 
            
        }
        public Reunion(Alumno a,Profesor p, DateTime t,string tem,string sug) {
            Alumno=a;
            Profesor=p;
            Fecha=t;
            Tema=tem;
            Sugerencias=sug;
        }
    }
}
