using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogicaApp
{
    class LogicaInterfaz
    {
        public void EfectoPulsacion(PictureBox pic, Bitmap picOriginal, Bitmap picPulsado)
        {
            pic.Enabled = false;
            pic.Image = picPulsado;
            pic.Location = new Point(pic.Location.X + 5, pic.Location.Y + 5);
            pic.Size = new Size(pic.Width - 5, pic.Height - 5);

            //Con esta instrucción forzamos que se refresquen los cambios en el interfaz gráfico
            Application.DoEvents();
            Thread.Sleep(150);

            pic.Image = picOriginal;
            pic.Location = new Point(pic.Location.X - 5, pic.Location.Y - 5);
            pic.Size = new Size(pic.Width + 5, pic.Height + 5);
            pic.Enabled = true;
        }

        public void EfectoPulsacion(PictureBox pic)
        {
            pic.Enabled = false;
            pic.Location = new Point(pic.Location.X + 10, pic.Location.Y + 10);
            pic.Size = new Size(pic.Width - 10, pic.Height - 10);

            //Con esta instrucción forzamos que se refresquen los cambios en el interfaz gráfico
            Application.DoEvents();
            Thread.Sleep(150);

            pic.Location = new Point(pic.Location.X - 10, pic.Location.Y - 10);
            pic.Size = new Size(pic.Width + 10, pic.Height + 10);
            pic.Enabled = true;
        }
    }
}

