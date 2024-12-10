using AppiumMobileTestProject.Elements;

namespace AppiumMobileTestProject.Pages.DNSAppPages
{
    public class ScreenPage : BasePage
    {
        protected const string PackageNameForXPath = "@resource-id=\"ru.dns.shop.android:id/";

        public ScreenPage(BaseElement element, string name) : base(element, name)
        {
        }
    }
}
