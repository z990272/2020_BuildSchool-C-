using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample005
{
    public partial class Form1 : Form
    {
        private List<String> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }

        private void CreateList()
        {
            _list = new List<string>()
            {
                "Dog", "Cat", "Monkey", "Fly", "Donkey", "Dog2"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = _list.Find((x) => x == textBox1.Text);
            MessageBox.Show($"Find = {result}");
            // Find 找輸入字元完全相符且是第一個的
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = _list.FindIndex((x) => x == textBox1.Text);
            MessageBox.Show($"FindIndex = {index}");
            // FindIndex 找輸入字元完全相符的串列位址(0~5)
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            List<String> results = _list.FindAll((x) => x.Contains(textBox1.Text));
            string result = string.Empty;

            foreach (string item in results)
                result = result + item + ",";

            MessageBox.Show($"FindAll = {result}");
            //FindAll 找字串內包含輸入字元的所有字
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = _list.FindLast((x) => x.Contains(textBox1.Text));
            MessageBox.Show($"Find Last = {result}");
            //FindLast 找字串內包含輸入字元的最後一個字
        }
    }
}
