using AppiumMobileTestProject.ConfigurationManager;
using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using Aquality.Selenium.Core.Logging;

namespace AppiumMobileTestProject.Tests
{
    public class BaseTest
    {
        protected static MainWindow MainWindow => new();
        private static MainToolbarForm MainToolbarForm => new();

        [SetUp]
        public void Setup()
        {
            Logger.Instance.Info($"Start application package '{Configuration.Package}'");
            AppiumTestDriver.Instance.ActivateApp(Configuration.Package);
        }

        [TearDown]
        public void CloseAppAndDriver()
        {
            Logger.Instance.Info("Terminate Application");
            AppiumTestDriver.Instance.TerminateApp(Configuration.Package);
            Logger.Instance.Info("Quit driver");
            AppiumTestDriver.Instance.Quit();
        }
    }
}
