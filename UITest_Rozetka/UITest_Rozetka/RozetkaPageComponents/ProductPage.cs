using Atata;

namespace UITest_Rozetka.RozetkaPageComponents
{
    using _productPage = ProductPage;

    public class ProductPage : Page<_productPage>
    {
        public H1<_productPage> Header { get; private set; }

        [FindByClass("btn-link novisited detail-in-cart-btn")]
        public Link<_productPage> Basket { get; private set; }

        [FindByClass("cart-header ng-star-inserted")]
        public H2<_productPage> BasketHeader { get; private set; }

        [FindByClass("btn-link-green btn-link cart-check-button")]
        public Button<_productPage> ConfirmOrder { get; private set; }
    }
}
