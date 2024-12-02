using AppiumMobileTestProject.ConfigurationManager;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumMobileTestProject.DriverUtils
{
    public class AppiumDriver
    {
        private static AndroidDriver? instance;
        private const string platformName = "Android";

        public static AndroidDriver? Instance
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
                        options.AddAdditionalAppiumOption(MobileCapabilityType.PlatformName, platformName);

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
    }
}