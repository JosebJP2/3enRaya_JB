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
using System.Threading;

namespace _3enRayaJB
{
    public partial class Form2 : Form
    {
        //List<Jugador> listJugadores;
        Jugador jug = new Jugador();
        int wins1 = 0;
        int wins2 = 0;
        bool tf = true; // para verificar el turno de cada jugador
        Image imgJ1;
        Image imgJ2;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Jugador 1
            if (ElegirFruta.FrutaJ1 == "Manzana" )
            {
                imgJ1 = Properties.Resources.Manzana;
            }
            if (ElegirFruta.FrutaJ1 == "Naranja")
            {
                imgJ1 = Properties.Resources.Mandarina;
            }
            if (ElegirFruta.FrutaJ1 == "Limon")
            {
                imgJ1 = Properties.Resources.Limon;
            }
            if (ElegirFruta.FrutaJ1 == "Kiwi")
            {
                imgJ1 = Properties.Resources.Kiwi;
            }

            //Jugador 2 
            if (ElegirFruta.FrutaJ2 == "Manzana")
            {
                imgJ2 = Properties.Resources.Manzana;
            }
            if (ElegirFruta.FrutaJ2 == "Naranja")
            {
                imgJ2 = Properties.Resources.Mandarina;
            }
            if (ElegirFruta.FrutaJ2 == "Limon")
            {
                imgJ2 = Properties.Resources.Limon;
            }
            if (ElegirFruta.FrutaJ2 == "Kiwi")
            {
                imgJ2 = Properties.Resources.Kiwi;
            }

            //señalamos al jugador que fruta ha escogido para recordarselo mientras juega
            pictureJ1.Image = imgJ1;
            pictureJ2.Image = imgJ2;

            //indicamos el turno que sería por orden, es decir, Jugador 1 primero

            turnoJ1.Image = Properties.Resources.ESPADA;
        }
        /// <summary>
        /// Metodo para verificar quien ha ganado la partida y para validar el empate
        /// </summary>
        public void Check()
        {
            // fila 1-2-3
            if (but1.Image == but2.Image && but2.Image == but3.Image && but1.Image != null && but2.Image != null && but3.Image != null) 
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS; // mostramos que jugador ha ganado
                    wins1++; //sumamos 1 punto al marcador individual
                    winsJ1.Text = wins1.ToString(); 
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;

                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
               

            }
            // fila 4-5-6
            else if (but4.Image == but5.Image && but5.Image == but6.Image && but4.Image != null && but5.Image != null && but6.Image != null)
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // fila 7-8-9
            else if (but7.Image == but8.Image && but8.Image == but9.Image && but7.Image != null && but8.Image != null && but9.Image != null) 
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // columna 1-4-7
            else if (but1.Image == but4.Image && but4.Image == but7.Image && but1.Image != null && but4.Image != null && but7.Image != null)
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // columna 2-5-8
            else if (but2.Image == but5.Image && but5.Image == but8.Image && but2.Image != null && but5.Image != null && but8.Image != null)
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // columna 3-6-9
            else if (but3.Image == but6.Image && but6.Image == but9.Image && but3.Image != null && but6.Image != null && but9.Image != null)
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // cruz 1-5-9
            else if (but1.Image == but5.Image && but5.Image == but9.Image && but1.Image != null && but5.Image != null && but9.Image != null) 
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // cruz 3-5-7
            else if (but3.Image == but5.Image && but5.Image == but7.Image && but3.Image != null && but5.Image != null && but7.Image != null)
            {
                if (turnoJ1.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J1WINS;
                    wins1++;
                    winsJ1.Text = wins1.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }
                if (turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = Properties.Resources.J2WINS;
                    wins2++;
                    winsJ2.Text = wins2.ToString();
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                }

            }
            // EMPATE
            else if (but1.Image != null && but2.Image != null && but3.Image != null && but4.Image != null && but5.Image != null && but6.Image != null && but7.Image != null && but8.Image != null && but9.Image != null) 
            {
                if (turnoJ1.Visible == false || turnoJ2.Visible == false)
                {
                    Thread.Sleep(150);
                    Winner.Image = null;
                    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                    Winner.Image = Properties.Resources.empate;

                }
                //if (turnoJ2.Visible == false)
                //{
                //    Winner.Image = null;
                //    but1.Image = null; but2.Image = null; but3.Image = null; but4.Image = null; but5.Image = null; but6.Image = null; but7.Image = null; but8.Image = null; but9.Image = null;
                //    click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
                //    Winner.Image = Properties.Resources.empate;
                //}

            }



        }
        /// <summary>
        /// Metodo para cambiar imagenes a la hora de clickar en el tablero del 3enRaya
        /// </summary>
        /// <param name="change"></param>
        public void CambiarImagen(PictureBox change) 
        {
            if (tf == true)
            {
                change.Image = imgJ1; // cambiar imagen de la ficha del jugador en el picturebox donde se haga click (JUGADOR 1)
                tf = false;

                turnoJ2.Visible = true;
                turnoJ2.Image = Properties.Resources.ESPADA; // Habilitamos el turno del jugador 2 ya que pasó el turno del 1
                turnoJ1.Visible = false; // deshabilitamos turno del jugador 1

            }
            else
            {
                change.Image = imgJ2;  // cambiar imagen de la ficha del jugador en el picturebox donde se haga click (JUGADOR 1)
                tf = true;

                turnoJ1.Visible = true;
                turnoJ1.Image = Properties.Resources.ESPADA;  // Habilitamos el turno del jugador 1
                turnoJ2.Visible = false; // deshabilitamos turno del jugador 2

            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                CambiarImagen(but1);
                click1++;
                Check();
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                CambiarImagen(but2);
                click2++;
                Check();
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                CambiarImagen(but3);
                click3++;
                Check();
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                CambiarImagen(but4);
                click4++;
                Check();
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                CambiarImagen(but5);
                click5++;
                Check();
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                CambiarImagen(but6);
                click6++;
                Check();
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                CambiarImagen(but7);
                click7++;
                Check();
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                CambiarImagen(but8);
                click8++;
                Check();
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                CambiarImagen(but9);
                click9++;
                Check();
            }
        }
        /// <summary>
        /// Boton para ir a la selección de frutas y crear una partida nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newBoton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        /// <summary>
        /// Boton para salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBoton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

    }
}
