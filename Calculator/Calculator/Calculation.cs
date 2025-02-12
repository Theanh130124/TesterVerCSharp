using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation //internal khác project không dùng được  ->  nên đã đổi thành public
    {
        private int a, b; 
        
        public Calculation(int a , int b)
        {
            this.a = a; 
            this.b = b;  
        }
        public int Exucute(string calSymbol)
        {
            int res= 0; 
            switch (calSymbol)
            {
                case "Cộng":
                     res = a + b;
                    break;
                case "Trừ":
                    res = a - b;
                    break;
                case "Nhân":
                     res = a * b;
                    break;
                case "Chia":
                    res = a / b; ;
                    break;
            }


            return res;
        }
        public static double Power(double x, int n)  // 
        { 
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return x * Power(x, n - 1);   // fix lại thành Power -> đã thấy lỗi ở đây thì đi tạo testCase  -> sửa n thành x 
            else
                return 1/ Power(x, -n) ;  // đã sửa khi test thấy bug 
        }
        
    }
}
