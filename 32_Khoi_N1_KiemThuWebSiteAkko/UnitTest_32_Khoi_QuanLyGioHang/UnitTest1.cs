using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTest_32_Khoi_QuanLyGioHang
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ThemSanPham_32_Khoi()
        {
            //32_Khoi
            //tat man den
            ChromeDriverService chrome_khoi_32 = ChromeDriverService.CreateDefaultService();
            chrome_khoi_32.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome_khoi_32);
            //gọi trang web
            driver.Navigate().GoToUrl("https://en.akkogear.com/");
            Thread.Sleep(2000);

            //Đăng nhập vào trang web
            driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div/div[1]/div[2]/a")).Click();
            driver.FindElement(By.Name("user_name")).SendKeys("dorapoke24@gmail.com");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("khoi123456");
            driver.FindElement(By.ClassName("login_btn")).Click();
            Thread.Sleep(1000);

            //tiến hành test giỏ hàng

            //Nhấn vào product trên thanh menu
            driver.FindElement(By.CssSelector(".akko_menu li:first-child")).Click();


            //nhấn vào phân loại sản phẩm keyBoards
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div/div[1]/a[1]/li/div")).Click();
            Thread.Sleep(2000);
            //nhấn vào sản phẩm đầu tiên
            driver.FindElement(By.XPath("/html/body/div[2]/div/diiv/div/div[2]/div[3]")).Click();
            Thread.Sleep(2000);

            //nhấn vào check box đồng ý
            driver.FindElement(By.Id("pc_preorder_comfirm_checkbox")).Click();

            // nhấn vào đặt hàng
            driver.FindElement(By.CssSelector("button[type='submit'].single_add_to_cart_button.button.alt")).Click();
            Thread.Sleep(2000);

            //nhấn vào icon gioie hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();

            //kiểm tra
            IWebElement afterAddCartItem = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div[1]/div[1]/div/span"));
            int afterCartItemCount = int.Parse(afterAddCartItem.Text);

            // Kiểm tra
            //chuẩn bị trong giỏ hàng không có sản phẩm(emty)
            Assert.AreEqual(1, afterCartItemCount, "Failed to remove product from cart.");
        }
        //[TestMethod]
        //public void Test_XoaSanPham_32_Khoi()
        //{

        //}
    }
}
