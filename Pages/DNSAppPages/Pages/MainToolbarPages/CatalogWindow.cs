using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class CatalogWindow : ScreenPage
    {
        private static TextBox SearchField => new(By.XPath("//*[@resource-id=\"ru.dns.shop.android:id/search_edit\"]"), "Search textbox");

        public MainToolbarForm MainToolbarForm => new();

        public CatalogWindow() : base(SearchField, "Catalog Window")
        { }

        public void ClickAccessoriesAndServices()
        {
            DriverUtils.ClickKeyboardPerform();
            DriverUtils.ClickKeyboardKeyDownAndPerform((int)CatalogSections.AccessoriesAndServices);
        }

    }

    enum CatalogSections
    {
        AccessoriesAndServices = 14
    }
}
