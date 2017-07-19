using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;

namespace AutomationFramework
{
    public class TestBase
    {
        string apiKey = ConfigurationManager.AppSettings["apiKey"];
        string apkPath = ConfigurationManager.AppSettings["apkPath"];
        string deviceName = ConfigurationManager.AppSettings["deviceName"];
        Uri remoteAddress = new Uri(ConfigurationManager.AppSettings["remoteAddress"]);

        // Before the Test Suite runs, start the App
        [OneTimeSetUp]
        public void SetUpAppium()
        {
            // Define the DesiredCapabilities
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("automationName", "Appium");
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("deviceName", deviceName);

            // Handle the active configuration
            if (remoteAddress.ToString().Contains("127.0.0.1"))
            {
                desiredCapabilities.SetCapability("app", apkPath);
            }
            else
            {
                desiredCapabilities.SetCapability("testobject_api_key", apiKey);
                desiredCapabilities.SetCapability("platformVersion", "7");
                desiredCapabilities.SetCapability("phoneOnly", "true");
                desiredCapabilities.SetCapability("tabletOnly", "false");
                desiredCapabilities.SetCapability("privateDevicesOnly", "false");
            }

            // Initialize the driver
            App.driver = new AndroidDriver<AppiumWebElement>(remoteAddress, desiredCapabilities);

            // Use a higher value if your mobile elements take time to show up
            App.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        // After the Test Suite runs, quit the App
        [OneTimeTearDown]
        public void TearDownAppium()
        {
            App.Quit();
        }

        // Before each Test, reset the App
        [SetUp]
        public void ResetApp()
        {
            App.ResetApp();
        }
    }
}
