using Atata;
using UITest_Rozetka.RozetkaPageComponents.Pages;

namespace UITest_Rozetka.RozetkaPageComponents
{
    using _mainPage = RozetkaMainPage;

    public class RozetkaMainPage : Page<_mainPage>
    {
        //private AtataContext current;

        //public RozetkaMainPage(AtataContext current)
        //{
        //    this.current = current;
        //}

        [FindByName("search")]
        public TextInput<_mainPage> Search { get; private set; }

        [FindByContent("Найти")]
        public Button<_mainPage> Submit { get; private set; }

        [FindByXPath("@style='background-color: #F99'")]
        public Link<_mainPage> FirstRose { get; private set; }

        [FindByXPath("./a/span[@style='background - color: #666']")]
        public Link<_mainPage> SpaceGray { get; private set; }

        [FindByName("topurchasesfromcatalog")]
        public Button<_mainPage> ToBuy { get; private set; }

        //[PageObjectDefinition("span", ComponentTypeName = "", TargetName = "iPhone SE", ContainingClass = "filter-parametrs-i-l-i-checkbox")]

        public CheckBox<_mainPage> checkBox { get; private set; }

        public H1<_mainPage> Header { get; private set; }

        public PageObject<_mainPage> GotoPage()
        {
            return Go.To<_mainPage>();
        }

        public PageObject<_mainPage> SearchItem(string itemName)
        {
            return Search.Set(itemName).Submit.Click();
        }

        //var itemName = "iphone se";
        //var headerText = "Apple iPhone SE";
        //    RozetkaStart().
        //        Search.Set(itemName).
        //        Submit.Click().
        //        Header.Should.Equal(headerText);
    }

}
