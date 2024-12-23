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

        public static void ClickKeyboardPerform() => AppiumTestDriver.Instance.PressKeyCode(AndroidKeyCode.Enter);
    }
}