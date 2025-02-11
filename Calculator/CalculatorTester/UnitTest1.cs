using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator; //thêm vào giống kiểu import 

namespace CalculatorTester
{
    [TestClass]//Định nghĩa cho các phương thức test bên dưới -> có nhiều testCase 
    public class UnitTest1
    {

        private Calculation c;
        [TestInitialize] //Khai báo để chạy ban đầu luôn chạy trc testCase
        
        public void Init() { // Dùng chung
            c = new Calculation(10, 5);
        }

        [TestMethod]//Định nghĩa 1 testCase 
        public void TestTong()
        {
            //
            int excepted = 15; // kết quả mong muốn
            //Calculation c = new Calculation(10, 5);
            Init();
            int actual = c.Exucute("Cộng");// kết quả thực tế
            Assert.AreEqual(excepted,actual); // True hay false ;



        }
        [TestMethod]
        public void TestTru()
        {
            int excepted = 5;
            //Calculation c = new Calculation(10,5);
            Init();
            int actual = c.Exucute("Trừ");
            Assert.AreEqual(excepted,actual);
        }
        [TestMethod]
        public void TestNhan()
        {
            int excepted = 50;
            //Calculation c = new Calculation(10, 5);
            Init();
            int actual = c.Exucute("Nhân");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestChia()
        {
            int excepted = 2;
            //Calculation c = new Calculation(10, 5);
            Init();
            int actual = c.Exucute("Chia");
            Assert.AreEqual(excepted, actual);
        }
        [ExpectedException(typeof(DivideByZeroException))] // bắt lỗi chia cho 0 
        [TestMethod]
        public void TestChiaChoKhong()
        {
  
            Calculation c = new Calculation(10, 0);
            int actual = c.Exucute("Chia");

        }
    }
}
