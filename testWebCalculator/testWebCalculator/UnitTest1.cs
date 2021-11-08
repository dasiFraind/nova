using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
namespace testWebCalculator
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://mahshevon.com/%D7%A1%D7%98%D7%A0%D7%93%D7%A8%D7%98%D7%99/%D7%9E%D7%97%D7%A9%D7%91%D7%95%D7%A0%D7%99%D7%9D-%D7%91%D7%90%D7%99%D7%A0%D7%98%D7%A8%D7%A0%D7%98/%D7%9E%D7%97%D7%A9%D7%91%D7%95%D7%9F-%D7%97%D7%99%D7%A0%D7%9E%D7%99-%D7%90%D7%95%D7%A0%D7%9C%D7%99%D7%99%D7%9F");
            driver.FindElement(By.ClassName("calculator-btn-2")).Click();
            driver.FindElement(By.ClassName("calculator-btn-add")).Click();
            driver.FindElement(By.ClassName("calculator-btn-3")).Click();
            driver.FindElement(By.ClassName("enter")).Click();
            string ExpectedValue = driver.FindElement(By.Name("input")).GetAttribute("value");
            Assert.AreEqual(5, int.Parse(ExpectedValue));
            driver.Quit();
        }
    }
}
