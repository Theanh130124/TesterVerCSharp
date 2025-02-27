using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VNExpress_Selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            WebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://vnexpress.net/");
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".item-news"));
            foreach (var element in elements.Take(5))
            {


                String title = element.FindElement(By.TagName("h3")).Text;

                String description = element.FindElement(By.CssSelector("p")).Text;


                Console.WriteLine(title);
                Console.WriteLine(description);

                Console.WriteLine("===============================");
            }

            
            driver.Quit();
        }
    }
}
