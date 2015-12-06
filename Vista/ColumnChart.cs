using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica2.Vista
{
    public partial class ColumnChart : Form
    {
        public ColumnChart()
        {
            InitializeComponent();
        }

        private void ColumnChart_Load(object sender, EventArgs e)
        {
            int max1 = -1, max2 = -1, max3 = -1;
            string nombre1 = "", nombre2 = "", nombre3 = "";

            foreach (ProfesorTutor p in GestorTutores.Tutores)
            {
                int numReunion = p.ListaReunion.Count;

                if (numReunion > max1)
                {
                    max1 = numReunion;
                    nombre1 = p.Profesor.Nombre;
                }
                else
                {
                    if (numReunion > max2)
                    {
                        max2 = numReunion;
                        nombre2 = p.Profesor.Nombre;
                    }
                    else
                    {
                        if (numReunion > max3)
                        {
                            max3 = numReunion;
                            nombre3 = p.Profesor.Nombre;
                        }
                    }
                }

            }



            //vectores con los datos
            string[] series = { nombre1, nombre2, nombre3 };
            if (max1 < 0) max1 = 0;
            if (max2 < 0) max2 = 0;
            if (max3 < 0) max3 = 0;
            int[] puntos = { max1, max2, max3};

            //cambiar combinacion de colores
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("TOP 3 de Reuniones por Profesor");

            //llenado de grafico
            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);

            }
        }
    }
}
