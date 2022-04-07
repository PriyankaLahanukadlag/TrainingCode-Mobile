using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidAutomation
{
    [TestClass]
    public class NativeAppTest2
    {
        [TestMethod]
       public void KhanSwipeTouchActionTest() {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");//If we have apk file 

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Click on Dismiss 
            driver.FindElementByXPath("//*[@text='Dismiss']").Click();

            driver.FindElementByAccessibilityId("Search tab").Click();

            //Click on Arts and humanities 
            driver.FindElementByXPath("//*[@text='Arts and humanities']").Click();

            Size s = driver.Manage().Window.Size;
            Console.WriteLine(s.Width);
            Console.WriteLine(s.Height);

            Double x1 = s.Width / 2;
            Double y1 = s.Height * 0.75;

            Double x2 = s.Width / 2;
            Double y2 = s.Height * 0.25;

            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(x2);
            Console.WriteLine(y2);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while(driver.FindElementsByXPath("//*[@text='Art of Asia']").Count==0)
            {
                TouchAction action = new TouchAction(driver);
                action.Press(x1,y1).Wait(1000).MoveTo(x2, y2).Release().Perform();
  
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElementByXPath("//*[@text='Art of Asia']").Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while (driver.FindElementsByXPath("//*[@text='South Asia']").Count == 0)
            {
                TouchAction action = new TouchAction(driver);
                action.Press(x1, y1).Wait(1000).MoveTo(x2, y2).Release().Perform();

            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElementByXPath("//*[@text='South Asia']").Click();


        }
        [TestMethod]
        public void KhanSwipeScrollableTest()
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

            driver.FindElementByAccessibilityId("Search tab").Click();

            //Click on Arts and humanities 
            driver.FindElementByXPath("//*[@text='Arts and humanities']").Click();
            string visible_text = "Asia";
            
            //Scrollable Use
            driver.FindElementByAndroidUIAutomator(
                                        "new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + visible_text + "\").instance(0))").Click();

        }
        [TestMethod]
        public void KhanSwipeMobileUiCommandTest()
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

            driver.FindElementByAccessibilityId("Search tab").Click();

            //Click on Arts and humanities 
            driver.FindElementByXPath("//*[@text='Arts and humanities']").Click();

            //Mobile Command refer appium.Io
       
            Dictionary<string, object> dic = new Dictionary<string, object>();

            dic.Add("strategy", "-android uiautomator");

            dic.Add("selector", "UiSelector().textContains(\"Asia\")");


            driver.ExecuteScript("mobile: scroll", dic);

            driver.FindElementByXPath("//*[@text='Art of Asia']").Click();

        }
        [TestMethod]
        public void KhanListSmsTest()
        {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("app", @"C:\Users\priyanka.kadlag\Downloads\khan-academy-7-3-2 (1).apk");//If we have apk file 

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("Max", "2");
            dynamic a= driver.ExecuteScript("mobile: listSms",dic);
            Console.WriteLine(a[0]);
        }
        [TestMethod]
        public void KhanSwipeAdbCommandTest()
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

            driver.FindElementByAccessibilityId("Search tab").Click();

            //Click on Arts and humanities 
            driver.FindElementByXPath("//*[@text='Arts and humanities']").Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while (driver.FindElementsByXPath("//*[@text='Art of Asia']").Count == 0)
            { 
            
            }
        }
    }
}
