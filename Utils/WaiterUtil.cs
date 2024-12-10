using AppiumMobileTestProject.ConfigurationManager;
using AppiumMobileTestProject.DriverUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AppiumMobileTestProject.Utils
{
    public class WaiterUtil
    {
        private static WebDriverWait wait = new WebDriverWait(AppiumTestDriver.Instance,
                timeout: TimeSpan.FromSeconds(Convert.ToDouble(Configuration.TimeForDriverWait)))
        {
            PollingInterval = TimeSpan.FromSeconds(Convert.ToDouble(Configuration.PollingInterval)),
        };

        public static void WaitForElementExist(By locator)
        {
            wait.Until(e => e.FindElement(locator));
        }

        public static void WaitForEnabled(By locator)
        {
            wait.Until(e => e.FindElement(locator).Enabled);
        }

        public static void WaitForDisplayed(By locator)
        {
            wait.Until(e => e.FindElement(locator).Displayed);
        }
    }
}
