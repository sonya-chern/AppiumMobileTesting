using AppiumMobileTestProject.ConfigurationManager;
using AppiumMobileTestProject.DriverAndUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AppiumMobileTestProject.Utils
{
    public class WaiterUtil
    {
        private static WebDriverWait Wait => new(AppiumTestDriver.Instance,
                timeout: TimeSpan.FromSeconds(Convert.ToDouble(Configuration.TimeForDriverWait)));

        public static void WaitForEnabled(By locator)
        {
            WaitForSearch(locator);
            Wait.Until(e => e.FindElement(locator).Enabled);
        }

        public static void WaitForSearch(By locator)
        {
            Wait.Until(e => e.FindElements(locator).Count > 0);
        }

        public static List<IWebElement> WaitAndGetListWebElements(By locator)
        {
            WaitForSearch(locator);
            return AppiumTestDriver.FindElements(locator);
        }
    }
}
