﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textboxop1.Text);
                int op2Number = int.Parse(this.textboxop2.Text);
                int result = op1Number + op2Number;
                this.labelresult.Text = result.ToString();
            }
            catch( Exception ex)
            {

            }
        }
    }
}
