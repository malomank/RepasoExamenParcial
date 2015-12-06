using Vista;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public abstract class Persona//: IMostrable
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private int dni;
        private string correo;
        private int telefono;

        public Persona(int cod,string nom,int dn,string corr,int telf) {
            codigo = cod;
            nombre = nom;
            Dni = dn;
            Correo = corr;
            Telefono = telf;
        }
        //public abstract string formatearMostrar() ;
        public Persona()
        {
            codigo = 0;
            nombre = "";
            Dni = 0;
            Correo = "";
            Telefono = 0;
        }
    }
}
