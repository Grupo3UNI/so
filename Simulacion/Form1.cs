using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Simulacion
{
    public partial class Form1 : Form
    {
        private static Random aleatorio = new Random();
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int ubiProcesoElegido = 0;
        static List<Proceso> procesos = new List<Proceso>();
        static Double tiempo = 0;
        static bool cambio = false;
        static int timer = 50;
        static Double aumentaTimer = 0.05;
        static int ubiAnterior = 100;
        static int ubiActual = 100;
        static Color colorVerde = Color.FromArgb(95, 190, 125);
        static Color colorAzul = Color.FromArgb(85, 171, 229);
        static Color colorNegro = Color.FromArgb(38, 38, 38);
        static Color colorRojo = Color.FromArgb(240, 125, 136);
        static int ubiRR = 0;
        static Double contRR = 0;
        static Double rr = 2;
        static List<int> _memoria = new List<int>();
        static int _tamMemoria = 1000;
        static List<List<int>> _arregloMemoriaVac = new List<List<int>>();
        public Form1()
        {
            InitializeComponent();
           
          

            DataGridViewTextBoxColumn Columna0 = new DataGridViewTextBoxColumn();
            Columna0.HeaderText = "PID";
            Columna0.Width = 50;

            DataGridViewImageColumn Columna1 = new DataGridViewImageColumn();
            Columna1.HeaderText = "PROGESO";
            Columna1.Width = 105;

            DataGridViewTextBoxColumn Columna2 = new DataGridViewTextBoxColumn();
            Columna2.HeaderText = "ESTADO";
            Columna2.Width = 80;


            DataGridViewTextBoxColumn Columna3 = new DataGridViewTextBoxColumn();
            Columna3.HeaderText = "PID PADRE";
            Columna3.Width = 100;

            DataGridViewTextBoxColumn Columna4 = new DataGridViewTextBoxColumn();
            Columna4.HeaderText = "PC";
            Columna4.Width = 50;

            DataGridViewTextBoxColumn Columna5 = new DataGridViewTextBoxColumn();
            Columna5.HeaderText = "MEMORIA";
            Columna5.Width = 80;

            DataGridViewTextBoxColumn Columna6 = new DataGridViewTextBoxColumn();
            Columna6.HeaderText = "ARRIBO";
            Columna6.Width = 60;

            DataGridViewTextBoxColumn Columna7 = new DataGridViewTextBoxColumn();
            Columna7.HeaderText = "EJECUTADO";
            Columna7.Width = 80;

            DataGridViewTextBoxColumn Columna8 = new DataGridViewTextBoxColumn();
            Columna8.HeaderText = "BURSTIME";
            Columna8.Width = 80;

            DataGridViewTextBoxColumn Columna9 = new DataGridViewTextBoxColumn();
            Columna9.HeaderText = "ESPERA";
            Columna9.Width = 80;

            /*  ESQUEMA DE PLANIFICACIÓN  */
            cbEsquema.Items.Add("Expropiativo");
            cbEsquema.Items.Add("No Expropiativo");

            /*  CRITERIO DE PLANIFICACIÓN  */
            cbPlanificador.Items.Insert(0,"FCFS");
            cbPlanificador.Items.Insert(1,"SJF");
            cbPlanificador.Items.Insert(2, "RR");

            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 
                Columna0, Columna1 , Columna2, Columna3, Columna4, Columna5, Columna6, Columna7, Columna8, Columna9
            });

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            myTimer.Tick += new EventHandler(Ejecutar);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = timer;


            for (int i = 0;i<_tamMemoria;i++)
            {
                _memoria.Add(0);
            }

            
        }

        public void Ejecutar(Object myObject, EventArgs myEventArgs)
        {
            Despachar();
            Planificar();
            Despachar();

            if (cambio)
            {
                procesos[ubiActual].Ejecutado = Math.Round(procesos[ubiActual].Ejecutado + aumentaTimer, 2);
                dataGridView1[7, ubiActual].Value = Math.Round(procesos[ubiActual].Ejecutado,0).ToString();
                if (procesos[ubiActual].Ejecutado != procesos[ubiActual].Burstime)
                {
                    dataGridView1[4, ubiActual].Value = procesos[ubiActual].Instrucciones[Convert.ToInt32(Math.Truncate(procesos[ubiActual].Ejecutado))].ToString();
                }

                int tipoPlan = cbPlanificador.SelectedIndex;
                if (tipoPlan==2)
                {
                    contRR = Math.Round(contRR + aumentaTimer, 2);
                }
                
            }

            tiempo = Math.Round(tiempo + aumentaTimer,2);
            txtTiempo.Text = Math.Round(tiempo,0).ToString();

            cambiarColor();

        }

        public void Despachar()
        {
            Bitmap miImagen = new Bitmap(101, 20);
            Bitmap miImagen2 = new Bitmap(101, 20);

            if (ubiActual!=100)
            {
                ubiAnterior = ubiActual;
                ubiActual = ubiProcesoElegido;

                if (procesos[ubiAnterior].Ejecutado == procesos[ubiAnterior].Burstime)
                {
                    procesos[ubiAnterior].Estado = 5;
                    procesos[ubiAnterior].DesEstado = "TERMINADO";
                    dataGridView1[2, ubiAnterior].Value = "TERMINADO";
                   // limpiarMemoriaProceso(ubiAnterior);
                }
                else
                {
                    procesos[ubiAnterior].Estado = 2;
                    procesos[ubiAnterior].DesEstado = "LISTO";
                    dataGridView1[2, ubiAnterior].Value = "LISTO";
                }

                
                if (procesos[ubiActual].Ejecutado == procesos[ubiActual].Burstime)
                {
                    procesos[ubiActual].Estado = 5;
                    procesos[ubiActual].DesEstado = "TERMINADO";
                    dataGridView1[2, ubiActual].Value = "TERMINADO";
                    //limpiarMemoriaProceso(ubiActual);
                }
                else
                {
                    procesos[ubiActual].Estado = 3;
                    procesos[ubiActual].DesEstado = "EJECUTANDO";
                    dataGridView1[2, ubiActual].Value = "EJECUTANDO";
                }


            }
            else
            {
                ubiAnterior = ubiProcesoElegido;
                ubiActual = ubiProcesoElegido;
                
            }
            
        }

        public void cambiarColor()
        {
            for(int i=0; i <procesos.Count(); i++)
            {
                
                Bitmap miImagen = new Bitmap(101, 20);
                int avance = (int)((procesos[i].Ejecutado * 100) / procesos[i].Burstime);
                int height = miImagen.Height;

                for (int j = 1; j < avance; j++)
                {
                    for (int k = 1; k < height; k++)
                    {
                        switch(procesos[i].Estado)
                        {
                            case 1://NUEVO
                                miImagen.SetPixel(j, k, colorRojo); break;
                            case 2://LISTO
                                miImagen.SetPixel(j, k, colorAzul); break;
                            case 3://EJECUTANDO
                                miImagen.SetPixel(j, k, colorVerde); break;
                            case 4://BLOQUEADO
                                miImagen.SetPixel(j, k, Color.Yellow); break;
                            case 5://TERMINADO
                                miImagen.SetPixel(j, k, colorNegro); break;

                        }
                        
                    }
                }
                dataGridView1[1, i].Value = miImagen;
            }
          
        }

        public void Planificar()
        {
            Double minArribo = 100;
            Double minBrust = 100;
            int ubicacion = 100;
            int tipoPlan, tipoEsquema;

            cambio = false;
            tipoEsquema = cbEsquema.SelectedIndex;
            tipoPlan = cbPlanificador.SelectedIndex;


            if (tipoPlan==0)//FCFS
            {
                for (int i = 0; i < procesos.Count(); i++)
                {
                    if (minArribo > procesos[i].Arribo && procesos[i].Estado != 5 && procesos[i].Arribo<=tiempo)
                    {
                        minArribo = procesos[i].Arribo;
                        ubicacion = i;
                        cambio = true;
                    }
                }
            }
            if (tipoPlan == 1)//SJF
            {
                for (int i = 0; i < procesos.Count(); i++)
                {
                    //NO EXPROPIATIVO
                    if (tipoEsquema==1 && procesos[i].Ejecutado > 0 && procesos[i].Ejecutado!= procesos[i].Burstime && procesos[i].Estado != 5 && procesos[i].Arribo <= tiempo)
                    {
                        ubicacion = i;
                        cambio = true;
                        break;
                    }else if (tipoEsquema == 1 && procesos[i].Ejecutado == 0 && procesos[i].Estado != 5 && procesos[i].Arribo <= tiempo)
                    {
                        if (minArribo > procesos[i].Burstime)
                        {
                            minArribo = procesos[i].Burstime;
                            ubicacion = i;
                            cambio = true;
                        }
                    }
                    //EXPROPIATIVO
                    if (tipoEsquema==0 && minArribo > procesos[i].Burstime && procesos[i].Estado != 5 && procesos[i].Arribo <= tiempo)
                    {
                        minArribo = procesos[i].Burstime;
                        
                        ubicacion = i;
                        cambio = true;
                    }
                }
            }

            if (tipoPlan == 2)//ROUND ROBIN - SIEMPRE ES EXPROPIATIVO
            {
                if (contRR ==Int32.Parse(txtQuantum2.Text) || contRR==procesos[ubiRR].Burstime) //Completo un quantum
                {
                    contRR = 0;//Inicializando el quantum
                    int ubiProcesoToca = getUbiRR(ubiRR); //Hallando el de menor arribo
                    if (ubiProcesoToca != -1)
                    {
                        ubiRR = ubiProcesoToca;
                        ubicacion = ubiProcesoToca;
                        cambio = true;
                    }
                }
                else if(procesos[ubiRR].Estado != 5)
                {
                    ubicacion = ubiRR;
                    cambio = true;
                }
            }

            if (cambio)
            {
                ubiProcesoElegido = ubicacion;
            }
            
        }
        public int getUbiRR(int ubiRRs)
        {
            int resultado = -1,
                ubi= 100;
            List<Proceso> procesoSort = new List<Proceso>();

            procesoSort = procesos;

            procesoSort = procesoSort.OrderBy(x=>x.Arribo).ToList();

            if (ubiRRs+1 == procesoSort.Count()) //Si llego al limite de los procesos vuelve al inicio
            {
                ubiRRs = -1; 
            }
            for (int i = ubiRRs+1; i< procesoSort.Count();i++)
            {
                if (procesoSort[i].Estado != 5 && procesoSort[i].Arribo <= tiempo)
                {
                    ubi = i;break;
                }
            }

            if (ubi == 100)
            {
                return resultado;
            }
            else
            {
                return ubi;
            }
          
        }

        public void buscaMemoriaVacias()
        {
            
            int miInicio=0;
            int miFinal = 0;
            int ocupado = 1;

            if (_arregloMemoriaVac.Count()==0)
            {
                List<int> arrInicio = new List<int>();
                arrInicio.Add(0);
                arrInicio.Add(_tamMemoria - 1);
                arrInicio.Add(_tamMemoria);
                arrInicio.Add(-1);
                _arregloMemoriaVac.Add(arrInicio);
                return;
            }
            
            for (int i = 0; i<_tamMemoria; i++)
            {
                if (_memoria[i]==1 ) //1
                {
                    if (ocupado==0)
                    {
                        miFinal = i - 1;
                        ocupado = 1;
                        List<int> espacio = new List<int>();
                        espacio.Add(miInicio); //inicio
                        espacio.Add(miFinal); //final
                        espacio.Add(miFinal - miInicio + 1); //espacio
                        espacio.Add(-1); // el proceso que esta aca
                        _arregloMemoriaVac.Add(espacio);
                    }
                    else
                    {
                        miInicio = i;
                    }
                }else if (_memoria[i] == 0 ) //0
                {
                    if (ocupado == 1)
                    {
                        miInicio = i;
                        ocupado = 0;
                    }
                }

                if (_tamMemoria==i+1)
                {
                    if (ocupado == 0)
                    {
                        if (_memoria[i] == 0)
                        {
                            miFinal = i;
                            ocupado = 1;
                            List<int> espacio = new List<int>();
                            espacio.Add(miInicio); //inicio
                            espacio.Add(miFinal); //final
                            espacio.Add(miFinal - miInicio + 1); //espacio
                            espacio.Add(-1); // el proceso que esta aca
                            _arregloMemoriaVac.Add(espacio);
                        }
                        else
                        {
                            miFinal = i-1;
                            ocupado = 1;
                            List<int> espacio = new List<int>();
                            espacio.Add(miInicio); //inicio
                            espacio.Add(miFinal); //final
                            espacio.Add(miFinal - miInicio + 1); //espacio
                            espacio.Add(-1); // el proceso que esta aca
                            _arregloMemoriaVac.Add(espacio);
                        }
                    }
                    else
                    {

                        if (_memoria[i] == 0)
                        {
                            miFinal = i;
                            ocupado = 1;
                            List<int> espacio = new List<int>();
                            espacio.Add(miInicio); //inicio
                            espacio.Add(miFinal); //final
                            espacio.Add(miFinal - miInicio + 1); //espacio
                            espacio.Add(-1); // el proceso que esta aca
                            _arregloMemoriaVac.Add(espacio);

                        }
                        
                    }
                }
            }
        }
        public Image ejecutaProgreso(Bitmap miImagen, Proceso miProceso, Color color)
        {
            int avance = (int)((miProceso.Ejecutado * 100) / miProceso.Burstime);
            int height = miImagen.Height;

            for (int i = 1; i < avance; i++)
            {
                for (int j = 1; j < height; j++)
                {
                    miImagen.SetPixel(i, j, color);
                }
            }
            return miImagen;
        }

        public void insertarFila(Proceso miProceso)
        {
            Bitmap miImagen = new Bitmap(100, 20);
            Proceso proceso1 = new Proceso(aleatorio.Next(1, 9), 100, aleatorio.Next(100, 400));
           

            object[] row = new object[] {
                miProceso.Pid,
                ejecutaProgreso(miImagen, proceso1,colorAzul),
                miProceso.DesEstado,
                "-",
                miProceso.Instrucciones[0],
                miProceso.Memoria,
                miProceso.Arribo,
                miProceso.Ejecutado,
                miProceso.Burstime,
                "-"
            };
            dataGridView1.Rows.Add(row);

        }


        private void btnIniciarAleatoria_Click(object sender, EventArgs e)
        {
           
            int numProcesos = Int32.Parse(txtNumProcesos.Text);
            for (int i = 0; i < numProcesos; i++)
            {
                Proceso proceso1 = new Proceso(aleatorio.Next(0,5), aleatorio.Next(1, 10), aleatorio.Next(100,400));
                procesos.Add(proceso1);
                insertarFila(proceso1);
            }

            if (cbPlanificador.SelectedIndex == -1)
            {
                cbPlanificador.SelectedIndex = 0;
            }
            if (cbEsquema.SelectedIndex == -1)
            {
                cbEsquema.SelectedIndex = 0;
            }

            /*myTimer.Start();
            btnEjecutar.Enabled = true;
            btnEjecutar.BackColor = colorRojo;
            btnEjecutar.ForeColor = Color.White;*/
        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            int miArribo;
            int tiempoActual = (int)tiempo + 1;
            int memoria ;

            if (txtArribo.Text == "")
            {
                miArribo = tiempoActual;
            }
            else if(txtArribo.Text != "" && Int32.Parse(txtArribo.Text) > tiempoActual-2)
            {
                miArribo = Int32.Parse(txtArribo.Text);
            }
            else
            {
                miArribo = tiempoActual;
            }

            if (txtMemoria.Text=="")
            {
                memoria = 100;
            }
            else
            {
                memoria = Int32.Parse(txtMemoria.Text);
            }

            Proceso proceso1 = new Proceso(miArribo,  Int32.Parse(txtBurstime.Text), memoria);
            procesos.Add(proceso1);



            //Llenado espacios en memoria
           /* buscaMemoriaVacias();
            int espaciollenar = -1;
            for (int i = 0; i<_arregloMemoriaVac.Count();i++)
            {
                if (_arregloMemoriaVac[i][2]>= memoria && _arregloMemoriaVac[i][3]==-1)// First fit
                {
                    espaciollenar = i;
                    _arregloMemoriaVac[i][1] = _arregloMemoriaVac[i][0] + memoria -1; //Dandole el final
                    _arregloMemoriaVac[i][2] = memoria; //Dandole el espacio
                    _arregloMemoriaVac[i][3] = procesos.Count()-1; // El proceso
                    break;
                }
            }

            for (int i= _arregloMemoriaVac[espaciollenar][0];i< _arregloMemoriaVac[espaciollenar][0] + memoria;i++)
            {
                _memoria[i] = 1;
            }
            */

          

            insertarFila(proceso1);
        }

        public void limpiarMemoriaProceso(int idProceso)
        {
            for (int i = 0; i < _arregloMemoriaVac.Count(); i++)
            {
                if (_arregloMemoriaVac[i][3]==idProceso)
                {
                    for (int j = _arregloMemoriaVac[i][0]; j < _arregloMemoriaVac[i][2]; j++)
                    {
                        _memoria[j] = 0;
                    }
                    break;
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            procesos = new List<Proceso>();
            cambio = false;
            ubiAnterior = 100;
            ubiActual = 100;
            ubiProcesoElegido = 0;
            dataGridView1.Rows.Clear();
            tiempo = 0;
            myTimer.Stop();
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.BackColor = Color.Transparent;
            btnEjecutar.ForeColor = Color.Black;
            ubiRR = 0;
            contRR = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnEjecutar.Text == "Detener")
            {
                myTimer.Stop();
                btnEjecutar.Text = "Continuar";
                btnEjecutar.BackColor = colorVerde;
                btnEjecutar.ForeColor = Color.White;
            }
            else if(btnEjecutar.Text == "Ejecutar" || btnEjecutar.Text == "Continuar")
            {
                myTimer.Start();
                btnEjecutar.Text = "Detener";
                btnEjecutar.BackColor = colorRojo;
                btnEjecutar.ForeColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridPcb.Rows.Clear();
            int fila = e.RowIndex;
            dataGridPcb.Rows.Add("PID",procesos[fila].Pid);

            for (int i=0;i<procesos[fila].Instrucciones.Count();i++)
            {
                dataGridPcb.Rows.Add(i.ToString(), procesos[fila].Instrucciones[i]);

                if (i < Math.Truncate(procesos[fila].Ejecutado))
                {
                    dataGridPcb.Rows[i + 1].Cells[1].Style.BackColor = colorVerde;
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


}
