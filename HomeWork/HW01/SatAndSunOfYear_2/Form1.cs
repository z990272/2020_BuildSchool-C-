using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._7
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
            int dd = 0;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                dd = 366;
            else
                dd = 365;

            DateTime date = new DateTime(year, 01, 01);
            string d = date.DayOfWeek.ToString("d");
            int dt = int.Parse(d);  //算出第一天是禮拜幾            

            sat = dd / 7;
            sun = dd / 7;

            if (dd == 365 && dt == 6)
                sat = sat + 1;

            if (dd == 365 && dt == 0)
                sun = sun + 1;

            if (dd == 366 && dt == 6)
            {
                sat = sat + 1;
                sun = sun + 1;
            }

            if (dd == 366 && dt == 7)
                sun = sun + 1;

            MessageBox.Show($"西元{year}年有{sat}個禮拜六和{sun}個禮拜天");
        }
    }
}
