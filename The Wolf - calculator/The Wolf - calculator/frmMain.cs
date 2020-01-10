using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Wolf___calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;

            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            answer = operand1 / operand2;
            txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() +
                                " equals " + answer.ToString();
            txtResult.Visible = true;
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtOperand1.Clear();
            txtOperand2.Clear();
            txtResult.Clear();
        }
    }
}
