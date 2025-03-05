using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;
using OpenQA.Selenium.Support.UI;

namespace VNExpress_Selenium
{
    public partial class RegisterFacebook : Form
    {
        public RegisterFacebook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            WebDriver driver = new ChromeDriver(chrome);
            try
            {

                Thread.Sleep(3000);
                driver.Navigate().GoToUrl("https://www.facebook.com/");


                //Dùng XPath cho text -> cứ refesh trang WEB mà thấy id đổi thì không lấy được 



                //                Cách tìm phần tử    Cú pháp XPath
                //                Tìm theo id	//*[@id='example']
                //Tìm theo class	//*[@class='example']
                //Tìm theo name	//*[@name='example']
                //Tìm theo text()	//*[text()='Example Text']
                //Tìm phần tử chứa văn bản	//*[contains(text(), 'Example')]
                //Tìm con trực tiếp	//*[@id='parent']/child
                //Tìm con ở bất kỳ cấp nào	//*[@id='parent']//child
                //Kết hợp nhiều điều kiện	//tag[@attr1='value' and @attr2='value']
                //Chọn phần tử thứ n(//tag)[n]
                //Chọn phần tử cuối cùng  (//tag)[last()]

                //Ctrl F để mở filter trên Inspect 
                driver.FindElement(By.XPath("//*[text()='Create new account']")).Click();


                Thread.Sleep(2000);
                driver.FindElement(By.Name("firstname")).SendKeys("TheAnh");
                driver.FindElement(By.Name("lastname")).SendKeys("Tran");
                SelectElement days = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                SelectElement moths = new SelectElement(driver.FindElement(By.Name("birthday_month")));
                SelectElement years = new SelectElement(driver.FindElement(By.Name("birthday_year")));
                days.SelectByIndex(12); // -> ngày 13
                moths.SelectByIndex(0);// tháng 1 
                years.SelectByValue("2004"); //lấy theo value
                driver.FindElement(By.XPath("//*[text()='Female']")).Click(); // Button
                driver.FindElement(By.Name("reg_email__")).SendKeys("0911328940");
                driver.FindElement(By.Name("reg_passwd__")).SendKeys("tta13012004");


                driver.FindElement(By.Name("websubmit")).Click();





                //No, Create New Account
            }
            catch (Exception ex) {
            
                    Console.WriteLine(ex.Message);
            }
            finally
            {
                
                
            }

        }
    }
}
