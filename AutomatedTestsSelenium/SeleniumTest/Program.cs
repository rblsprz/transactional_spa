using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;



namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new OperaDriver();
            driver.Navigate().GoToUrl("https://localhost:44346");
            driver.Manage().Window.Maximize();
			IWebElement btnsearch = driver.FindElement(By.Id("btnSignLog"));
            btnsearch.Click();
			
			 IWebElement input = driver.FindElement(By.Id("UsernameSignLog"));
            input.SendKeys("admin");

            IWebElement input1 = driver.FindElement(By.Id("PasswordSignLog"));
            input1.SendKeys("admin");
            //"id = "PasswordSignLog

            //btnAdd
            IWebElement btnsearch1 = driver.FindElement(By.Id("btnAdd"));
            btnsearch1.Click();
			

        }
    }
}
