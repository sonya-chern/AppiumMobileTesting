using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class SplashScreenLocationWindow : ScreenPage
    {
        private static Label City = new(By.XPath($"//*[{PackageNameForXPath}current_settlement_text\"]"), "Your city label");

        private Button Confirm => new(By.XPath($"//*[{PackageNameForXPath}confirm_current_settlement_button\"]"), "Confirm button");

        public SplashScreenLocationWindow() : base(City, "Splash Screen Location")
        { }

        public string GetCityName() => City.GetText();

        public void ClickConfirm() => Confirm.Click();
    }
}
