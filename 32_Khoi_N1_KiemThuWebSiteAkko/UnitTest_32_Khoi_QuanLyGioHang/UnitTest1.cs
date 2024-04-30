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
            driver.FindElement(By.Name("user_name")).SendKeys("voduykhoi32");
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
            Thread.Sleep(2000);

            //Gán giá trị cho actual và expected
            IWebElement countCartAfter = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div[1]/div[1]/div/span"));
            int actual = int.Parse(countCartAfter.Text);
            int expected = 1;
    
            // Kiểm tra
            /*
             chuẩn bị trong giỏ hàng không có sản phẩm(emty)
                Thực hiện: thêm 1 sản phẩm và nhấp vào giỏ xem kết quả
            kết quả mong muốn: sản phẩm mới dược thêm
             */
           
            Assert.AreEqual(expected, actual, "Failed to add product from cart.");
        }
        [TestMethod]
        public void Test_XoaSanPham_32_Khoi()
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
            driver.FindElement(By.Name("user_name")).SendKeys("voduykhoi32");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("khoi123456");
            driver.FindElement(By.ClassName("login_btn")).Click();
            Thread.Sleep(1000);

            //tiến hành test giỏ hàng

            //nhấn vào icon giỏ hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();


            Thread.Sleep(2000);
            //xóa dơn hàng
            driver.FindElement(By.LinkText("×")).Click();
            Thread.Sleep(3000);


            //Gán giá trị tổng sản phẩm
            IWebElement countCartAfter = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div[1]/div[1]/div/span"));
            int actual = int.Parse(countCartAfter.Text);
            int expected = 1;
            Console.WriteLine(actual + " and " + expected);
            /*
            Chuẩn bị:
            trong giỏ hàng ít nhất 2 sản phẩm khác nhau
            sp1:1
            sp2:1 
            Thực hiện: xóa 1 sp;
            kết quả:Số lượng sp:1
             */

            Assert.AreEqual(expected, actual, "Failed to remove product from cart.");

        }
        [TestMethod]
        public void Test_CapNhatSoLuongSP_32_Khoi()
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
            driver.FindElement(By.Name("user_name")).SendKeys("voduykhoi32");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("khoi123456");
            driver.FindElement(By.ClassName("login_btn")).Click();
            Thread.Sleep(1000);

            //nhấn vào icon giỏ hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();
            Thread.Sleep(2000);

            //nhấn vào + tăng số lượng sản phẩm
            driver.FindElement(By.CssSelector(".quantity-button.quantity-up")).Click();
            Thread.Sleep(2000);

            //nhấn vào button "UpdateCart"
            driver.FindElement(By.Name("update_cart")).Click();
            Thread.Sleep(3000);


            //Gán giá trị tổng sản phẩm
            IWebElement countCartAfter = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div[1]/div[1]/div/span"));
            int actual = int.Parse(countCartAfter.Text);
            Console.WriteLine(actual);
            int expected = 2;
            /*
            Kiểm tra
            chuẩn bị trong giỏ hàng có 1 sp số lượng = 1 
            tổng sp ban đầu=1;
            kết quả:
            tổng sp sau khi thêm :2
             */
            Assert.AreEqual(expected, actual, "Failed to update product Count from cart.");
        }
        [TestMethod]
        public void Test_TinhTongGiaTriDonHang_32_Khoi()
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
            driver.FindElement(By.Name("user_name")).SendKeys("voduykhoi32");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("khoi123456");
            driver.FindElement(By.ClassName("login_btn")).Click();
            Thread.Sleep(1000);



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
            Thread.Sleep(2000);

            // Lấy danh sách các phần tử có class "product-subtotal"
            var subtotalElements = driver.FindElements(By.ClassName("product-subtotal"));
            //gán tổng tiền = 0
            float total = 0;
            // Duyệt qua từng phần tử và tính tổng giá tiền
            foreach (var element in subtotalElements)
            {
                string priceText = element.Text;
                int startIndex = priceText.IndexOf('$') + 1;
                string numberPart = priceText.Substring(startIndex).Trim();
                if (float.TryParse(numberPart, out float countItem))
                {
                    Console.WriteLine(countItem);
                    total += countItem;
                }
            }
            

            float expected = 239.98f;
            float actual = total;
            //Kiểm tra kết quả
            /*
                chuẩn bị:
                MU01 Autumn - so luongl: 1 - GiaTien:$119.99
                thực hiện:
                người dùng thêm sp: MU01 Mountain Seclusion - so luong: 1 - GiaTien:$119.99
                kết quả dự kiến:239.98
             */
            Console.WriteLine(expected+ " " + total);
            Assert.AreEqual(expected, actual, "toal price FAIL");
        }
        [TestMethod]
        public void Test_XoaToanBoDonHang_32_Khoi()
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
            Thread.Sleep(2000);

            //nhấn vào icon gioie hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();

            bool isEmty = false;
            //xóa dơn hàng

            while (true)
            {
                try
                {
                    // Find the element with link text "×"
                    driver.FindElement(By.LinkText("×")).Click();
                    isEmty = false;
                    Thread.Sleep(2000);

                }
                catch (NoSuchElementException)
                {
                    //NoSuchElementException, nếu phần tử không được tìm thấy
                    //tức là không còn đơn hàng nữa, chúng ta thoát khỏi vòng lặp bằng cách sử dụng lệnh break
                    isEmty = true;
                    break;
                }
            }

            /*
            chuẩn bị: nhiều hơn 2 đợn hàng khác nhau
            thực hiện: xóa toàn bô đơn hàng trong giỏ:
            kết quả mong muốn: không còn đơn hàng nào trong giỏ
             */
            bool expected = true;
            bool actual = isEmty;
            Assert.AreEqual(expected, actual, "Delete All From Cart is FAIL");
        }
        [TestMethod]
        public void Test_HienThiChiTietDonHangTrongGio_32_Khoi()
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
            Thread.Sleep(2000);

            //nhấn vào icon gioie hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("MU01 Mountain Seclusion - Akko V3 Piano Pro")).Click();
            Thread.Sleep(2000);
            /*
             chuẩn bị:MU01 Mountain Seclusion
             Thực hiện: nhấn vào sản phẩm
            kết quả mong muốn: hiển thị giao diện chi tiết đơn hàng MU01 Mountain Seclusion
             */
            string expected = "https://en.akkogear.com/product/mu01-mountain-seclusion-mechanical-keyboard/?attribute_switch=Akko+V3+Piano+Pro";
           string actual = driver.Url;
            Assert.AreEqual(expected, actual, "watch detail product From Cart is FAIL");
        }
    }
}
