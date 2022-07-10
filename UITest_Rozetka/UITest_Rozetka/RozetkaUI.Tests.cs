using Atata;
using NUnit.Framework;
using UITest_Rozetka.RozetkaPageComponents;
using UITest_Rozetka.RozetkaPageComponents.Pages;
using UITest_Rozetka.RozetkaWebPageObjects;

namespace RozetkaWebPageObjects
{
     public class RozetkaTests : TestInitializing
    {
        public Page<Pages> Page { get; set; }

        [Test]
        public void CallPages_ToOpen_MainPage()
        {
            var expTitle = "Интернет-магазин ROZETKA™: официальный сайт самого популярного онлайн-гипермаркета в Украине";
            var actTitle = Pages.MainPage.Content;
            
            RozetkaStart().PageTitle.Should.Equal(expTitle);
            //Assert.AreEqual(actTitle, expTitle);
        }

        [Test]
        public void CallPages2()
        {
            var expTitle = "Интернет-магазин ROZETKA™: официальный сайт самого популярного онлайн-гипермаркета в Украине";
            Pages.MainPage.GotoPage().Should.Equals(expTitle);
        }

        [Test]
        [System.Obsolete]
        public void RequestedItemFound_BySearch_AddedToBasket()
        {
            var itemName = "iphone se";
            var headerText = "Apple iPhone SE";
            var basketHeader = "Корзина";
            RozetkaStart().
                Search.Set(itemName).
                Submit.Click().
                Header.Should.Equal(headerText).
                FirstRose.Click().
                Header.Should.Contain(headerText).
                ToBuy.ClickAndGo<ProductPage>().Wait(5).
                Header.Should.Contain(headerText).
                Basket.Click().Wait(5).
                BasketHeader.Should.Contain(basketHeader).
                ConfirmOrder.Exists();
        }

        [Test]
        public void GetPhoneByColors_GetRose()
        {
            var itemName = "iPhone SE";
            RozetkaStart().
            SearchItem(itemName);
            //Pages mainPage = new Pages();
            //RozetkaMainPage mainPage = new RozetkaMainPage(AtataContext.Current);
            //Pages.MainPage.GotoPage();
            //mainPage.SearchItem2(itemName);
            
            //Pages.MainPage.SearchItem2(itemName);
            //Pages.MainPage.SearchItem(itemName);
        }
    }
}
