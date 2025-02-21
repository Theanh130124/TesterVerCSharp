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
        private int a_21_Anh, b_21_Anh; 
        
        public Calculation(int a_21_Anh, int b_21_Anh)
        {
            this.a_21_Anh = a_21_Anh; 
            this.b_21_Anh = b_21_Anh;  
        }
        public int Exucute(string calSymbol_21_Anh)
        {
            int res_21_Anh = 0; 
            switch (calSymbol_21_Anh)
            {
                case "+":
                    res_21_Anh = a_21_Anh + b_21_Anh;
                    break;
                case "-":
                    res_21_Anh = a_21_Anh - b_21_Anh;
                    break;
                case "*":
                    res_21_Anh = a_21_Anh * b_21_Anh;
                    break;
                case "/":
                    res_21_Anh = a_21_Anh / b_21_Anh; 
                    break;
            }


            return res_21_Anh;
        }
        public static double Power_21_Anh(double x_21_Anh, int n_21_Anh)  // 
        { 
            if (n_21_Anh == 0)
                return 1.0;
            else if (n_21_Anh > 0)
                return x_21_Anh * Power_21_Anh(x_21_Anh, n_21_Anh - 1);   // fix lại thành Power -> đã thấy lỗi ở đây thì đi tạo testCase  -> sửa n thành x 
            else
                return 1/ Power_21_Anh(x_21_Anh, -n_21_Anh) ;  // đã sửa khi test thấy bug 
        }
        
    }
}
