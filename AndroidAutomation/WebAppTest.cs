using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidAutomation
{
    [TestClass]
    public class WebAppTest
    {   
        [TestMethod]
        public void HDFClogin() {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("browserName", "chrome");
            OpenQA.Selenium.Appium.Android.AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.SwitchTo().Frame(driver.FindElementByXPath("//frame[contains(@src,'RSNBLogin.html')]"));

            driver.FindElementByXPath("//input[@name='fldLoginUserId']").SendKeys("test 123");
          
            driver.FindElementByXPath("//*[text()='CONTINUE']");
            
        }
    }
}
