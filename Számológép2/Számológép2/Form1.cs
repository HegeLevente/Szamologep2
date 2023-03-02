using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Számológép2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int szam1;
        int szam2;
        string behoz;
        char muvelet;
        int vegeredmeny;
        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            behoz += "1";
            
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2"; 
            behoz += "2";
           
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            behoz+= "3";
            
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            behoz += "4";
            
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            behoz += "5";
            
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            behoz += "6";
            
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            behoz += "7";
            
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            behoz += "8";
            
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            behoz += "9";
            
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            behoz += "0";
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            szam1 = Convert.ToInt32(behoz);
            muvelet = '+';
            behoz = "";
        }

        private void minusz_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            szam1 = Convert.ToInt32(behoz);
            muvelet = '-';
            behoz = "";
        }

        private void szorzas_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            szam1 = Convert.ToInt32(behoz);
            muvelet = '*';
            behoz = "";
        }

        private void osztas_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            szam1 = Convert.ToInt32(behoz);
            muvelet = '/';
            behoz = "";
        }

        private void eredmeny_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "=";
            szam2 = Convert.ToInt32(behoz);
            if (muvelet=='+')
            {
                vegeredmeny = szam1 + szam2;
            }
            if (muvelet == '-')
            {
                vegeredmeny = szam1 - szam2;
            }
            if (muvelet == '*')
            {
                vegeredmeny = szam1 * szam2;
            }
            if (muvelet == '/')
            {
                if (szam2 == 0)
                {
                    MessageBox.Show("0-val nem lehet osztani");
                }
                else
                {
                    vegeredmeny = szam1 / szam2;
                }
                
            }
            textBox1.Text = textBox1.Text + vegeredmeny;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            szam1 = 0;
            szam2 = 0;
            behoz = "";
        }
    }
}
