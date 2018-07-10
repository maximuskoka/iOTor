using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b, c, z;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(textBox1.Text);
            double second_nuber = Convert.ToDouble(textBox2.Text);
            double amount = first_number + second_nuber;
            label1.Text = amount.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(textBox1.Text);
            double second_nuber = Convert.ToDouble(textBox2.Text);
            double subtraction = first_number - second_nuber;
           label1.Text = subtraction.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(textBox1.Text);
            double second_nuber = Convert.ToDouble(textBox2.Text);
            double multiplication = first_number * second_nuber;
            label1.Text = multiplication.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(textBox1.Text);
            double second_nuber = Convert.ToDouble(textBox2.Text);
            double division = first_number / second_nuber;
            label1.Text = division.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label1.Text = string.Empty;
            
        }
    }
}
