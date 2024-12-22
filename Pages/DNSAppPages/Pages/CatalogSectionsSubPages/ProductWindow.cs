using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class ProductWindow : BasePage
    {
        private static Label ProdText => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/product_title_text\"]"), $"Product text");

        private Button Price => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/current_price_text\"]"), $"Price button");

        private Button Buy => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/buy_button\" and @text=\"Купить\"]"), $"Buy button");

        private Button InCart => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/buy_button\" and @text=\"В корзине\"]"), $"In Cart button");

        public MainToolbarForm MainToolbarForm => new();

        public ProductWindow() : base(ProdText, "Product Window")
        { }

        public string GetPrice() => Price.GetText();

        public void ClickBuy() => Buy.Click();

        public string GetTextFromButtonAfterPurchase() => InCart.GetText();
    }
}
