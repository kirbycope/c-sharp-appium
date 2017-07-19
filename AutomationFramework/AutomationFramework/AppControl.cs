using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions.Internal;
using System.Drawing;

namespace AutomationFramework
{
    public class AppControl
    {
        By by;
        AppiumWebElement element;

        #region CONSTUCTORS

        /* Constructor */
        public AppControl(By by)
        {
            this.by = by;
            try { this.element = App.driver.FindElement(by); } catch { /* do nothing*/ }
        }

        /* Constructor */
        public AppControl(AppiumWebElement element)
        {
            this.element = element;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets the coordinates identifying the location of this element using various frames of reference.
        /// </summary>
        public ICoordinates Coordinates
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Coordinates;
                }
                else
                {
                    return App.driver.FindElement(this.by).Coordinates;
                }
            }
        }

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
        /// Gets a value indicating whether or not this element is enabled.
        /// </summary>
        public bool Enabled
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Enabled;
                }
                else
                {
                    return App.driver.FindElement(this.by).Enabled;
                }
            }
        }

        /// <summary>
        /// Gets the ID of this element.
        /// </summary>
        public string Id
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Id;
                }
                else
                {
                    return App.driver.FindElement(this.by).Id;
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether or not this element is selected.
        /// </summary>
        public bool Selected
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Selected;
                }
                else
                {
                    return App.driver.FindElement(this.by).Selected;
                }
            }
        }

        /// <summary>
        /// Gets a System.Drawing.Point object containing the coordinates of the upper-left corner of this element relative to the upper-left corner of the page.
        /// </summary>
        public Point Location
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Location;
                }
                else
                {
                    return App.driver.FindElement(this.by).Location;
                }
            }
        }

        /// <summary>
        /// Gets a OpenQA.Selenium.Remote.RemoteWebElement.Size object containing the height and width of this element.
        /// </summary>
        public Size Size
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.Size;
                }
                else
                {
                    return App.driver.FindElement(this.by).Size;
                }
            }
        }

        /// <summary>
        /// Gets the tag name of this element.
        /// </summary>
        public string TagName
        {
            get
            {
                if (this.element != null)
                {
                    return this.element.TagName;
                }
                else
                {
                    return App.driver.FindElement(this.by).TagName;
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
        /// Clears the content of this element.
        /// </summary>
        public void Clear()
        {
            if (this.element != null)
            {
                this.element.Clear();
            }
            else
            {
                App.driver.FindElement(this.by).Clear();
            }
        }

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

        /// <summary>
        /// Finds the first element in the page that matches the [OpenQA.Selenium.By] object.
        /// </summary>
        /// <param name="by">Mechanism to find element.</param>
        public AppControl FindElement(By by)
        {
            if (this.element != null)
            {
                AppiumWebElement element = this.element.FindElement(by);
                return new AppControl(element);
            }
            else
            {
                AppiumWebElement element = App.driver.FindElement(this.by).FindElement(by);
                return new AppControl(element);
            }
        }

        /// <summary>
        /// Simulates typing text into the element.
        /// </summary>
        /// <param name="text">The text to type into the element.</param>
        public void SendKeys(string text)
        {
            if (this.element != null)
            {
                this.element.SendKeys(text);
            }
            else
            {
                App.driver.FindElement(this.by).SendKeys(text);
            }
        }

        #endregion
    }
}
