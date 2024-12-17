using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.CartSubPages;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using AppiumMobileTestProject.Utils;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class CartWindow : ScreenPage
    {
        private Label EmptyContent = new(By.XPath($"//*[{PackageNameForXPath}empty_content_summary_text\"]"), "Empty Content text label");

        private Label Snackbar = new(By.XPath($"//*[{PackageNameForXPath}snackbar_text\"]"), "Snackbar label");

        private Button EmptyContentAction => new(By.XPath($"//*[{PackageNameForXPath}empty_content_action_button\"]"), "Empty Content Action button");

        private static Button Location => new(By.XPath($"//*[{PackageNameForXPath}change_current_settlement_button\"]"), "Location button");

        private List<IWebElement> ProductsList => WaiterUtil.WaitAndGetListWebElements(By.XPath($"//*[{PackageNameForXPath}item_card\"]"));

        public MainToolbarForm MainToolbarForm => new();

        public NotificationForDeletingProduct NotificationForDeletingProduct => new();

        private Dictionary<string, string> ProductParams = new()
        {
            { "ProductName", $"//*[{PackageNameForXPath}product_title_text\"]" },
            { "ProductPrice", $"//*[{PackageNameForXPath}cart_item_sum_view_current_sum_text\"]" },
            { "DeleteProduct", $"//*[{PackageNameForXPath}decrement_button\"]" }
        };

        public CartWindow() : base(Location, "Cart Window")
        { }

        public string GetCartTextFromEmptyContentLabel() => EmptyContent.GetText();

        public bool GoToCatalogBtnIsDisplayed() => EmptyContentAction.IsDisplayed();

        public string GetTextFromSnackbar() => Snackbar.GetText();

        public string GetProductInCart(string fullProductName)
        {
            foreach (var item in ProductsList)
            {
                var product = item.FindElement(By.XPath(ProductParams["ProductName"]));
                if (fullProductName.Contains(product.Text))
                {
                    return product.Text;
                }
            }
            return string.Empty;
        }

        public string GetProductPriceInCart(string productName)
        {
            foreach (var item in ProductsList)
            {
                var product = item.FindElement(By.XPath(ProductParams["ProductName"]));
                if (product.Text == productName)
                {
                    return item.FindElement(By.XPath(ProductParams["ProductPrice"])).Text;
                }
            }
            return string.Empty;
        }

        public void DeleteProduct(string productName)
        {
            foreach (var item in ProductsList)
            {
                var product = item.FindElement(By.XPath(ProductParams["ProductName"]));
                if (product.Text == productName)
                {
                    item.FindElement(By.XPath(ProductParams["DeleteProduct"])).Click();
                }
            }
        }
    }
}
