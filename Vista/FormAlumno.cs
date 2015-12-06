using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Modelo;
//using Practica2.Modelo;
using Practica2.ServiceReference2;

namespace Vista
{
    public partial class FormAlumno : Form
    {
        public static Alumno AlumnoAgregado;
        private Especialidad informatica;
        Practica2.ServiceReference2.GestorTutoriaClient clienteTutoria;
        public FormAlumno(int tipoUsuario, Practica2.ServiceReference2.GestorTutoriaClient tutoria)
        {
            InitializeComponent();
            informatica = new Especialidad();
            informatica.Codigo = 1;
            informatica.Nombre = "Ingeniería Informática";
            this.clienteTutoria = tutoria;
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
            Alumno alumnoNuevo = clienteTutoria.buscarAlumno(int.Parse(textBoxCodigo.Text));
            if (alumnoNuevo != null)
            {
                MessageBox.Show("Ya existe un alumno con este codigo");
                return;
            }
            else
            {
                if (radioButton1EEGGCC.Checked)
                    AlumnoAgregado = clienteTutoria.crearAlumno(int.Parse(textBoxCodigo.Text), textBoxNombre.Text, int.Parse(textBoxDNI.Text), textBoxCorreo.Text, int.Parse(textBoxTelefono.Text), int.Parse(textBoxCiclo.Text), double.Parse(textBoxCreditos.Text), informatica, null, "", "EEGGCC");
                else
                    AlumnoAgregado = clienteTutoria.crearAlumno(int.Parse(textBoxCodigo.Text), textBoxNombre.Text, int.Parse(textBoxDNI.Text), textBoxCorreo.Text, int.Parse(textBoxTelefono.Text), int.Parse(textBoxCiclo.Text), double.Parse(textBoxCreditos.Text), informatica, null, "", "FCI");
            }
            MessageBox.Show("Alumno agregado");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
