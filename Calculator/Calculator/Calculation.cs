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
        
    }
}
