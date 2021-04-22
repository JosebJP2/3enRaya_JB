using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jugadores
{
    class Jugador
    {
        private double num;
        private string nom;
        //public string FrutaJ1;
        //public string FrutaJ2;

        public Jugador()
        {

        }
        public Jugador(double num, string nom)
        {
            this.num = num;
            this.nom = nom;           
        }

        public double Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }

        public string MostrarNum()
        {
            return num.ToString();
        }

        public string MostarNom()
        {
            return nom;
        }
    }
}
