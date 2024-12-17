using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class MainWindow : ScreenPage
    {
        private static Image LogoDNS => new(By.XPath($"//*[{PackageNameForXPath}logo_image\"]"), "Logo DNS image");

        private Button CityLocation => new(By.XPath($"//*[{PackageNameForXPath}change_current_settlement_button\"]"), "City Location button");

        private Button Confirm => new(By.XPath($"//*[{PackageNameForXPath}confirm_current_settlement_button\"]"), "Confirm button");

        public MainToolbarForm MainToolbarForm => new();

        public MainWindow() : base(LogoDNS, "Main Window")
        { }

        public string GetCityLocation() => CityLocation.GetText();

        public void ClickConfirm() => Confirm.Click();
    }
}
