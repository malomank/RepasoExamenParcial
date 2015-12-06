using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Practica2.Modelo;

namespace Vista
{
    public partial class FormAlumno : Form
    {
        public static Alumno AlumnoAgregado;
        public FormAlumno(int tipoUsuario)
        {
            InitializeComponent();
            if (tipoUsuario == 1)
                radioButton2FCI.Visible = false;
            if (tipoUsuario == 2)
                radioButton1EEGGCC.Visible = false;
        }
        /// <summary>
        /// Evento que permite agregar un alumno
        /// </summary>
        /// <param name="sender">Generador de evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar alumno            
            AlumnoNuevo();
            Console.WriteLine(radioButton1EEGGCC.Checked);
            Console.WriteLine(radioButton2FCI.Text);
            MessageBox.Show("Alumno agregado");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void AlumnoNuevo()
        {
            if (radioButton1EEGGCC.Checked)
            {
                AlumnoAgregado = new AlumnoEEGGCC();
                AlumnoAgregado.Codigo = int.Parse(textBoxCodigo.Text);
                AlumnoAgregado.Nombre = textBoxNombre.Text;
                AlumnoAgregado.Dni = int.Parse(textBoxDNI.Text);
                AlumnoAgregado.Correo = textBoxCorreo.Text;
                AlumnoAgregado.Telefono = int.Parse(textBoxTelefono.Text);
                AlumnoAgregado.Ciclo = int.Parse(textBoxCiclo.Text);
                AlumnoAgregado.Creditos = int.Parse(textBoxCreditos.Text);
                AlumnoAgregado.Unidad = "EEGGCC";
                //Especialidad Actual
                //especialidad Anterior
                //tutor
            }
            else
            {
                AlumnoAgregado = new AlumnoFCI();
                AlumnoAgregado.Codigo = int.Parse(textBoxCodigo.Text);
                AlumnoAgregado.Nombre = textBoxNombre.Text;
                AlumnoAgregado.Dni = int.Parse(textBoxDNI.Text);
                AlumnoAgregado.Correo = textBoxCorreo.Text;
                AlumnoAgregado.Telefono = int.Parse(textBoxTelefono.Text);
                AlumnoAgregado.Ciclo = int.Parse(textBoxCiclo.Text);
                AlumnoAgregado.Creditos = int.Parse(textBoxCreditos.Text);
                AlumnoAgregado.Unidad = "FCI";
                //Especialidad Actual
                //especialidad Anterior
                //Resumen reuniones
                //tutor
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
