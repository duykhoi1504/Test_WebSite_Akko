using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace UnitTest_32_Khoi_Login
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }




        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                     @".\data\LoginData.csv", "LoginData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Login_32_Khoi()
        {

            /*
            Test case 1_Đăng nhập thành công
            Test case 2_Đăng nhập sai tài khoản
            Test case 3_Đăng nhập sai mật khẩu
            Test case 4_Đăng nhập thiếu tài khoản
            Test case 5_Đăng nhập thiếu mật khẩu
            Test case 6_Đăng nhập với tài khoản có kí tự đặc biệt
            Test case 7_Đăng nhập với tài khoản được tạo nhưng chưa kích hoạt
            */

            //lưu dữ liệu ra biến
            var username = TestContext.DataRow[0].ToString();
            var password = TestContext.DataRow[1].ToString();

            ChromeDriverService chrome_khoi_32 = ChromeDriverService.CreateDefaultService();
            chrome_khoi_32.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome_khoi_32);

            // Gọi trang web
            driver.Navigate().GoToUrl("https://en.akkogear.com/");
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div/div[1]/div[2]/a")).Click();
            driver.FindElement(By.Name("user_name")).SendKeys(username);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(password);
            driver.FindElement(By.ClassName("login_btn")).Click();
            Assert.AreEqual("https://en.akkogear.com/my-account/", driver.Url, "Login Fail!");
         
     

            //    driver.FindElement(By.ClassName("akko_nav")).Click();
            //    driver.FindElement(By.ClassName("akko_sub_menu_li")).Click();
            //}
        }
    }
}
