using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.SplashScreenPages
{
    public class SplashScreenEnterWindow : BasePage
    {
        private static Button EnterLater => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/skip_auth_button\"]"), "Enter Later button");

        public SplashScreenEnterWindow() : base(EnterLater, "Splash Screen Enter Window")
        { }

        public void ClickEnterLater() => EnterLater.Click();
    }
}
