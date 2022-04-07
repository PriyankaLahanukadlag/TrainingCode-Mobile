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
    public class NativeAppTest
    {

        [TestMethod]
        public void OpenExistingApp()
        {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("appPackage", "org.khanacademy.android");
            option.AddAdditionalCapability("appActivity", "org.khanacademy.android.ui.library.MainActivity");


            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Click on Dismiss 
            driver.FindElementByXPath("//*[@text='Dismiss']").Click();

            //Click on Sign In
            driver.FindElementByXPath("//android.widget.TextView[@text='Sign in']").Click();
        }

       [TestMethod]
        public void ValidCreadentialTest() {
           DriverOptions option = new AppiumOptions();
           option.AddAdditionalCapability("platformName", "android");
           option.AddAdditionalCapability("deviceName", "mobapp");
           option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");//If we have apk file 

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //*[@text='']
            //*[@content-desc='']
            //*[@resource-id='']

            //Click on Dismiss 
            driver.FindElementByXPath("//*[@text='Dismiss']").Click();
           
            //Click on Sign In
            driver.FindElementByXPath("//android.widget.TextView[@text='Sign in']").Click();
            driver.FindElementByXPath("//android.widget.TextView[@text='Sign in']").Click();

            //Enter UserName and Password
            driver.FindElementByXPath("//android.widget.EditText[@content-desc='Enter an e-mail address or username']").SendKeys("TestBox");
            driver.FindElementByXPath("//android.widget.EditText[@content-desc='Password']").SendKeys("TestBox");
            if (driver.IsKeyboardShown())
            {
                driver.HideKeyboard();
            }
            //Click on Sign In
            driver.FindElementByXPath("//*[@content-desc='Sign in']").Click();

            //read Validation Text
            Console.WriteLine(driver.FindElementByXPath("//android.widget.TextView[contains(@text,'There was an issue signing in')]").Text);
            Thread.Sleep(5000);

            driver.Quit(); 
        }

        [TestMethod]
        public void SignUpTest()
        {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");//If we have apk file 

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Click on Dismiss 
            driver.FindElementByXPath("//*[@text='Dismiss']").Click();

            //Click on Sign In
            driver.FindElementByXPath("//android.widget.ImageView[@content-desc='Settings']").Click();
            driver.FindElementByXPath("//*[@text='Sign in']").Click(); 
            driver.FindElementByXPath("//*[@text='Sign up with email']").Click();

            //Using UI Selector 
            driver.FindElementByAndroidUIAutomator("UiSelector().text(\"First name\")").SendKeys("Priyanka");
            driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Last name\")").SendKeys("Kadlag"); 
            driver.FindElementByAndroidUIAutomator("UiSelector().description(\"Email address\")").SendKeys("priyanka.kadlag@yash.com");
            driver.FindElementByAndroidUIAutomator("UiSelector().textContains(\"Passwor\")").SendKeys("Priyanka");
            driver.FindElementByXPath("//*[@text='Birthday']").Click();

            //driver.FindElementByXPath("//android.view.ViewGroup[@content-desc='Birthday']/android.widget.ImageView").Click();
            var element= driver.FindElementsByXPath("//*[@resource-id='android:id/numberpicker_input']");
            element[0].Click();
            element[0].Clear();
            element[0].SendKeys("Jun");

            element[1].Click();
            element[1].Clear();
            element[1].SendKeys("02");
          
            element[2].Click();
            element[2].Clear();
            element[2].SendKeys("2022");
            //           driver.FindElementByXPath("//*[@resource-id='android:id/numberpicker_input']").Clear();
            //driver.FindElementByXPath("//*[@resource-id='android:id/numberpicker_input']").SendKeys("02");
            driver.FindElementByXPath("//*[@text='Ok']").Click();
        }
    }
 }
