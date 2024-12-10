using AppiumMobileTestProject.ConfigurationManager;
using AppiumMobileTestProject.DriverUtils;
using Aquality.Selenium.Core.Logging;

namespace AppiumMobileTestProject.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Logger.Instance.Info($"Start application package '{Configuration.Package}'");
            AppiumTestDriver.Instance.ActivateApp(Configuration.Package);
        }

        [TearDown]
        public void TearDown()
        {
            Logger.Instance.Info("Quit driver");
            AppiumTestDriver.Instance.Quit();
        }
    }
}
