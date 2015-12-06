using Practica2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        //public static UsuarioRegistrado usuarioActual;
        Practica2.ServiceReference1.GestorUsuarioClient cliente = new Practica2.ServiceReference1.GestorUsuarioClient();
        int tipo;
        string nombre;

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        public int Tipo
        {
            get{return tipo;}
            set{tipo = value;}
        }

        public Login(/*Practica2.ServiceReference1.Service1Client clientePrincipal*/)
        {
            InitializeComponent();
            //cliente = clientePrincipal;
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar usuario
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Practica2.ServiceReference1.Usuario uB = cliente.buscarUsuario(textBox1.Text);
                if (uB != null)
                {
                    if(uB.Password == textBox2.Text)
                    {
                        //usuarioActual = new UsuarioRegistrado();
                        //usuarioActual.Username = uB.User;
                        //usuarioActual.Password = uB.Password;
                        //usuarioActual.Tipo = uB.Tipo;
                        tipo = uB.Tipo;
                        nombre = uB.User;
                        this.DialogResult = DialogResult.OK;
               
                    }
                    else
                    {
                        MessageBox.Show("Error de Contraseña", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error de usuario", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos", "Complete el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       

        }

    }
}
