using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator(1);
        }

       private void button2_Click_1(object sender, EventArgs e)
        {
            Calculator(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Calculator(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator(4);
        }

        private void Calculator(int a)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            if (a == 1)
                label1.Text = (x + y).ToString();
            else if (a == 2)
                label1.Text = (x - y).ToString();
            else if (a == 3)
                label1.Text = (x * y).ToString();
            else
                label1.Text = (x / y).ToString();
        }

        
    }
}
