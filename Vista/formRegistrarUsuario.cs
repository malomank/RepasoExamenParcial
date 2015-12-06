using Practica2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica2.Vista
{
    public partial class formRegistrarUsuario : Form
    {
        int tipo = 0;
        ServiceReference1.GestorUsuarioClient cliente = new ServiceReference1.GestorUsuarioClient();
        public formRegistrarUsuario(/*Practica2.ServiceReference1.Service1Client clientePrincipal*/)
        {
            InitializeComponent();
            //cliente = clientePrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.Service1Client cliente2 = new ServiceReference1.Service1Client();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (cliente.existe(textBox1.Text))
                {
                    MessageBox.Show("Error de usuario", "Usuario ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (radioButton1.Checked) //Administrador
                    {
                        tipo = 0;
                    }
                    else
                    {
                        if (radioButton2.Checked) //EEGGCC
                        {
                            tipo = 1;
                        }
                        else //FCI
                        {
                            tipo = 2;
                        }
                    }
                    //cliente.agregarUsuario(textBox1.Text, textBox2.Text, tipo);
                    //usuarioNuevo = new UsuarioRegistrado(textBox1.Text, textBox2.Text, tipo);

                    cliente.agregarUsuario(textBox1.Text, textBox2.Text, tipo);
                    cliente.guardarUsuarios();
                    Console.Out.WriteLine(textBox1.Text + " " + textBox2.Text + " " + tipo);
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos", "Complete el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}