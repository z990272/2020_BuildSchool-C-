using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            count(input);
        }

        private void count(string input)
        {
            int year = int.Parse(input);
            int sat = 0, sun = 0;

            for (int m = 1; m <= 12; m++)
            {
                DateTime date = new DateTime(year, m, 01);

                do
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                        sat++;

                    if (date.DayOfWeek == DayOfWeek.Sunday)
                        sun++;

                    date = date.AddDays(1);
                } while (date.Month == m);              
            }

            MessageBox.Show($"西元{year}年有{sat}個禮拜六和{sun}個禮拜天");
        
        }
    }
}
