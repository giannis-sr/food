using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace food
{
    public partial class Form1 : Form
    {
        double subTotal = 0;
        int choice;
        float price;
        
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = subTotal.ToString();

            double tx = subTotal * 0.15;
            textBox2.Text = tx.ToString();

            double sum = tx + subTotal;
            textBox3.Text = sum.ToString();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            subTotal = 5;
            uncheckAll();
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            subTotal = 10;
            uncheckAll();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            subTotal = 4.5;
            uncheckAll();
        }

        public void uncheckAll()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                subTotal += 0.70;
            }
            else if (!checkBox1.Checked)
            {
                subTotal -= 0.70;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                subTotal += 0.70;
            }
            else if (!checkBox2.Checked)
            {
                subTotal -= 0.70;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                subTotal += 0.70;
            }
            else if (!checkBox3.Checked)
            {
                subTotal -= 0.70;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
