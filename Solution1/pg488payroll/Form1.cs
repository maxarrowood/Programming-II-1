﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pg488payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intHours = new int[intMax_EMPLOYEES];

            int intCount = 0;
            int intEmpHours = 0;
            decimal decEmpPay = 0.0m;

            for (intCount = 0; intCount < intMAX_EMPLOYEES; intCount++) {
                while(int.TryParse(
                    Interaction.InputBox("Enter # of hours worked by employee #" +
                    (intCount+1).ToString*(), "Need Hours Worked"),
                    out intEmpHours) == false) {
                        MessageBox.Show("Please Enter an integer for hours worked");
                }
                intHours[intCount] = intEmpHours;
            }

            listBox1.Items.Clear();
            for (intCount = 0; intCount < intMAX_EMPLOYEES; intCount++) {
                decEmpPay = intHours[intCount] * decHOURLY_PAY_RATE;
                listBox1.Items.Add("Employee " + (intCount + 1).ToString() +
                    " earned " + decEmpPay.ToString("$.00"));
            }
        }
    }
}
