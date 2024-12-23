using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.CatalogSectionsSubPages
{
    public class BasePageWithFilter : BasePage
    {
        protected static Button Filters => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/filter_button\"]"), "Filters button");

        public BasePageWithFilter(string name) : base(Filters, name)
        {
        }

        public void ClickFilters() => Filters.Click();
    }
}
