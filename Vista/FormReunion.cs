using Controlador;
//using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica2.ServiceReference2;

namespace Practica2.Vista
{
    public partial class FormReunion : Form
    {
        public static Reunion ReunionAgregado;
        private Alumno alumno;
        private Profesor profesor;

        public FormReunion(Alumno alumno)
        {
            this.alumno = alumno;
            this.profesor = alumno.Tutor;
            InitializeComponent();
        }

        public void ReunionNuevo()
        {
            ReunionAgregado = new Reunion();
            ReunionAgregado.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
            ReunionAgregado.Sugerencias = this.textBoxSugerencia.Text;
            ReunionAgregado.Tema = this.textBoxTema.Text;
            ReunionAgregado.Alumno = alumno;
            ReunionAgregado.Profesor = profesor;

            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Agregar reunion            
            ReunionNuevo();
            MessageBox.Show("Reunión agregada");
            DialogResult = DialogResult.OK;
            
            this.Close();
        }
    }
}
