using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class ProductWindow : ScreenPage
    {
        private static Image ProdPhoto => new(By.XPath($"//*[{PackageNameForXPath}photo_image\"]"), $"Photo image");

        private Button Price => new(By.XPath($"//*[{PackageNameForXPath}current_price_text\"]"), $"Price button");

        private Button Buy => new(By.XPath($"//*[{PackageNameForXPath}buy_button\" and @text=\"Купить\"]"), $"Buy button");

        private Button InCart => new(By.XPath($"//*[{PackageNameForXPath}buy_button\" and @text=\"В корзине\"]"), $"In Cart button");

        public MainToolbarForm MainToolbarForm => new();

        public ProductWindow() : base(ProdPhoto, "Product Window")
        { }

        public string GetPrice() => Price.GetText();

        public void ClickBuy() => Buy.Click();

        public string GetTextFromButtonAfterPurchase() => InCart.GetText();
    }
}
