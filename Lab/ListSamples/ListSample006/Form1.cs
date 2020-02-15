using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample006
{
    public partial class Form1 : Form
    {
        private List<string> _leftlist;
        private List<string> _rightlist;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListDataSource();
            ChangData();
        }
        
        private void CreateList()
        {
            
            _leftlist = new List<string>()
            {  "A","B","C","D"  };

            _rightlist = new List<string>();
        }

        private void SetListDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void ChangData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftlist;
            listBox2.DataSource = _rightlist;
        }

        /// <summary>
        /// 從左到右
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem;
                _leftlist.Remove(item);
                _rightlist.Add(item);
                ChangData();
            }
        }

        /// <summary>
        /// 從右到左
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                _rightlist.Remove(item);
                _leftlist.Add(item);
                ChangData();
            }
        }
    }
}
