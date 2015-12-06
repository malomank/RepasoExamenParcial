using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Modelo
{
    [Serializable]
    public class Alumno : Persona
    {
        private int ciclo;
        private int creditos;
        private List<Reunion> listaReuniones = new List<Reunion>();//lista de reuniones
        private Profesor tutor;

        public Profesor Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }

        public List<Reunion> ListaReuniones
        {
            get { return listaReuniones; }
            set { listaReuniones = value; }
        }

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        private string unidad;

        //Agregar unidad
        public Alumno(int cod, string nom, int dn, string corr, int telf,int cic,int cred)
            : base(cod,nom,dn,corr,telf)
        {
            ciclo = cic;
            creditos = cred;
        }
        public Alumno()
            : base()
        {
            ciclo = 0;
            creditos = 0;
        }
        /*public override string formatearMostrar() { 

            return Codigo + "--" + Nombre; 
        }*/

        public void agregarReunion(Reunion reunion) {
            ListaReuniones.Add(reunion);
        }
    }
}
