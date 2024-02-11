using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OperS_lab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "Пришел";
            textBox2.Text = "Ушел";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "Ушел";
            textBox2.Text = "Пришел";

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
