using Atata;
using NUnit.Framework;
using UITest_Rozetka.RozetkaWebPageObjects;

namespace RozetkaWebPageObjects
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().
                UseChrome().
                WithArguments("start-maximized").
                UseBaseUrl("https://rozetka.com.ua/").
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }

    public class RozetkaTests : UITestFixture
    {
        [Test]
        public void OpenRozetkaMainPage()
        {
            Go.To<MainPage>().
                search.Set("iphone").
                submit.Click();
        }
    }
}
