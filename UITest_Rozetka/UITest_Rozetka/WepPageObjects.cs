using Atata;

namespace UITest_Rozetka.RozetkaWebPageObjects
{
    using _mainPage = MainPage;

    public class MainPage : Page<_mainPage>
    {
        [FindByName]
        public TextInput<_mainPage> search { get; private set; }

        [FindByName("submit")]
        public Button<_mainPage> submit { get; private set; }

        [PageObjectDefinition("span", ComponentTypeName = "", TargetName = "iPhone SE", ContainingClass = "filter-parametrs-i-l-i-checkbox")]

        public CheckBox<_mainPage> checkBox { get; private set; }
    }

}
