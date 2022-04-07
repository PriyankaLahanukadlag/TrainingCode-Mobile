using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Threading;

namespace AndroidAutomation
{
    [TestClass]
    public class AndroidTest
    {
       
           [TestMethod]
        public void setUp()
        {
           AppiumOptions option=new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("browserName", "chrome");
            //option.AddAdditionalCapability("chromedriverExecutable", "chrome");
            //option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Url = "https://nasscom.in/about-us/contact-us";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElementByXPath("//a[contains(text(),'New User')]").Click();
            driver.FindElementByXPath("//input[@id='edit-field-fname-reg']").SendKeys("Priya");
            driver.FindElement(By.XPath("//input[@id='edit-field-lname']")).SendKeys("Kad");
          
            if (driver.IsKeyboardShown()){
                driver.HideKeyboard();
            }
            driver.FindElement(By.XPath("//input[@id='edit-mail']")).SendKeys("priyanka.kadlag@yash.com");
            driver.FindElement(By.XPath("//input[@id='edit-field-company-name-registration']")).SendKeys("Yash");
            if (driver.IsKeyboardShown())
            {
                driver.HideKeyboard();
            }
            driver.FindElement(By.XPath("//input[@id='//select[@id='edit-field-business-focus-reg'")).Click();
            driver.FindElement(By.XPath("//*[text()='Animation']")).Click();
            driver.FindElement(By.XPath("//input[@id='edit - submit--2']")).SendKeys("Yash");



            Thread.Sleep(5000);
             driver.Quit();
           
        }
       
    }
}