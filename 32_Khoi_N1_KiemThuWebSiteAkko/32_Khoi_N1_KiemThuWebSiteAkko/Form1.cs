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

namespace _32_Khoi_N1_KiemThuWebSiteAkko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_32_Khoi_TruyCapTrangWeb_Click(object sender, EventArgs e)
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
            //nhấn vào button tăng số lượng sản phẩm
            driver.FindElement(By.CssSelector(".quantity-button.quantity-up")).Click();

            //nhấn vào check box đồng ý
            driver.FindElement(By.Id("pc_preorder_comfirm_checkbox")).Click();

            // nhấn vào đặt hàng
            driver.FindElement(By.CssSelector("button[type='submit'].single_add_to_cart_button.button.alt")).Click();
            Thread.Sleep(2000);

            //nhấn vào icon gioie hàng
            driver.FindElement(By.CssSelector(".elms_shop_cart.akko_cart_icon.elms_shop_cart > a")).Click();


            //xóa dơn hàng

            while (true)
            {
                try
                {
                    // Find the element with link text "×"
                    driver.FindElement(By.LinkText("×")).Click();
                    Thread.Sleep(2000);

                }
                catch (NoSuchElementException)
                {
                    //NoSuchElementException, nếu phần tử không được tìm thấy
                    //tức là không còn đơn hàng nữa, chúng ta thoát khỏi vòng lặp bằng cách sử dụng lệnh break
                    break;
                }
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
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
            int expected = 3;
            // Kiểm tra
            //chuẩn bị trong giỏ hàng ít nhất 1 sản phẩm 
            //tổng sp=1;
            //expect=2;
       
        }

        private void button1_Click(object sender, EventArgs e)
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




            //Gán giá trị tổng sản phẩm
            // Lấy danh sách các phần tử có class "product-subtotal"
        var subtotalElements = driver.FindElements(By.ClassName("product-subtotal"));

        float total = 0;

        // Duyệt qua từng phần tử và tính tổng giá tiền
        foreach (var element in subtotalElements)
        {
                string priceText = element.Text ;
                int startIndex = priceText.IndexOf('$') + 1;
                    string numberPart = priceText.Substring(startIndex).Trim();
                    if (float.TryParse(numberPart, out float actual))
                    {
                        Console.WriteLine(actual);
                        total += actual;
                    }
            }
            // In tổng giá tiền
            Console.WriteLine("Tổng giá tiền: AUD $" + total);
        }
    }
}
