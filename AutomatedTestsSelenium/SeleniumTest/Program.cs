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

        }
    }
}
