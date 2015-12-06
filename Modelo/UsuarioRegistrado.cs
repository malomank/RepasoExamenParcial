using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Pregunta 6 */
namespace Practica2.Modelo
{
    [Serializable]
    public class UsuarioRegistrado
    {
        public UsuarioRegistrado()
        {
            Username = "";
            Password = "";
            tipo = 0;
            
        }

        public UsuarioRegistrado(string nombre, string clave,int tipo)
        {
            Username = nombre;
            Password = clave;
            Tipo = tipo;
        }
        private string username;
        private string password;
        private int tipo; //0 es administrador general - 1 es Administrador EEGGCC - 2 es Administrador FCI

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
