using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontoVintage
{
    internal class clPala
    {
        //Constants
        Int32 HEIGHT_PALA = 135;
        Int32 WIDHT_PALA = 25;

        

        Panel pnPala;
        Form fMain;
        Size mida = Size.Empty;
        Color colorPanell = Color.Empty;


        //Events
        

        public clPala(Form xfMain)
        {
            Random R = new Random();
            fMain = xfMain;

            pnPala = new Panel();
            
            pnPala.Size = new Size(WIDHT_PALA, HEIGHT_PALA);
            mida = pnPala.Size;
            

            pnPala.BackColor = Color.Red;
            colorPanell = pnPala.BackColor;

            Int32 x = (fMain.Width - pnPala.Width)/2;
            Int32 y = (fMain.Height - pnPala.Height)/2;
            pnPala.Location = new Point(x, y);

            fMain.Controls.Add(pnPala);
        }

        private void pintarPala(object sender, PaintEventArgs e)
        {
            Graphics g = pnPala.CreateGraphics();

            g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, mida.Width, mida.Height));
        }

        public void mourepala(Int32 x, Int32 y)
        {
            //Aqui hem de fer per que el ratoli estigui sempre al mig del panell
            pnPala.Location = new Point(x - pnPala.Width / 2, y - pnPala.Height / 2);
        }

        public Panel obtenirPanell()
        {
            return (pnPala);
        }
    }

    
}
