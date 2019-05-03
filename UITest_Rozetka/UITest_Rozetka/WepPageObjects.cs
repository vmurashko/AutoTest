using Atata;

namespace UITest_Rozetka.RozetkaWebPageObjects
{
    using _mainPage = MainPage;

    public class MainPage : Page<_mainPage>
    {
        [FindByName]
        public TextInput<_mainPage> search { get; private set; }

        [FindByName]
        public Button<_mainPage> submit { get; private set; }

        [PageObjectDefinition("span", ContainingClass = "filter-parametrs-i-l-i-text")]

    }

}
