using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Pregunta 4 */
namespace Modelo
{
    [Serializable]
    public class AlumnoEEGGCC : Alumno
    {
        public AlumnoEEGGCC(int cod, string nom, int dn, string corr, int telf,int cic,int cred): base(cod,nom,dn,corr,telf,cic,cred)
        {
            
        }

        public AlumnoEEGGCC(int cod, string nom, int dn, string corr, int telf, int cic, int cred,Especialidad anterior, Especialidad actual)
            : base(cod, nom, dn, corr, telf, cic, cred)
        {
            Especialidad = actual;
            EspecialidadAnterior = anterior;
        }

        public AlumnoEEGGCC()
        {

        }

        private Especialidad especialidadAnterior;

        public Especialidad EspecialidadAnterior
        {
            get { return especialidadAnterior; }
            set { especialidadAnterior = value; }
        }

        public void cambiarEspecialidad(Especialidad nuevaEspecialidad)
        {
            especialidadAnterior = Especialidad;
            Especialidad = nuevaEspecialidad;
        }

        /*public override string formatearMostrar()
        {

            return Codigo + "--" + Nombre + " (EEGGCC)";
        }*/

    }
}
