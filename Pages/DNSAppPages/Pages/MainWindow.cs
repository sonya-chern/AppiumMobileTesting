using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class MainWindow : ScreenPage
    {
        private static Label NewInDNS = new(By.XPath($"//*[{PackageNameForXPath}news_title_text\"]"), "New in DNS label");

        private Button CityLocation = new(By.XPath($"//*[{PackageNameForXPath}change_current_settlement_button\"]"), "City Location button");

        private Button Confirm => new(By.XPath($"//*[{PackageNameForXPath}confirm_current_settlement_button\"]"), "Confirm button");

        public MainToolbarForm mainToolbarForm => new();
            
        public MainWindow() : base(NewInDNS, "Main Window")
        { }

        public string GetCityLocation() => CityLocation.GetText();

        public void ClickConfirm() => Confirm.Click();
    }
}
