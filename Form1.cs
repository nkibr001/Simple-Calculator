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
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            //  textBox1.Text += "=";

            DataTable dt = new DataTable();

            var v = new object();
            try
            {
                v = dt.Compute(textBox1.Text, "");
            }
            catch (Exception ex)
            {
                v = "NaN";
            }

            textBox1.Text += " = " + v;
        }
        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void open_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void close_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void dec_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
