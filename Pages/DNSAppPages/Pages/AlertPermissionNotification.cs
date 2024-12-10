using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class AlertPermissionNotification : BasePage
    {
        private static Button Allow => new(By.XPath($"//*[@resource-id=\"com.android.permissioncontroller:id/permission_allow_button\"]"), "Allow button");

        public AlertPermissionNotification() : base(Allow, "Alert Permission Notification")
        { }

        public void ClickEnterLater() => Allow.Click();
    }
}
