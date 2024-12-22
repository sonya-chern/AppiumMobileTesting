using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.SplashScreenPages
{
    public class SplashScreenLocationWindow : BasePage
    {
        private static Label City = new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/current_settlement_text\"]"), "Your city label");

        private Button Confirm => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/confirm_current_settlement_button\"]"), "Confirm button");

        public SplashScreenLocationWindow() : base(City, "Splash Screen Location")
        { }

        public string GetCityName() => City.GetText();

        public void ClickConfirm() => Confirm.Click();
    }
}
