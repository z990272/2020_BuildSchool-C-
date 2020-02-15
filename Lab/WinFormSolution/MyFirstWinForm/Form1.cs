using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    //partial = 部分的form1程式碼
    //最後會和Designer的程式碼合併
    public partial class Form1 : Form  //from1 繼承 form(父類別)
    {
        public Form1() //方法和類別同名 稱為建構式
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //事件委派方法
        {
            MessageBox.Show("Hello Windows Form");
        }
    }
}
