using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;

namespace FrontoVintage
{
    internal class clBoles
    {
        //Constants
        const Int32 MIDA_MIN = 30;
        const Int32 MIDA_MAX = 100;
        Color[] vColors = { Color.Yellow, Color.Blue, Color.Red, Color.Green };


        //Propietats
        Panel pnl = null;
        Form fMain = null;
        Color colorPanell = Color.Empty;
        Size mida = Size.Empty;
        System.Windows.Forms.Timer tmMoviment = null;
        Int32 dx = 10;
        Int32 dy = 10;
        clPala pala = null;

        //Events
        public event EventHandler heRebotat;
        public event EventHandler heXocat;


        //Primer constructor
        public clBoles(Form xfMain, clPala xpala)
        {
            Random R = new Random();
            fMain = xfMain;

            pala = xpala;

            pnl = new Panel();
            Int32 m = R.Next(MIDA_MIN, MIDA_MAX + 1);
            pnl.Size = new Size(m, m);
            mida = pnl.Size;
            //pnl.BackColor = vColors[R.Next(0,vColors.Length)];
            //colorPanell = pnl.BackColor;

            pnl.BackColor = Color.Empty;
            colorPanell = vColors[R.Next(0, vColors.Length)];




            Int32 x = R.Next(0, fMain.Width - pnl.Width);
            Int32 y = R.Next(0, fMain.Height - pnl.Height);
            pnl.Location = new Point(x, y);



            pnl.Paint += new PaintEventHandler(pintarBola);

            iniTimer();

            fMain.Controls.Add(pnl);
        }

        private void pintarBola(object sender, PaintEventArgs e)
        {
            Graphics g = pnl.CreateGraphics();

            g.FillEllipse(new SolidBrush(colorPanell), new Rectangle(0, 0, mida.Width, mida.Height));
        }

        private void mouElPanell(object sender, EventArgs e)
        {
            //object sender, EventArgs e
            Int32 x = pnl.Left + dx;
            Int32 y = pnl.Top + dy;



            if (x < 0)
            {
                x = 0;
                dx = -dx;
                heRebotat(sender, EventArgs.Empty);
            }
            else if (x > fMain.Width - pnl.Width)
            {
                x = fMain.Width - pnl.Width;
                dx = -dx;
                heRebotat(sender, EventArgs.Empty);
            }

            if (y < 0)
            {
                y = 0;
                dy = -dy;
                heRebotat(sender, EventArgs.Empty);
            }
            else if (y > fMain.Height - pnl.Height)
            {
                y = fMain.Height - pnl.Height;
                dy = -dy;
                heRebotat(sender, EventArgs.Empty);
            }

            pnl.Location = new Point(x, y);

            if (xocoAmbLaPala())
            {
                if (pala.obtenirPanell().Location.X > pnl.Location.X)
                {
                    //Bola dreta, Panell esquerra
                    x = pala.obtenirPanell().Location.X + pnl.Width / 2;
                }
                if (pala.obtenirPanell().Location.X < pnl.Location.X)
                {
                    //Panell dreta, Bola esquerra
                    x = pala.obtenirPanell().Location.X - pnl.Width / 2;
                }
                dx = -dx;
                heXocat(sender, EventArgs.Empty);
            }

                
        }

    

        private Boolean xocoAmbLaPala()
        {
            return (pnl.Bounds.IntersectsWith(pala.obtenirPanell().Bounds));
        }

        private void iniTimer()
        {
            tmMoviment = new System.Windows.Forms.Timer();

            tmMoviment.Interval = 20;
            //tmMoviment.Tick += new EventHandler(mouElPanell);
            tmMoviment.Tick += delegate (object sender, EventArgs e) { mouElPanell(sender, e); };


            tmMoviment.Start();
        }

        

        
    }
}
