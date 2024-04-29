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
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace _32_Khoi_N1_KiemThuWebSiteUdemy
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
        }

        private void btn_tc1_32_Khoi_DangNhapThanhCong_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome_khoi_32 = ChromeDriverService.CreateDefaultService();
            chrome_khoi_32.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome_khoi_32);

            // Gọi trang web
            driver.Navigate().GoToUrl("https://en.akkogear.com/");
            Thread.Sleep(2000);

            // 
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div/div[1]/div[2]/a")).Click();
            //driver.FindElement(By.Name("user_name")).SendKeys("dorapoke24@gmail.com");
            //driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("khoi123456");
            //driver.FindElement(By.ClassName("login_btn")).Click();
            
            //     driver.FindElement(By.ClassName("akko_nav")).Click();
            //driver.FindElement(By.ClassName("akko_sub_menu_li")).Click();

        

         
        }
    }
}
