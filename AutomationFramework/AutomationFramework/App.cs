using AutomationFramework.POMs;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AutomationFramework
{
    public class App
    {
        internal static AndroidDriver<AppiumWebElement> driver;

        #region APP METHODS

        /// <summary>
        /// Hides keyboard if present.
        /// </summary>
        public static void DismissKeyboard()
        {
            driver.HideKeyboard();
        }

        /// <summary>
        /// Gets a OpenQA.Selenium.Screenshot object representing the image of the page on the screen.
        /// </summary>
        public static void GetScreenshot()
        {
            driver.GetScreenshot();
        }

        /// <summary>
        /// Resets the current app.
        /// </summary>
        public static void ResetApp()
        {
            driver.ResetApp();
        }

        /// <summary>
        /// Close the Browser and Dispose of WebDriver.
        /// </summary>
        public static void Quit()
        {
            driver.Quit();
        }

        #endregion

        #region APP POMS

        // "Home" page
        public static HomePageObject HomePage
        {
            get
            {
                return new HomePageObject();
            }
        }

        #endregion
    }
}
