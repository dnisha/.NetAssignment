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
    public partial class Form1 : Form
    {
        String[] tataRed = { "mode1", "model2" };
        String[] tataSilver = { "mode1", "model2", "model3" };
        String[] tataMaroon = { "mode1", "model2" };
        String[] NissanRed = { "mode1", "model2", "model3" };
        String[] NissanSilver = { "mode1", "model2" };
        String[] NissanMaroon = { "mode1", "model2", "model3" };
        String[] HyundaiRed = { "mode1", "model2", "model3", "model4" };
        String[] HyundaiSilver = { "mode1", "model2", "model3" };
        String[] HyundaiMaroon = { "mode1", "model2", "model3", "model4" };
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // String color = cbx_color.SelectedItem.ToString();
            // txt_price.Text = color;

            if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "150000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "300000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "200000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "200000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "250000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "400000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "450000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "460000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "460000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "600000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "600000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "650000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "1650000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "1600000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "1700000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "800000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "700000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "850000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Red" && list_model.SelectedIndex == 3)
            {
                txt_price.Text = "800000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "850000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "950000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Silver" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "850000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 0)
            {
                txt_price.Text = "70000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 1)
            {
                txt_price.Text = "75000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 2)
            {
                txt_price.Text = "90000";
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Maroon" && list_model.SelectedIndex == 3)
            {
                txt_price.Text = "100000";
            }
        }

        private void cbx_car_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Red
Silver
Maroon
            */
        
            if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString()== "Red")
            {
                list_model.Items.Clear();
                foreach (String s in tataRed)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Silver")
            {
                list_model.Items.Clear();
                foreach (String s in tataSilver)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Tata Nexon" && cbx_color.SelectedItem.ToString() == "Maroon")
            {
                list_model.Items.Clear();
                foreach (String s in tataMaroon)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Red")
            {
                list_model.Items.Clear();
                foreach (String s in NissanRed)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Silver")
            {
                list_model.Items.Clear();
                foreach (String s in NissanSilver)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Nissan Magnite" && cbx_color.SelectedItem.ToString() == "Maroon")
            {
                list_model.Items.Clear();
                foreach (String s in NissanMaroon)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Red")
            {
                list_model.Items.Clear();
                foreach (String s in HyundaiRed)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Silver")
            {
                list_model.Items.Clear();
                foreach (String s in HyundaiSilver)
                    list_model.Items.Add(s);
            }
            else if (cbx_car.SelectedItem.ToString() == "Hyundai Verna" && cbx_color.SelectedItem.ToString() == "Maroon")
            {
                list_model.Items.Clear();
                foreach (String s in HyundaiMaroon)
                    list_model.Items.Add(s);
            }

        }

        private void list_model_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
