using AppiumMobileTestProject.ConfigurationManager;
using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages;
using AppiumMobileTestProject.TestDataManager;
using AppiumMobileTestProject.Utils;
using OpenQA.Selenium;


namespace AppiumMobileTestProject.Tests
{
    public class DeviceActionsTests : BaseTest
    {
        private MainWindow MainWindow = new();

        [Test]
        public void TestDeviceRotation()
        {
            Assert.That(AppiumTestDriver.Instance.Orientation, Is.EqualTo(ScreenOrientation.Portrait), "Device is not in portrait orientation");
            AppiumTestDriver.Instance.Unlock();
            DriverUtils.RotateDeviceLandscape();
            var actualOrientation = AppiumTestDriver.Instance.Orientation;
            Assert.That(actualOrientation, Is.EqualTo(ScreenOrientation.Landscape));
            DriverUtils.RotateDevicePortrait();
        }

        [Test]
        public void TestToggleAirplaneMode()
        {
            Assert.Multiple(() =>
            {
                Assert.That(MainWindow.IsDisplayed(), Is.True, "Main Window is not displayed");
                Assert.That(MainWindow.IsContentEmptyButtonNotDisplayed(), Is.True, "Refresh When Content Empty Button is displayed");
            });

            DriverUtils.ToggleAirplaneMode();

            ReopenApp();

            Assert.That(MainWindow.IsContentEmptyButtonDisplayed(), Is.True, "Refresh When Content Empty Button is not displayed");

            DriverUtils.ToggleAirplaneMode();
        }

        [Test]
        public void TestScreenshots()
        {
            Assert.That(MainWindow.IsDisplayed(), Is.True, "Main Window is not displayed");
            var path = PathUtil.GetFullPathToLogs + "\\Screen.png";
            DriverUtils.TakeScreenshots(path);
            Assert.That(File.Exists(path), Is.True, $"Screenshot doesn't exist by path {path}");
        }

        private void ReopenApp()
        {
            AppiumTestDriver.Instance.TerminateApp(Configuration.Package);
            AppiumTestDriver.Instance.ActivateApp(Configuration.Package);
            Assert.That(MainWindow.IsDisplayed(), Is.True, "Main Window is not displayed");
        }
    }
}