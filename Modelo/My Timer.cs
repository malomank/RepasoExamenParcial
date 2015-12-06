using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practica2.Modelo
{
    public class MyTimer
    {
        private int hora;
        private int minuto;
        private int segundo;

        public MyTimer(int hh, int mm, int ss)
        {
            hora = hh;
            minuto = mm;
            segundo = ss;
        }

        public string imprimirFormato()
        {
            string cadena_timer = "";
            /*
            if (hora < 10) cadena_timer += "0" + hora.ToString();
            else cadena_timer += hora.ToString();
            cadena_timer += ":";
            */
            if (minuto < 10) cadena_timer += "0" + minuto.ToString();
            else cadena_timer += minuto.ToString();
            cadena_timer += ":";
            if (segundo < 10) cadena_timer += "0" + segundo.ToString();
            else cadena_timer += segundo.ToString();

            return "Tiempo Restante: " + cadena_timer;
        }

        public void tick_timer()
        {
            if (segundo > 0) segundo--;
            else
            {
                segundo = 59;
                if (minuto > 0) minuto--;
                else
                {
                    minuto = 59;
                    if (hora > 0) hora--;
                }
            }
        }

        public bool quedaTiempo()
        {
            if (hora == 0 && minuto == 0 && segundo == 0) return false;
            else return true;
        }

        public void restablecer(int hh, int mm, int ss)
        {
            hora = hh;
            minuto = mm;
            segundo = ss;
        }
    }
}
