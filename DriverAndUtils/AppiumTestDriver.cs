using AppiumMobileTestProject.ConfigurationManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;


namespace AppiumMobileTestProject.DriverAndUtils
{
    public class AppiumTestDriver
    {
        private static AndroidDriver instance;

        public static AndroidDriver Instance
        {
            get
            {
                try
                {
                    if (instance is null)
                    {
                        var options = new AppiumOptions
                        {
                            AutomationName = AutomationName.AndroidUIAutomator2
                        };
                        options.AddAdditionalAppiumOption(MobileCapabilityType.PlatformName, Configuration.PlatformName);

                        var url = new Uri(Configuration.Url);
                        instance = new AndroidDriver(url, options);
                    }
                }
                catch
                {
                    throw new Exception("Appium driver cannot be initialized");
                }

                return instance;
            }
        }

        public static IWebElement FindElement(By locator) => Instance.FindElement(locator);

        public static List<IWebElement> FindElements(By locator) => Instance.FindElements(locator).ToList<IWebElement>();
    }
}