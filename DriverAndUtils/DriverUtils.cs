using Aquality.Selenium.Core.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android.Enums;

namespace AppiumMobileTestProject.DriverAndUtils
{
    public class DriverUtils
    {
        public static void ClickKeyboardKeyDown(int num)
        {
            for (var i = 1; i < num; i++)
            {
                AppiumTestDriver.Instance.PressKeyCode(AndroidKeyCode.Keycode_DPAD_DOWN);
            }
        }

        public static void RotateDeviceLandscape()
        {
            Logger.Instance.Info("Rotate device in landscape state");
            AppiumTestDriver.Instance.Orientation = ScreenOrientation.Landscape;
        }

        public static void RotateDevicePortrait()
        {
            Logger.Instance.Info("Rotate device in portrait state");
            AppiumTestDriver.Instance.Orientation = ScreenOrientation.Portrait;
        }

        public static void ToggleAirplaneMode() => AppiumTestDriver.Instance.ToggleAirplaneMode();

        public static void ClickKeyboardPerform() => AppiumTestDriver.Instance.PressKeyCode(AndroidKeyCode.Enter);

        public static void TakeScreenshots(string path)
        {
            var screenShot = AppiumTestDriver.Instance.GetScreenshot();
            screenShot.SaveAsFile(path);
        }
    }
}