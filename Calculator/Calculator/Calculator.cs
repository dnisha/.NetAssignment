using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
      
        double x1,x2,x3,x4,ans, y;
        public Calculator()
        {
            InitializeComponent();
            


        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            txt_num.Text += button11.Text;
           
        }

        private void button12_Click(object sender, EventArgs e)
        {


            txt_num.Text += button12.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x1 = 0;
           
            x1 =Convert.ToDouble( txt_num.Text);
            txt_num.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txt_num.Text);
         
            if(x1 != 0)
            {
                 ans = x1 + y;
               
            }
            else if (x2 != 0)
            {
                 ans = x2 - y;
                
            }
            else if(x3 != 0)
            {
                 ans = x3 * y;
            }
            else
            {
                ans = x4 / y;
            }

            
            
           
       
            txt_num.Text = ans.ToString();
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            y = 0;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_num.Text += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_num.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_num.Text += button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_num.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_num.Text += button1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_num.Text += button15.Text; 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_num.Text += button16.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_num.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_num.Text = button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x2 = 0;
           
            x2 = Convert.ToDouble(txt_num.Text);
            txt_num.Text = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x3 = 0;
           
            x3 = Convert.ToDouble(txt_num.Text);
            txt_num.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x4 = 0;
            x4 = Convert.ToDouble(txt_num.Text);
            txt_num.Text = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            y=0;
            ans = 0;
            txt_num.Text = null;
        }
    }
}
