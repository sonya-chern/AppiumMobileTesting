using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.CatalogSectionsSubPages
{
    public class BasePageWithFilter : ScreenPage
    {
        protected static Button Filters => new(By.XPath($"//*[{PackageNameForXPath}filter_button\"]"), "Filters button");

        public BasePageWithFilter(string name) : base(Filters, name)
        {
        }

        public void ClickFilters() => Filters.Click();
    }
}
