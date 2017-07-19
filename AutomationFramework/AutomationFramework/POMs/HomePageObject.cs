using OpenQA.Selenium;

namespace AutomationFramework.POMs
{
    public class HomePageObject
    {
        // Constructor
        public HomePageObject()
        {
            /* Empty Constructor */
        }

        #region PAGE ELEMENTS

        // Example AppControl
        public AppControl imgLogo
        {
            get
            {
                return new AppControl(By.Id("logo"));
            }
        }

        #endregion

        #region PAGE METHODS

        #endregion
    }
}
