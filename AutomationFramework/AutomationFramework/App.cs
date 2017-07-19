using AutomationFramework.POMs;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AutomationFramework
{
    public class App
    {
        internal static AndroidDriver<AppiumWebElement> driver;

        #region APP METHODS

        /// <summary>
        /// Presses the "Back" hardware button.
        /// </summary>
        public static void Back()
        {
            driver.PressKeyCode(AndroidKeyCode.Back);
        }

        /// <summary>
        /// Hides keyboard if present.
        /// </summary>
        public static void DismissKeyboard()
        {
            driver.HideKeyboard();
        }
        
        /// <summary>
        /// Presses the enter key in the app.
        /// </summary>
        public static void PressEnter()
        {
            driver.PressKeyCode(AndroidKeyCode.Enter);
        }

        /// <summary>
        /// Presses the volume down button on the device.
        /// </summary>
        public static void PressVolumeDown()
        {
            driver.PressKeyCode(AndroidKeyCode.Keycode_VOLUME_DOWN);
        }

        /// <summary>
        /// Presses the volume up button on the device.
        /// </summary>
        public static void PressVolumeUp()
        {
            driver.PressKeyCode(AndroidKeyCode.Keycode_VOLUME_UP);
        }

        /// <summary>
        /// Resets the current app.
        /// </summary>
        public static void ResetApp()
        {
            driver.ResetApp();
        }

        /// <summary>
        /// Gets a OpenQA.Selenium.Screenshot object representing the image of the page on the screen.
        /// </summary>
        public static void Screenshot()
        {
            driver.GetScreenshot();
        }

        /// <summary>
        /// Scroll down until an element that matches the ID is shown on the screen.
        /// </summary>
        public static void ScrollDownTo(string id)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            // Scroll until the element is in view
            while (driver.FindElement(By.Id(id)).Displayed == false)
            {
                // Swipe from middle to top (to scroll down)
                driver.Swipe(middleX, middleY, middleX, 0, 250);
            }
        }

        /// <summary>
        /// Scroll up until an element that matches the id is shown on the screen.
        /// </summary>
        /// <param name="marked"></param>
        public static void ScrollUpTo(string id)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            // Scroll until the element is in view
            while (driver.FindElement(By.Id(id)).Displayed == false)
            {
                // Swipe from middle to bottom (to scroll up)
                driver.Swipe(middleX, middleY, middleX, screenHeight, 250);
            }
        }

        /// <summary>
        /// Changes the device (iOS) or current activity (Android) orientation to landscape mode.
        /// </summary>
        public static void SetOrientationLandscape()
        {
            driver.Orientation = ScreenOrientation.Landscape;
        }

        /// <summary>
        /// Changes the device (iOS) or current activity (Android) orientation to portrait mode.
        /// </summary>
        public static void SetOrientationPortrait()
        {
            driver.Orientation = ScreenOrientation.Portrait;
        }

        /// <summary>
        /// Performs a left to right swipe gesture.
        /// </summary>
        public static void SwipeLeftToRight()
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            // Swipe from the left the the right (to scroll left)
            driver.Swipe(middleX, middleY, screenWidth, middleY, 250);
        }

        /// <summary>
        /// Performs a left to right swipe gesture on an element.
        /// </summary>
        /// <param name="appControl"></param>
        public static void SwipeLeftToRight(AppControl appControl)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            // Get the AppControl's location (where top-right of element is located)
            int locationX = appControl.Location.X;
            int locationY = appControl.Location.Y;
            // Get the size of the element
            int sizeHeight = appControl.Size.Height;
            int sizeWidth = appControl.Size.Width;
            // Calculate the position of the middle of the element
            int middleX = locationX + (sizeWidth / 2);
            int middleY = locationY + (sizeHeight / 2);
            // Swipe from the middle of the element to the right (to scroll left)
            driver.Swipe(middleX, middleY, screenWidth, middleY, 250);
        }

        /// <summary>
        /// Scrolls up by performing a swipe gesture from the middle of the screen to the bottom
        /// </summary>
        public static void SwipeMiddleToBottom(int swipes = 1)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            for (int i = 0; i < swipes; i++)
            {
                // Swipe from the middle to the bottom (to scroll up)
                driver.Swipe(middleX, middleY, middleX, screenHeight, 250);
            }
        }

        /// <summary>
        /// Scrolls down by performing a swipe gesture from the middle of the screen to the top
        /// </summary>
        public static void SwipeMiddleToTop(int swipes = 1)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            for (int i = 0; i < swipes; i++)
            {
                // Swipe from the middle to the top (to scroll down)
                driver.Swipe(middleX, middleY, middleX, 0, 250);
            }
        }

        /// <summary>
        /// Performs a right to left swipe gesture.
        /// </summary>
        public static void SwipeRightToLeft()
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            int middleX = screenWidth / 2;
            int middleY = screenHeight / 2;
            // Swipe from the right the the left (to scroll right)
            driver.Swipe(middleX, middleY, 0, middleY, 250);
        }

        /// <summary>
        /// Performs a right to left swipe gesture on an element.
        /// </summary>
        /// <param name="appControl"></param>
        public static void SwipeRightToLeft(AppControl appControl)
        {
            // Get the screen dimensions
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;
            // Get the AppControl's location (where top-right of element is located)
            int locationX = appControl.Location.X;
            int locationY = appControl.Location.Y;
            // Get the size of the element
            int sizeHeight = appControl.Size.Height;
            int sizeWidth = appControl.Size.Width;
            // Calculate the position of the middle of the element
            int middleX = locationX + (sizeWidth / 2);
            int middleY = locationY + (sizeHeight / 2);
            // Swipe from the middle of the element to the left (to scroll right)
            driver.Swipe(middleX, middleY, 0, middleY, 250);
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
