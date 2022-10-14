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
        int napokszama = 1;
        int ehseg = 100;
       
        
        

        public Form1()
        {
            InitializeComponent();
            hunger_PB.Value = ehseg;
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
                Eves(40);
            }
            else if (nev == "hamburger")
            {                   
                Fuggveny(750);
                Eves(50);
            }
            else if (nev == "kóla")
            {                   
                Fuggveny(650);
            }
            else if (nev == "popcorn")
            {  
                Fuggveny(100);
                Eves(4);
            }
            else if (nev == "salata")
            {
                Fuggveny(1000);
                Eves(3);

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
                Thread.Sleep(10 * Munkaora);

            }
            penzosszeg_tb.Text = penztarca.ToString();
            progressbar_lbl.Text = "A munkának vége!";
            
            if (workh_TB.Value == 24)
            {
                napokszama++;
                day_count_tb.Text = (napokszama).ToString();
                
            }
            ehseg -= 2 * Munkaora;
            hunger_PB.Value = ehseg;

            Thread.Sleep(1000);
            Time_PB.Value = 0;
            workh_TB.Value = 0;
            trackbarvalue_lbl.Text = "0";
            


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

        public void Eves(int telitetseg)
        {
            ehseg += telitetseg;
            if(ehseg > 100)
            {
                ehseg = 100;
            }
            hunger_PB.Value = ehseg;
        }

        private void day_btn_Click(object sender, EventArgs e)
        {
            napokszama++;
            day_count_tb.Text = (napokszama ).ToString();
            ehseg -= 30;
            Halal();
            hunger_PB.Value = ehseg;
        }

        public void Halal()
        {
            if(ehseg <= 0)
            {
             MessageBox.Show("Meghaltál!\n Éltél "+napokszama.ToString()+" napot");
                ehseg = 0;
                hunger_PB.Value = 0;
                ok_btn.Enabled = false;
                day_btn.Enabled = false;
                work_btn.Enabled = false;
                workh_TB.Enabled = false;
                nev_tb.Enabled = false;
                revive_btn.Visible = true;
                workh_TB.Value = 0;
                trackbarvalue_lbl.Text = "0"; 
                progressbar_lbl.Text = "";
            }
            
        }

        private void revive_btn_Click(object sender, EventArgs e)
        {
            ehseg = 100;
            hunger_PB.Value = ehseg;
            penztarca = 0;
            penzosszeg_tb.Text = "0";
            ok_btn.Enabled = true;
            day_btn.Enabled = true;
            work_btn.Enabled = true;
            workh_TB.Enabled = true;
            nev_tb.Enabled = true;
            revive_btn.Visible = false;
            visszajaro_lbl.Text = "0";
            nev_tb.Text = "";
            napokszama = 0;
            day_count_tb.Text = (napokszama).ToString();
        }
    }
}
