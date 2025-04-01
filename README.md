DemoTesterVerC-
Kiểm Thử Phần Mềm C#

//Nhớ pull về

private void btnDangNhap_21_Anh_Click(object sender, EventArgs e) { ChromeDriverService chrome_21_Anh = ChromeDriverService.CreateDefaultService(); chrome_21_Anh.HideCommandPromptWindow = true; IWebDriver driver_21_Anh = new ChromeDriver(chrome_21_Anh); //Chuyển hướng đến trang đăng nhập driver_21_Anh.Navigate().GoToUrl("https://account.cellphones.com.vn/"); IWebElement element_username_21_Anh = driver_21_Anh.FindElement(By.CssSelector("input[type='tel']"));

        //Điền tên đăng nhập
        element_username_21_Anh.SendKeys("0933033801");
        IWebElement element_pass_21_Anh = driver_21_Anh.FindElement(By.CssSelector("input[type='password']"));
        //Điền mật khẩu
        element_pass_21_Anh.SendKeys("tta1301");
        //Nhấn đăng nhập
        IWebElement element_submit_21_Anh = driver_21_Anh.FindElement(By.ClassName("button__login"));
        element_submit_21_Anh.Click();

    

    }