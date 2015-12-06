using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Pregunta 4 */
namespace Modelo
{
    [Serializable]
    public class AlumnoFCI : Alumno
    {
        private List<Reunion> listaReunionesAnteriores = new List<Reunion>();

        public List<Reunion> ListaReunionesAnteriores
        {
            get { return listaReunionesAnteriores; }
            set { listaReunionesAnteriores = value; }
        }


        public AlumnoFCI(AlumnoEEGGCC nuevoFCI): base(nuevoFCI.Codigo, nuevoFCI.Nombre, nuevoFCI.Dni, nuevoFCI.Correo, nuevoFCI.Telefono, nuevoFCI.Ciclo, nuevoFCI.Creditos)
        {
            ListaReunionesAnteriores = nuevoFCI.ListaReuniones; //Se mantiene la lista anterior de EEGGCC
            ListaReuniones.Clear();
          
         }

        public AlumnoFCI(int cod, string nom, int dn, string corr, int telf, int cic, int cred,List<Reunion> listaReunionesAnteriores): base(cod, nom, dn, corr, telf,cic,cred)
        {
            ListaReunionesAnteriores = ListaReuniones; //Se mantiene la lista anterior de EEGGCC
            ListaReuniones.Clear();

        }

        public AlumnoFCI()
        {

        }
         
        /*
        public AlumnoFCI(int cod, string nom, int dn, string corr, int telf, int cic, int cred, List<Reunion> listaReuniones): base(cod,nom,dn,corr,telf,cic,cred)
        {
            ListaReunionesAnteriores = listaReuniones; //Se mantiene la lista anterior de EEGGCC
            
        }
        */

        /*public override string formatearMostrar()
        {

            return Codigo + "--" + Nombre+" (FCI)";
        }*/

    }
}
