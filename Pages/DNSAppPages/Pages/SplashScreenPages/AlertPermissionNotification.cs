using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.SplashScreenPages
{
    public class AlertPermissionNotification : BasePage
    {
        private Button Allow => new(By.XPath($"//*[@resource-id=\"com.android.permissioncontroller:id/permission_allow_button\"]"), "Allow button");

        private static Label AlertText => new(By.XPath("//*[@resource-id=\"com.android.permissioncontroller:id/permission_message\"]"), "Alert Text label");

        public AlertPermissionNotification() : base(AlertText, "Alert Permission Notification")
        { }

        public void ClickEnterLater() => Allow.Click();
    }
}
