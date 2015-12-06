using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica2.Vista
{
    public partial class PieChart : Form
    {
        public PieChart()
        {
            InitializeComponent();
           
        }

        private void PieChart_Load(object sender, EventArgs e)
        {
            Chart pieChart = new Chart();
            pieChart.Size = this.Size - new Size(0, 40);

            //ChartArea area = new ChartArea("name");
            ChartArea area = new ChartArea("PieChartArea");
            area.BorderWidth = this.Width;
            pieChart.ChartAreas.Add(area);

            pieChart.Series.Clear();
            pieChart.Palette = ChartColorPalette.EarthTones;
            pieChart.BackColor = Color.LightBlue;
            pieChart.Titles.Add("Reuniones por Profesor");
            pieChart.ChartAreas[0].BackColor = Color.Transparent;

            Legend l = new Legend()
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Title = "Profesor"
            };

            pieChart.Legends.Add(l);


            Series s1 = new Series()
            {
                Name = "s1",
                IsVisibleInLegend = true,
                Color = Color.Transparent,
                ChartType = SeriesChartType.Pie
            };

            pieChart.Series.Add(s1);

            Random rnd = new Random(DateTime.Now.Millisecond);
            foreach(ProfesorTutor profe in GestorTutores.Tutores){
                int rndVal = profe.ListaReunion.Count;
                    DataPoint p = new DataPoint(0, rndVal);
                    //p.Label = rndVal.ToString();
                    p.AxisLabel = rndVal.ToString();
	            p.LegendText = profe.Profesor.Nombre;
	            s1.Points.Add(p);
            }

            this.Controls.Add(pieChart);
        }
    }
}
