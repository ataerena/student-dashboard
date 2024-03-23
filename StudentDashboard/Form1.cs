using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "ŞİNANAY DA YAVRUM ŞİNAŞİNANAY")
            {
                MessageBox.Show("OROSPU ÇOCUĞU GALATASARAY");
            }
        }
    }
}
