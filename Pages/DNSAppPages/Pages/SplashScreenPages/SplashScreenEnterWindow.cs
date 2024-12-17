using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.SplashScreenPages
{
    public class SplashScreenEnterWindow : ScreenPage
    {
        private static Button EnterLater => new(By.XPath($"//*[{PackageNameForXPath}skip_auth_button\"]"), "Enter Later button");

        public SplashScreenEnterWindow() : base(EnterLater, "Splash Screen Enter Window")
        { }

        public void ClickEnterLater() => EnterLater.Click();
    }
}
