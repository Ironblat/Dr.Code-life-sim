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

namespace _3.ora
{
    public partial class Form1 : Form
    {
        int penztarca;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string nev = nev_tb.Text;

            if (nev == "pizza")
            {   
                Fuggveny(450);
            }
            else if (nev == "hamburger")
            {                   
                Fuggveny(750);
            }
            else if (nev == "kóla")
            {                   
                Fuggveny(650);
            }
            else if (nev == "popcorn")
            {  
                Fuggveny(100);
            }
            else if (nev == "salata")
            {
                Fuggveny(1000);
            }
            else if (nev == "villanyszamla")
            {
                Fuggveny(100000000);
            }
            
                
                penzosszeg_tb.Text = penztarca.ToString();
            
            
        }

        private void menu_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void work_btn_Click(object sender, EventArgs e)
        {
            

            if (penzosszeg_tb.Text != "") 
            { 
                penztarca = int.Parse(penzosszeg_tb.Text);
            
            }

            int Munkaora = workh_TB.Value;
            penztarca += Munkaora * 1500;
            for (int i = 0; i < 100; i++) 
            {
                Time_PB.Value = i;
                progressbar_lbl.Text = i.ToString();
                Thread.Sleep(10 * Munkaora);

            }
            penzosszeg_tb.Text = penztarca.ToString();
            progressbar_lbl.Text = "A munkának vége!";
            Thread.Sleep(1000);
            Time_PB.Value = 0;
            workh_TB.Value = 0;
        }

        private void workh_TB_Scroll(object sender, EventArgs e)
        {
            trackbarvalue_lbl.Text = workh_TB.Value.ToString();
        }

        private void Time_PB_Click(object sender, EventArgs e)
        {

        }

        public void Fuggveny(int ar)
        {
            if (penztarca >= ar)
            {
                penztarca -= ar;
                visszajaro_lbl.Text = penztarca.ToString();

            }
            else
            {
                visszajaro_lbl.Text = "Túl csóró vagy ehez";
            }
        }
    }
}
