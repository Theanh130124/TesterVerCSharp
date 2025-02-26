using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebDriver driver = new ChromeDriver(); // nạp driver
            driver.Navigate().GoToUrl("https://www.google.com/"); // Chuyển hướng đến gg

            //driver.Navigate().Back() -> lùi lại || . Foward() -> tiến lên || .Refesh() -> tải lại trang
            
            driver.Close(); // Mở xong rồi tắt liền chỉ tắt 1 tab


            //driver.Quit(); // đóng tất cả các tab 


            //String title = driver.Title;  -> Tiêu đề web
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cách 2 
            WebDriver driver_2 = new ChromeDriver();
            //driver_2.Url = "https://www.google.com/";
            // hoặc chổ này có thể gán txt trên WF để người dùng có thể điền vào
            driver_2.Url = txtUrl.Text;
            driver_2.Navigate();

            Thread.Sleep(1000); // ngủ 1 s

            //String src = driver_2.PageSource;  -> lấy hết src code
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            //2 dòng này để ẩn màn hình cmd đen đi nhớ bỏ chrome vào trong new


                WebDriver driver_3 = new ChromeDriver(chrome);
            driver_3.Navigate().GoToUrl("https://www.google.com/");

            // bắt đầu lấy element -> Mình sẽ lấy title và url sau khi đã tìm kím in ra Console
            IWebElement element = driver_3.FindElement(By.Name("q"));
            element.SendKeys(txtSearch.Text);
            element.Submit();
            Thread.Sleep(8000);
            //element.Clear(); -> xóa element


            //
             ReadOnlyCollection<IWebElement> elments = driver_3.FindElements(By.CssSelector(".g h3"));
            foreach ( var element_1 in  elments )
            {
                Console.WriteLine(element_1.Text);
                Console.WriteLine("====================================");
            }    

            driver_3.Close();

            

        }
    }
}
