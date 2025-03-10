using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class PhepTinhDaThuc
    {
        private int n;
        private List<int> a;
        public PhepTinhDaThuc(int n, List<int> a) // truyền vào n ( bậc đa thức , danh sách hệ số ) 
        {
            if (a.Count() != n + 1)
                throw new ArgumentException("Invalid Data"); // n + 1 phần tử -> nếu mà truyền vào không đúng sẽ quăng ra ngoại lệ này
            this.n = n;
            this.a = a;
        }
        public int Tinh(double x)
        {
            int res = 0;
            for (int i = 0; i <= this.n; i++)
            {
                res += (int)(a[i] * Math.Pow(x, i));
            }
            return res;
        }
    }
}
