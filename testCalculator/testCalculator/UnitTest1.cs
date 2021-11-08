using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
namespace testCalculator
{
    [TestClass]
    public class UnitTest1
    {
        private const string appiumDriverURI = "http://127.0.0.1:4723";
        private const string calApp = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        protected static WindowsDriver<WindowsElement> calSession;
        [TestMethod]
        public void TestMethod1()
        {
            if (calSession == null)  
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                options.AddAdditionalCapability("platformName", "Windows");
                options.AddAdditionalCapability("app", calApp);
                calSession = new WindowsDriver<WindowsElement>(new Uri(appiumDriverURI), options);
                calSession.FindElementByAccessibilityId("num2Button").Click();
                calSession.FindElementByAccessibilityId("plusButton").Click();
                calSession.FindElementByAccessibilityId("num3Button").Click();
                calSession.FindElementByAccessibilityId("equalButton").Click();  
                string ExpectedValue = calSession.FindElementByAccessibilityId("CalculatorResults").Text;  
                string ExpectedValue1 = ExpectedValue.Replace("התצוגה היא ","").Replace(",","");  
                Assert.AreEqual(5,int.Parse(ExpectedValue1));  
            }  
        }
    }
}
