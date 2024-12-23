using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Toolbars
{
    public class MainToolbarForm : BasePage
    {
        private const string TextFromButtonNotification = "content-desc";

        private static Button Home => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/nav_home\"]"), "Home button");

        private Button Outlets => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/nav_outlets\"]"), "Outlets button");

        private Button Catalog => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/nav_catalog\"]"), "Catalog button");

        private Button Cart => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/nav_cart\"]"), "Cart button");

        private Button Profile => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/nav_profile\"]"), "Profile button");

        public MainToolbarForm() : base(Home, "Main Toolbar Form")
        {
        }

        public void ClickHome() => Home.Click();

        public void ClickOutlets() => Outlets.Click();

        public void ClickCatalog() => Catalog.Click();

        public void ClickProfile() => Profile.Click();

        public void ClickCart() => Cart.Click();

        public string GetCartNotification() => Cart.GetAttributeText(TextFromButtonNotification);
    }
}
