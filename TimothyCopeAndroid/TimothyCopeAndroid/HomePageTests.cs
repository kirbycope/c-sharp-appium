using AutomationFramework;
using NUnit.Framework;

namespace TimothyCopeAndroid
{
    [TestFixture]
    public class HomePageTests : TestBase
    {
        [Test]
        public void Example001()
        {
            // Take a screenshot
            App.GetScreenshot();
            // Assert: The logo element is not displayed
            Assert.IsFalse(App.HomePage.imgLogo.Displayed);
        }
    }
}
