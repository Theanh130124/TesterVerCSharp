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
using System.Threading;
using System.Collections.ObjectModel;

namespace VNExpress_Selenium
{
    public partial class CellPhoneS : Form
    {
        public CellPhoneS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            WebDriver driver = new ChromeDriver(chrome);
            try
            {

                Thread.Sleep(3000);
                driver.Navigate().GoToUrl("https://cellphones.com.vn/");
                IWebElement start =  driver.FindElement(By.ClassName("cps-input"));
                start.SendKeys("IPhone");
                start.SendKeys(OpenQA.Selenium.Keys.Enter);
                

                Thread.Sleep(3000);
                ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName("product-item")); // Chỉ lấy 1 card

                foreach (IWebElement element in elements.Take(5))
                {
                    Thread.Sleep(2000);
                    String title = element.FindElement(By.CssSelector(".product__name h3")).Text;
                    String price = element.FindElement(By.ClassName("product__price--show")).Text;
                    Console.WriteLine(title);
                    Console.WriteLine(price);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                driver.Quit();
            }
        }
    }
}
