using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion
{
    public class Proceso
    {
        private static Random aleatorio = new Random();
        public Proceso(int arribo, int burstime,int memoria)
        {
            Pid = creaPid();
            Arribo = arribo;
            Burstime = burstime;
            Instrucciones = creaInstrucciones();
            Progreso = 0;
            Estado = 1;
            DesEstado = "LISTO";
            Memoria = memoria;
            Ejecutado = 0;
        }

        private List<int> creaInstrucciones()
        {
            List<int> instrucciones = new List<int>();
            int numInstrucciones = Convert.ToInt32(this.Burstime);

            for (int i=0;i<numInstrucciones; i++)
            {
                instrucciones.Add(aleatorio.Next(100000, 999999));
            }

            return instrucciones;

        }
        private int creaPid()
        {
            return aleatorio.Next(10000, 99999);
        }
        private int creaArribo()
        {
            return aleatorio.Next(1, 10);
        }

        public int Pid { get; }
        public Double Arribo { get; }
        public Double Burstime { get; }
        public List<int> Instrucciones { get; }
        public Double Progreso { get; set; }
        public int Estado { get; set; }
        public string DesEstado { get; set; }
        public int Memoria { get; set; }

        public Double Ejecutado { get; set; }
    }


}
