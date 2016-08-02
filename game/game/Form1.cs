using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuvash_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSuvash.Text = "China";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMansoor.Text = "Canada";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSamuel.Text = "Usa";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtComplete.Text = "good";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtComplete.Text = " ";
            txtMansoor.Text = " ";
            txtSamuel.Text = " ";
            txtSuvash.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
