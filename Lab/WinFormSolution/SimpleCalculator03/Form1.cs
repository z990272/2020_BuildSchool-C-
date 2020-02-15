using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator(false);
        }

        private void Calculator(bool a)
        {
            _data.X = int.Parse(textBox1.Text);
            _data.Y = int.Parse(textBox2.Text);

            //if (a != true)
            //    _data.Y = -_data.Y;
            //label1.Text = _data.Add().ToString();

            if(a)
                label1.Text = _data.Add().ToString();
            else
                label1.Text = _data.Less().ToString();
        }
    }
}
