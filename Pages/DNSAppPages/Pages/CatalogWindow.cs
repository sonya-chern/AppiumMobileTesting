using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class CatalogWindow : ScreenPage
    {
        private Button СatalogSection(string sectionName) => new (By.XPath($"//*[{PackageNameForXPath}title_text\" and @text=\"{sectionName}\"]"), "Сatalog Section button");

        private static Button Chevron = new(By.XPath($"//*[{PackageNameForXPath}chevron_image\"]"), "Chevron button");

        public MainToolbarForm mainToolbarForm => new();
            
        public CatalogWindow() : base(Chevron, "Catalog Window")
        { }
    }
}
