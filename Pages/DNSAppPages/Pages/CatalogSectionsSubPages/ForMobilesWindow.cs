using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class ForMobilesWindow : ScreenPage
    {
        private static Button Chevron = new(By.XPath($"//*[{PackageNameForXPath}chevron_image\"]"), "Chevron button");

        public ForMobilesWindow() : base(Chevron, "Accessories And Services Window")
        { }

        public void ClickМemoryCards() => DriverUtils.ClickKeyboardKeyDownAndPerform((int)ForMobilesSections.MemoryCards);

    }

    enum ForMobilesSections
    {
        MemoryCards = 12
    }
}
