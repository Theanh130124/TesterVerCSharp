using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator; //thêm vào giống kiểu import 

namespace CalculatorTester
{
    [TestClass]//Định nghĩa cho các phương thức test bên dưới -> có nhiều testCase 
    public class UnitTest1
    {

        private Calculation c;
        //Khai báo thêm testContext để thực hiện lấy dữ liệu với file
        
        public TestContext TestContext { get; set; }  //Phải đặt tên TestContext ghi hoa đúng hệt vậy mới được


        //Link TestData với Project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential )] //tham số : dạng file , tên file (lấy trong properties của nó  , tablename , phương thức kết nối (như mình khai báo
        //Tu nhan biet HEADER roi  voi DataAccessMethod.Sequential 
        
        public void TestWithDataSource()
        {
            int a, b, excepted, actual;
            string symbol = TestContext.DataRow[2].ToString(); // nó là cột phép tính có dâu ' ở trước
            //symbol = symbol.Remove(0, 1);
            a = int.Parse(TestContext.DataRow[0].ToString()); //DataRow[0] -> là giá trị cột đầu tiên , datarow là hàng hiện tại [0] là cột đầu / hoặc có thể truyền vào tên cột là a 
            b = int.Parse(TestContext.DataRow[1].ToString()); // có thể truyền vào tên cột là b 
            excepted = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            actual = c.Exucute(symbol);// kết quả thực tế
            Assert.AreEqual(excepted, actual); // True hay false ;
            //Nữa nhớ đổi thành dấu 


        }

        //là đọc tuần tự từng dòng)

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
            int actual = c.Exucute("Cong");// kết quả thực tế
            Assert.AreEqual(excepted,actual); // True hay false ;



        }
        [TestMethod]
        public void TestTru()
        {
            int excepted = 5;
            //Calculation c = new Calculation(10,5);
            Init();
            int actual = c.Exucute("Tru");
            Assert.AreEqual(excepted,actual);
        }
        [TestMethod]
        public void TestNhan()
        {
            int excepted = 50;
            //Calculation c = new Calculation(10, 5);
            Init();
            int actual = c.Exucute("Nhan");
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
            c.Exucute("Chia");

        }

        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestPower.csv", "TestPower#csv", DataAccessMethod.Sequential)]
        public void TestPower()
        {
            int n;
            double x, excepted , actual;
            n = int.Parse(TestContext.DataRow[1].ToString());                  //Đã chạy với n== 0 thì testcase pass
            x = double.Parse(TestContext.DataRow[0].ToString());
            excepted = double.Parse(TestContext.DataRow[2].ToString());
            actual = Calculation.Power(x, n);
            Assert.AreEqual(excepted, actual);
        }
        
       
    }
}
