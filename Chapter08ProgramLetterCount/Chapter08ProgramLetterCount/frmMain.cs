﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramLetterCount
{
    public partial class frmMain : Form
    {
        private const int MAXLETTERS = 26;          // Symbolic constant
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;

            length = txtInput.Text.Length;
            if (length == 0)    // Anything to count??
            {
                MessageBox.Show("You need to enter some text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();

            for (i = 0; i < input.Length; i++)      // Examine all letters.
            {
                oneLetter = input[i];               // Get a character
                index = oneLetter - LETTERA;        // Make into an index
                if (index < 0 || index > MAXCHARS)  // A leterr??
                    continue;                       // Nope.
                count[index]++;                     // Yep.
            }
            for (i = 0; i < MAXLETTERS; i++)
            {
                buff = string.Format("{0, 4} {1, 20} [{2}]", (char) (i + LETTERA), " ", count[i]);
                lstOutput.Items.Add(buff);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}