

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_mangement_system
{
    public partial class CASHIER : Form
    {
        public CASHIER()
        {
            InitializeComponent();
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void slide(Button button)
        {
            panelslide4.BackColor = Color.White;
            panelslide4.Height = button.Height;
            panelslide4.Top = button.Top;
        }

        private void logoutbutton6_Click(object sender, EventArgs e)
        {
            slide(logoutbutton6);
        }

        private void prdbutton2_Click(object sender, EventArgs e)
        {
            slide(prdbutton2);
        }

        private void disbutton3_Click(object sender, EventArgs e)
        {
            slide(disbutton3);
        }

        private void paybutton4_Click(object sender, EventArgs e)
        {
            slide(paybutton4);

        }

        private void clrbutton5_Click(object sender, EventArgs e)
        {
            slide(clrbutton5);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CASHIER_Load(object sender, EventArgs e)
        {

        }
    }
}
