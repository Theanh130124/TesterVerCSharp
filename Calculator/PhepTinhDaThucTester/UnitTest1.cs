using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PhepTinhDaThucTester
{
    [TestClass]
    public class UnitTest1
    {


        //testcase  BẬC hệ số mũ (n<0)
        //testcase đúng hệ số pass
        //testcase đúng hệ số nhưng sai phép tính
        //testcase thiếu tham số . 

        public TestContext TestContext { get; set; }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TC1_DaThucBac()
        {
            //Đa thức 2 + 3x + 1x^2 -> tại x = 2 -> actual = 12 -> pass
            //Đa thức 2 + 3x+ x^2 -> tại x =1 -> actual =12 -> expected = 0 -> fail
            //Đa thức với n = 1 mà có 3 hệ số ->
            int n = int.Parse(TestContext.DataRow[0].ToString());
            int x0 = int.Parse(TestContext.DataRow[1].ToString());
            int x1 = int.Parse(TestContext.DataRow[2].ToString());
            int x2 = int.Parse(TestContext.DataRow[3].ToString());


            PhepTinhDaThuc p = new PhepTinhDaThuc(n, new List<int> { x0, x1, x2 });
            double x = 2;
            int actual = p.Tinh(x);
            int expected = int.Parse(TestContext.DataRow[4].ToString());
            Assert.AreEqual(expected, actual);
        }
        // nếu n=1 ?? xem lại test data
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC2_NhapNAm_ThrowException()
        {
            PhepTinhDaThuc p = new PhepTinhDaThuc(-1, new List<int> { 1, 2, 3 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC3_ThieuHeSo_ThrowException()
        {
            PhepTinhDaThuc p = new PhepTinhDaThuc(2, new List<int> { 1, 2 }); // Thiếu 1 hệ số
        }



    }
}

