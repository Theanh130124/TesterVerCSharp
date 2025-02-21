using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator; //thêm vào giống kiểu import 

namespace CalculatorTester
{
    [TestClass]//Định nghĩa cho các phương thức test bên dưới -> có nhiều testCase 
    public class UnitTest1
    {

        private Calculation c_21_Anh;
        //Khai báo thêm testContext để thực hiện lấy dữ liệu với file
        
        public TestContext TestContext { get; set; }  //Phải đặt tên TestContext ghi hoa đúng hệt vậy mới được


        //Link TestData với Project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential )] //tham số : dạng file , tên file (lấy trong properties của nó  , tablename , phương thức kết nối (như mình khai báo
        //Tu nhan biet HEADER roi  voi DataAccessMethod.Sequential 
        
        public void TestWithDataSource_21_Anh()
        {
            int a_21_Anh, b_21_Anh, excepted_21_Anh, actual_21_Anh;
            string symbol_21_Anh = TestContext.DataRow[2].ToString(); // nó là cột phép tính có dâu ' ở trước
            symbol_21_Anh = symbol_21_Anh.Remove(0, 1);
            a_21_Anh = int.Parse(TestContext.DataRow[0].ToString()); //DataRow[0] -> là giá trị cột đầu tiên , datarow là hàng hiện tại [0] là cột đầu / hoặc có thể truyền vào tên cột là a 
            b_21_Anh = int.Parse(TestContext.DataRow[1].ToString()); // có thể truyền vào tên cột là b 
            excepted_21_Anh = int.Parse(TestContext.DataRow[3].ToString());
            c_21_Anh = new Calculation(a_21_Anh, b_21_Anh);
            actual_21_Anh = c_21_Anh.Exucute(symbol_21_Anh);// kết quả thực tế
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh); // True hay false ;
            //Nữa nhớ đổi thành dấu 


        }

        //là đọc tuần tự từng dòng)

        [TestInitialize] //Khai báo để chạy ban đầu luôn chạy trc testCase
        public void Init_21_Anh() { // Dùng chung
            c_21_Anh = new Calculation(10, 5);
        }


        [TestMethod]//Định nghĩa 1 testCase 
        public void TestTong_21_Anh()
        {
            //
            int excepted_21_Anh = 15; // kết quả mong muốn
            //Calculation c = new Calculation(10, 5);
            Init_21_Anh();
            int actual_21_Anh = c_21_Anh.Exucute("+");// kết quả thực tế
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh); // True hay false ;



        }
        [TestMethod]
        public void TestTru_21_Anh()
        {
            int excepted_21_Anh = 5;
            //Calculation c = new Calculation(10,5);
            Init_21_Anh();
            int actual_21_Anh = c_21_Anh.Exucute("-");
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh);
        }
        [TestMethod]
        public void TestNhan_21_Anh()
        {
            int excepted_21_Anh = 50;
            //Calculation c = new Calculation(10, 5);
            Init_21_Anh();
            int actual_21_Anh = c_21_Anh.Exucute("*");
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh);
        }
        [TestMethod]
        public void TestChia_21_Anh()
        {
            int excepted_21_Anh = 2;
            //Calculation c = new Calculation(10, 5);
            Init_21_Anh();
            int actual_21_Anh = c_21_Anh.Exucute("/");
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh);
        }
        [ExpectedException(typeof(DivideByZeroException))] // bắt lỗi chia cho 0 
        [TestMethod]
        public void TestChiaChoKhong_21_Anh()
        {
  
            Calculation c_21_Anh = new Calculation(10, 0);
            c_21_Anh.Exucute("/");

        }

        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestPower.csv", "TestPower#csv", DataAccessMethod.Sequential)]
        public void TestPower_21_Anh()
        {
            int n_21_Anh;
            double x_21_Anh, excepted_21_Anh, actual_21_Anh;
            n_21_Anh = int.Parse(TestContext.DataRow[1].ToString());                  //Đã chạy với n== 0 thì testcase pass
            x_21_Anh = double.Parse(TestContext.DataRow[0].ToString());
            excepted_21_Anh = double.Parse(TestContext.DataRow[2].ToString());
            actual_21_Anh = Calculation.Power_21_Anh(x_21_Anh, n_21_Anh);
            Assert.AreEqual(excepted_21_Anh, actual_21_Anh);
        }
        
       
    }
}
