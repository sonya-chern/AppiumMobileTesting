using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class MainWindow : BasePage
    {
        private static Image LogoDNS => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/logo_image\"]"), "Logo DNS image");

        private Button CityLocation => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/change_current_settlement_button\"]"), "City Location button");

        private Button Confirm => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/confirm_current_settlement_button\"]"), "Confirm button");

        public MainToolbarForm MainToolbarForm => new();

        public MainWindow() : base(LogoDNS, "Main Window")
        { }

        public string GetCityLocation() => CityLocation.GetText();

        public void ClickConfirm() => Confirm.Click();
    }
}
