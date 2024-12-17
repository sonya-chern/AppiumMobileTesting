using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class AccessoriesAndServicesWindow : ScreenPage
    {
        private static Image Image = new(By.XPath($"//*[{PackageNameForXPath}image\"]"), "Accessories And Services Image");

        public AccessoriesAndServicesWindow() : base(Image, "Accessories And Services Window")
        { }

        public void ClickForMobiles() => DriverUtils.ClickKeyboardKeyDownAndPerform((int)AccessoriesAndServicesSections.ForMobiles);

    }

    enum AccessoriesAndServicesSections
    {
        ForMobiles = 1
    }
}
