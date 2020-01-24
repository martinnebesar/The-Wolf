using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_and_convetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = 0;
            if (radioButton1.Checked == true) // addition
            {
                result = num1 + num2;
            }
             else if (radioButton2.Checked == true) // substraction
            { 
                result = num1 - num2;
            }
            else if (radioButton3.Checked == true) // multipication
            {
                result = num1 * num2;
            }
            else if (radioButton4.Checked == true) // division
            { 
                result = num1 / num2;
            }
            textBox3.Text = result.ToString();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if
        }
    }
}
