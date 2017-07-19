using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace AutomationFramework
{
    public class AppControl
    {
        By by;
        AppiumWebElement element;

        /* Constructor */
        public AppControl(By by)
        {
            this.by = by;
        }

        /* Constructor */
        public AppControl(AppiumWebElement element)
        {
            this.element = element;
        }

        #region PROPERTIES

        /// <summary>
        /// Gets a value indicating whether or not this element is displayed.
        /// </summary>
        public bool Displayed
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Displayed;
                }
                else
                {
                    return App.driver.FindElement(this.by).Displayed;
                }
            }
        }

        /// <summary>
        /// Gets the innerText of this element, without any leading or trailing whitespace, and with other whitespace collapsed.
        /// </summary>
        public string Text
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Text;
                }
                else
                {
                    return App.driver.FindElement(this.by).Text;
                }
            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Clicks this element.
        /// </summary>
        public void Click()
        {
            if (this.element != null)
            {
                this.element.Click();
            }
            else
            {
                App.driver.FindElement(this.by).Click();
            }
        }
        
        #endregion
    }
}
