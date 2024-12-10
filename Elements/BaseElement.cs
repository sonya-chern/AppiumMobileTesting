using AppiumMobileTestProject.DriverUtils;
using AppiumMobileTestProject.Utils;
using Aquality.Selenium.Core.Logging;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Elements
{
    public class BaseElement
    {
        private readonly string Name;
        private readonly By Locator;

        public BaseElement(By locator, string name)
        {
            Name = name;
            Locator = locator;
        }

        protected IWebElement Element
        {
            get
            {
                Logger.Instance.Info($"Find element '{Name}'");
                WaiterUtil.WaitForDisplayed(Locator);
                return AppiumTestDriver.Instance.FindElement(Locator);
            }
        }

        public bool IsExist() => AppiumTestDriver.Instance.FindElements(Locator).Any();

        public bool IsDisplayed()
        {
            WaiterUtil.WaitForDisplayed(Locator);
            return Element.Displayed;
        }

        public void Click()
        {
            Logger.Instance.Info($"Click element '{Name}'");
            WaiterUtil.WaitForEnabled(Locator);
            Element.Click();
        }

        public string GetText()
        {
            Logger.Instance.Info($"Get text from element '{Name}'");
            return Element.Text;
        }
    }
}
