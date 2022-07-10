using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata; 

namespace UITest_Rozetka.RozetkaPageComponents.Pages
{
    using _pages = Pages;
    public class Pages : Page<_pages>
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

        public static RozetkaMainPage MainPage
        { get { return GetPage<RozetkaMainPage>(); } }

        public static ProductPage ProdPage
        { get { return GetPage<ProductPage>(); } }

        public static CatalogPage CatalogPage
        { get { return GetPage<CatalogPage>(); } }
    }
}
