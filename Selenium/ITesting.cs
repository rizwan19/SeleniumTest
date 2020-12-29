using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\");
        }
        [Test]
        public void test()
        {
            driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            IWebElement element = driver.FindElement(By.Name("email"));
            element.SendKeys("rizwanulhaque19@gmail.com");
            IWebElement Password = driver.FindElement(By.Name("passwd"));
            Password.SendKeys("rizwan19,./!");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            String at = driver.Title;
            String et = "Login - My Store";
            if(at==et)
            {
                Console.WriteLine("Test Successfull");
                IWebElement element2 = driver.FindElement(By.XPath("//*[@id='SubmitLogin']"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
