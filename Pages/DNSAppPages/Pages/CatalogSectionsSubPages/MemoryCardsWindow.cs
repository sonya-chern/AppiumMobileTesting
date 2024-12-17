using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Pages.CatalogSectionsSubPages;
using AppiumMobileTestProject.Utils;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class MemoryCardsWindow : BasePageWithFilter
    {
        private Button Filter(string name) => new(By.XPath($"//*[{PackageNameForXPath}title_text\" and @text=\"{name}\"]"), $"Filter '{name}' button");

        private Button Product(string name) => new(By.XPath($"//*[{PackageNameForXPath}product_title_text\" and @text=\"{name}\"]"), $"Product '{name}' button");

        private List<IWebElement> Prices => WaiterUtil.WaitAndGetListWebElements(By.XPath($"//*[{PackageNameForXPath}current_price_text\"]"));

        private List<IWebElement> ProductName => WaiterUtil.WaitAndGetListWebElements(By.XPath($"//*[{PackageNameForXPath}product_title_text\"]"));

        public MemoryCardsWindow() : base("Memory Cards Window")
        { }

        public bool IsFilterDisplayed(string filter) => Filter(filter).IsDisplayed();

        public void OpenProductPage(string productName) => Product(productName).Click();

        public List<string> GetPrices()
        {
            var list = new List<string>();
            foreach (var item in Prices)
            {
                list.Add(item.Text);
            }
            return list;
        }

        public List<string> GetProductNames()
        {
            var list = new List<string>();
            foreach (var item in ProductName)
            {
                list.Add(item.Text);
            }
            return list;
        }
    }
}
