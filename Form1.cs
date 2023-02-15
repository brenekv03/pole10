﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            int[] pole = new int[n];
            for(int i=0; i<n; i++) 
            {
                int cislo  = rnd.Next(1,11);
                pole[i] = cislo;
            }
            foreach(int i in pole) { listBox1.Items.Add(i); }
            Array.Sort(pole);
            if (!radioButton1.Checked)
            {
                Array.Reverse(pole);
            }
            foreach (int i in pole) { listBox2.Items.Add(i); }
        }
    }
}
