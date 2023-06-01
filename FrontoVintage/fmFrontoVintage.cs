using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontoVintage
{
    public partial class fmFrontoVintage : Form
    {
        //Constants
        List<clBoles> llBoles = new List<clBoles>();
        clPala pala = null;


        //Int32 x = 0;
        //Int32 y = 0;

        Int32 nRebots = 0;
        Int32 nXocs = 0;

        
        public fmFrontoVintage()
        {
            InitializeComponent();
        }

        private void fmFrontoVintage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Escape)
            {
                //Aqui farem que es tanqui el programa
                this.Close();
            }
            if(e.KeyChar == (Char)Keys.L)
            {
                llBoles.Add(new clBoles(this,pala));
                llBoles[llBoles.Count - 1].heRebotat += new EventHandler(unRebotMes);
                llBoles[llBoles.Count - 1].heXocat += new EventHandler(unXocMes);
            }
        }

        public void fmFrontoVintage_MouseMove(object sender, MouseEventArgs e)
        {
            pala.mourepala(e.X,e.Y);
        }

        public void fmFrontoVintage_Load(object sender, EventArgs e)
        {
            pala = new clPala(this);

        }

        private void unRebotMes(object sender, EventArgs e)
        {
            nRebots++;
            lbRebots.Text = "Rebots: " + nRebots.ToString();
        }

        private void unXocMes(object sender, EventArgs e)
        {
            nXocs++;
            lbXocs.Text = "Xocs: " + nXocs.ToString();
        }




    }
}
