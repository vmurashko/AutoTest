using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using NUnit.Framework;
using UITest_Rozetka.RozetkaPageComponents.Pages;

namespace UITest_Rozetka.RozetkaPageComponents
{
    [TestFixture]
    public class TestInitializing
    {
        [SetUp]
        [Obsolete]
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

        protected RozetkaMainPage RozetkaStart()
        {
            return Go.To<RozetkaMainPage>();
        }
    }
}
