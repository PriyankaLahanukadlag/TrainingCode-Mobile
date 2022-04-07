using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidAutomation
{
    [TestClass]
    public class NativeTest3
    {
        [TestMethod]
        public void Tap() {

            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");//If we have apk file 

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            
            //Click on Dismiss 
            driver.FindElementByXPath("//*[@text='Dismiss']").Click();

            //Click on Sign In
            driver.FindElementByXPath("//android.widget.TextView[@text='Sign in']").Click();
            
            driver.FindElementByXPath("//*[@text='Continue with Facebook']").Click();
            ReadOnlyCollection<string> elements = driver.Contexts;
            foreach (var element in elements) {
                Console.WriteLine(element.ToString());
                driver.Context = element;
                if (driver.FindElementsByXPath("//*[@type='email']").Count > 0)
                {
                    break;
                }

                }
            driver.FindElementByXPath("//*[@type='email']").SendKeys("priyankaKadlag@gmail.com");
        }
    }
 }

