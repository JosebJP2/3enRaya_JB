using LogicaApp;
using Jugadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3enRayaJB
{
    public partial class ElegirFruta : Form
    {
        public static string FrutaJ1;
        public static string FrutaJ2;

        List<Jugador> listJugadores;
        Jugador jug = new Jugador();
        LogicaInterfaz LI;
        int pos;
        int clickL = 0, clickM = 0, clickK = 0, clickN = 0, click = 1;

        public ElegirFruta()
        {
            listJugadores = new List<Jugador>();
            pos = 0;
            LI = new LogicaInterfaz();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listJugadores.Add(new Jugador(1, "Jugador 1"));
            listJugadores.Add(new Jugador(2, "Jugador 2"));

        }

        public Form activeForm = null;
        public void openChildForm(Form childForm) //metodo para abrir multiples forms en una misma ventana
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(childForm);
            pPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void manzana_Click(object sender, EventArgs e)
        {
            clickM++;
            if (click <= 2)
            {
                if (click == 2 &&  clickM ==1)
                {
                    Start.Image = Properties.Resources.StarColor;
                }
                manzana.Enabled = false;
                if (clickM == 1)
                {
                    if (click == 1)
                    {
                        FrutaJ1 = "Manzana";
                    }
                    if (click == 2)
                    {
                        FrutaJ2 = "Manzana";
                    }

                    click++;
                    LI.EfectoPulsacion(manzana, Properties.Resources.Manzana, Properties.Resources.ManzanaS);

                }
                manzana.Image = Properties.Resources.manSeleccionada;
                numJugador.Text = listJugadores[pos + 1].MostrarNum();
            }
        }

        private void naranja_Click(object sender, EventArgs e)
        {
            clickN++;
            if (click <= 2)
            {
                if (click == 2 && clickN == 1)  
                {
                    Start.Image = Properties.Resources.StarColor;
                }
                naranja.Enabled = false;

                if (clickN == 1)
                {
                    if (click == 1)
                    {
                        FrutaJ1 = "Naranja";
                    }
                    if (click == 2)
                    {
                        FrutaJ2 = "Naranja";
                    }

                    click++;
                    LI.EfectoPulsacion(naranja, Properties.Resources.Mandarina, Properties.Resources.MandarinaS);

                }
                naranja.Image = Properties.Resources.narSeleccionada;
                numJugador.Text = listJugadores[pos + 1].MostrarNum();

            }

        }
        private void limon_Click(object sender, EventArgs e)
        {
            clickL++;
            if (click <= 2)
            {
                if (click == 2 && clickL == 1) 
                {
                    Start.Image = Properties.Resources.StarColor;
                }
                limon.Enabled = false;

                if (clickL == 1)
                {
                    if (click == 1)
                    {
                        FrutaJ1 = "Limon";
                    }
                    if (click == 2)
                    {
                        FrutaJ2 = "Limon";
                    }

                    click++;
                    LI.EfectoPulsacion(limon, Properties.Resources.Limon, Properties.Resources.LimonS);
                }
                limon.Image = Properties.Resources.limSeleccionado;
                numJugador.Text = listJugadores[pos + 1].MostrarNum();
            }
        }

        private void kiwi_Click(object sender, EventArgs e)
        {
            clickK++;
            if (click <= 2)
            {
                if (click == 2 && clickK == 1) 
                {
                    Start.Image = Properties.Resources.StarColor;
                }
                kiwi.Enabled = false;

                if (clickK == 1)
                {
                    if (click == 1)
                    {
                        FrutaJ1 = "Kiwi";
                    }
                    if (click == 2)
                    {
                        FrutaJ2 = "Kiwi";
                    }

                    click++;
                    LI.EfectoPulsacion(kiwi, Properties.Resources.Kiwi, Properties.Resources.KiwiS);

                }
                kiwi.Image = Properties.Resources.kiwSeleccinada;
                numJugador.Text = listJugadores[pos + 1].MostrarNum();
            }
        }

        //Start vamos al form para empezar a jugar después de la selección de frutas
        private void Start_Click(object sender, EventArgs e)
        {
            if (click > 2)
            {
                LI.EfectoPulsacion(Start, Properties.Resources.StarColor, Properties.Resources.Pulsado);
                pPrincipal.BringToFront();
                //ElegirFruta lobby = new ElegirFruta();               
                openChildForm(new Form2());
            }

        }

        private void numJugador_Click(object sender, EventArgs e)
        {

        }


    }
}
