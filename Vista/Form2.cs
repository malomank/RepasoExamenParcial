using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class Form2 : Form
    {
        public static Profesor ProfesorAgregado;
        Especialidad informatica = new Especialidad(1, "Ingeniería Informática");
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que permite agregar tutor
        /// </summary>
        /// <param name="sender">Generador de evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Especialidad esp,
            // string fIn,string fFin
            //codigo nombre dni correo telefono idioma año grado especialidad fechaInicio fechaRevalidacion fechaFin categoria esTutor
            //Agregar profesor
            ProfesorAgregado = new ProfesorOrdinario(int.Parse(textBoxCodigo.Text),textBoxNombre.Text,int.Parse(textBoxDNI.Text),"pucp",0,comboBoxDedicacion.SelectedText,0,0,"PhD",informatica,dateTimePickerInicio.Text, dateTimePickerInicio.Text,dateTimePickerFin.Text,comboBoxCategoria.SelectedText);
            MessageBox.Show("Profesor agregado");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
