using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    /// <summary>
    /// 欄位用來儲存值
    /// 屬性用來存取欄位的途徑
    /// 方法是屬性裡做的事
    /// </summary>
    class MyData
    {
        private int _x; // 全域變數 = 執行個體欄位(private) || 執行靜態欄位(private static)
        private int _y;

        public int X            
        {                           //假設 X = 5
            get { return _x; }      //呼叫欄位 
            set { _x = value; }     //指派 5 給 _x
        }

        public int Y
        {           
            set { _y = value; }
            get { return _y; }
        }

        public int Add()
        {
            return X + Y;
        }

        public int Less()
        {
            return X - Y;
        }



    }
}
