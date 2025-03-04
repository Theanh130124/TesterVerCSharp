using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace VNExpress_Selenium
{

    //Install-Package Selenium.WebDriver
//Install-Package Selenium.Support  -> hổ trợ với selectElement
//Install-Package Selenium.WebDriver.ChromeDriver
//Install-Package Newtonsoft.Json
    public partial class LMS_OU : Form
    {
        public LMS_OU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            WebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://lms.ou.edu.vn/");
            Thread.Sleep(4000); //-> phải cho ngủ nếu đôi khi không lấy được nếu nó load nhanh quá
            driver.FindElement(By.ClassName("main-btn")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("login100-form-btn")).Click();

            //Install-Package Selenium.Support
           
            SelectElement userType = new SelectElement(driver.FindElement(By.Id("form-usertype")));
            userType.SelectByIndex(0); // Sinh viên hệ chính quy 
            string json = File.ReadAllText(@".\data\account.json"); // vào đúng trong form.cs trong bin debug tạo 1  data và file json như vậy

            dynamic userData = JsonConvert.DeserializeObject(json);

            driver.FindElement(By.Id("form-username")).SendKeys((string)userData.username);
            driver.FindElement(By.Id("form-password")).SendKeys((string)userData.password);


            //Console.Write("Nhập captcha: ");
            ////Nữa thêm cái nhập capchat trên form hoặc dưới console 
            //String captcha = Console.ReadLine();
            //driver.FindElement(By.Name("form-captcha")).SendKeys(captcha);
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("m-loginbox-submit-btn")).Click();

            // Chờ danh sách khóa học xuất hiện
            Thread.Sleep(5000);
            IReadOnlyCollection<IWebElement> items = driver.FindElements(By.CssSelector("a > span.multiline"));

            // Lặp qua danh sách khóa học và in tiêu đề
            foreach (var item in items)
            {
                Console.WriteLine("Khóa học: " + item.Text);
            }

 
           
            driver.Quit();


        }
    }
}
