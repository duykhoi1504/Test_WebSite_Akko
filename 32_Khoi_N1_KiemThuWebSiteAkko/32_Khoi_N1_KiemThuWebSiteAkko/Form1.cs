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
    }
}
