using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;

        public Form1()
        {
            InitializeComponent();
            creatlist();
            SetComboBox();
        }

        private void creatlist()
        {
            _list = new List<MyRectangle>()
            {
                new MyRectangle{Name = "D1", Width = 5, Height = 5},
                new MyRectangle{Name = "D2", Width = 10, Height = 10},
                new MyRectangle{Name = "D3", Width = 20, Height = 20},
                new MyRectangle{Name = "D4", Width = 100, Height = 100}
            };
        }

        private void SetComboBox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;   
            //(MyRectangle)轉型用的 被選到項目(return object)
            //將被選到的項目(object)轉型成MyRectangle型態 存到 item 
            MessageBox.Show($"{item.Name} 的面積為{item.GetArea()}");
        }
    }
}
