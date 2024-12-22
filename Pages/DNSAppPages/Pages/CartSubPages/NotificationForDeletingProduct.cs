using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.CartSubPages
{
    public class NotificationForDeletingProduct : BasePage
    {
        private static Button Delete => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/positive_button\"]"), "Delete button");

        private Button Cancel => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/negative_button\"]"), "Cancel button");

        public NotificationForDeletingProduct() : base(Delete, "Notification For Deleting Product Window")
        { }

        public void ClickDelete() => Delete.Click();

        public void ClickCancel() => Cancel.Click();
    }
}
