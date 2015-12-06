using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista;
/* Pregunta 6 */
namespace Practica2.Vista
{
    public partial class ReunionesPorFecha : Form
    {
        public ReunionesPorFecha(Form1 padre)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            //this.splitContainer1.Panel2.Paint += new PaintEventHandler(splitContainer1_Panel2_Paint);
            padre.mytimer.restablecer(0, 1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar dibujo
            this.splitContainer1.Panel2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Refresh();
            if(textBoxCodigo.Text != ""){
                ProfesorTutor tutor = GestorTutores.buscarTutor(int.Parse(textBoxCodigo.Text));
                if (tutor == null)
                    MessageBox.Show("Profesor no encontrado", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<Reunion> listaBusqueda = new List<Reunion>();
                    foreach (Reunion reu in tutor.ListaReunion)
                    {
                        if (dateTimePickerInicio.Value < reu.Fecha && dateTimePickerFin.Value >= reu.Fecha)
                        {
                            listaBusqueda.Add(reu);
                        }
                    }
                    pintar(tutor,listaBusqueda);
                }
            }
        }


        private void pintar(ProfesorTutor tutor, List<Reunion> lista)
        {
            Graphics g = this.splitContainer1.Panel2.CreateGraphics();

            Font fTexto = this.splitContainer1.Panel2.Font;
            Brush b = Brushes.Black;

            //g.DrawString("Aqui va el Grafico", fTexto, b, 200, 100);
            int total = lista.Count;
            
            //Grafico
            int x = 1, y = 40;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawString("Reuniones del Profesor " + tutor.Profesor.Nombre +" - " + tutor.Profesor.Codigo.ToString() + ":", fTexto, b, new Point(x + 100, y - 20));
            g.DrawString("del " + dateTimePickerInicio.Text + " al " + dateTimePickerFin.Text , fTexto, b, new Point(x + 100, y));
            g.DrawString("Reuniones: " + total, fTexto, b, new Point(x + 110, y + 20));

            
            System.Drawing.SolidBrush myBrush = new SolidBrush(Color.AliceBlue);

            string[] nombres = new string[total];
            int[] numReuniones = new int[total];
            int contador = 0;
            int indice;
            //alumno.formatearMostrar();
        
            foreach (Reunion reu in lista)
            {
                string mostrar = reu.Alumno.Codigo + " - " + reu.Alumno.Nombre;
                indice = buscarIndice(nombres, mostrar);
                if (indice == -1){
                    nombres[contador] = mostrar;
                    numReuniones[contador++] = 1;
                }else{
                    numReuniones[indice] = numReuniones[indice] + 1;
                }

            }
           
            
            Random randonGen = new Random();
            float angulo1 = 0f,angulo2 = 0f;
            float porcentaje = 360f / total;
            Console.WriteLine(total);
            Rectangle rec = new Rectangle(x + 100, y + 80, 85, 85);
            int anc = x, alt = y;
            for (int i = 0; i < contador; i++){
                Console.WriteLine(nombres[i]);
                Console.WriteLine(numReuniones[i]);
                int reuxAl = (numReuniones[i] * 100) / total;
                angulo2 = (reuxAl * 360) / 100;
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                myBrush.Color = randomColor;
                //Pintar leyenda
                g.FillRectangle(myBrush, new Rectangle(anc + 200, alt + 60, 10, 11));
                g.DrawString(nombres[i], fTexto, b, new Point(anc + 213, alt + 60));
                //Pintar pie
                //angulo2 = angulo1 + numReuniones[i];
                if (i == contador - 1) angulo2 += (360 - angulo1 - angulo2);
                g.FillPie(myBrush, rec, (angulo1) , (angulo2) );
                Console.WriteLine((angulo1 ));
                Console.WriteLine((angulo2 ));
                angulo1 += angulo2;
                //anc += 12;
                alt += 12;
            }

        }

        int buscarIndice(string[] nombres, string nombreBuscado)
        {
            int indice = -1;
            for (int i = 0; i < nombres.Count(); i++)
            {
                if (nombres[i] == nombreBuscado)
                    indice = i;
            }
            return indice;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //button1_Click(sender, e);
        }
    }
}
