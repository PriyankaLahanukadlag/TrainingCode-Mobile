using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidAutomation
{
    [TestClass]
    public class clouddevice
    {
        [TestMethod]
        public void ValidCreadentialTest()
        {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
           // option.AddAdditionalCapability("platformName", "ios");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("browserstack.user","priyankakadlag_fYTHjN");
            option.AddAdditionalCapability("browserstack.key", "pAxyvzgbQssr1BJHRUx3");
            option.AddAdditionalCapability("app", "bs://16bb8159e9abc0563e31b448ea047e227aa56433");//If we have apk file 


            // Specify device and os_version
            option.AddAdditionalCapability("device", "Samsung Galaxy S10e");
            option.AddAdditionalCapability("os_version", "9.0");

            // Specify the platform name
            option.PlatformName = "Android";

            // Set other BrowserStack capabilities
            option.AddAdditionalCapability("project", "Khan Academy Project - Yash");
            option.AddAdditionalCapability("build", "Khan Academy Build - Yash");
            option.AddAdditionalCapability("name", "khan - sign in test - yash");
            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), option);
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
        public void sampleApkTest()
        {
            DriverOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            // option.AddAdditionalCapability("platformName", "ios");
            option.AddAdditionalCapability("deviceName", "mobapp");
            option.AddAdditionalCapability("browserstack.user", "priyankakadlag_fYTHjN");
            option.AddAdditionalCapability("browserstack.key", "pAxyvzgbQssr1BJHRUx3");
            option.AddAdditionalCapability("app", "bs://16bb8159e9abc0563e31b448ea047e227aa56433");//If we have apk file 


            // Specify device and os_version
            option.AddAdditionalCapability("device", "Samsung Galaxy S10e");
            option.AddAdditionalCapability("os_version", "9.0");

            // Specify the platform name
            option.PlatformName = "Android";

            // Set other BrowserStack capabilities
            option.AddAdditionalCapability("project", "Khan Academy Project - Yash");
            option.AddAdditionalCapability("build", "Khan Academy Build - Yash");
            option.AddAdditionalCapability("name", "khan - sign in test - yash");
            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), option);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestMethod]
        public void iosSampleNativeTest()
        {
           
            AppiumOptions caps = new AppiumOptions();
            // Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", "priyankakadlag_fYTHjN");
            caps.AddAdditionalCapability("browserstack.key", "pAxyvzgbQssr1BJHRUx3");
            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "bs://444bd0308813ae0dc236f8cd461c02d3afa7901d");
            // Specify device and os_version
            caps.AddAdditionalCapability("device", "iPhone XS");
            caps.AddAdditionalCapability("os_version", "12");
            // Specify the platformName
            caps.PlatformName = "iOS";

            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "browserstack-build-1");
            caps.AddAdditionalCapability("name", "first_test");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            TouchAction action = new TouchAction(driver);
            action.Tap(driver.FindElementByXPath("//*[@name='Alert Button']")).Perform();
            string str = driver.FindElementByXPath("//*[contains(@name,'a native')]").Text;
            Console.WriteLine(str);
            driver.FindElementByXPath("//*[@name='OK']").Click();
            
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod]
        public void recordscriptTest()
        {

            AppiumOptions caps = new AppiumOptions();
            // Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", "priyankakadlag_fYTHjN");
            caps.AddAdditionalCapability("browserstack.key", "pAxyvzgbQssr1BJHRUx3");
            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "bs://444bd0308813ae0dc236f8cd461c02d3afa7901d");
            // Specify device and os_version
            caps.AddAdditionalCapability("device", "iPhone XS");
            caps.AddAdditionalCapability("os_version", "12");
            // Specify the platformName
            caps.PlatformName = "iOS";

            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "browserstack-build-1");
            caps.AddAdditionalCapability("name", "first_test");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.StartRecordingScreen();
            TouchAction action = new TouchAction(driver);
            action.Tap(driver.FindElementByXPath("//*[@name='Alert Button']")).Perform();
            string str = driver.FindElementByXPath("//*[contains(@name,'a native')]").Text;
            Console.WriteLine(str);
            driver.FindElementByXPath("//*[@name='OK']").Click();
            string str1 =driver.StopRecordingScreen();
            File.WriteAllBytes("priya.mp4", Convert.FromBase64String(str1));

            dynamic output= driver.ExecuteScript("mobile: getDeviceTime");
            Console.WriteLine(output);
            Thread.Sleep(5000);
            driver.Quit();
        }

    }
  


    }
