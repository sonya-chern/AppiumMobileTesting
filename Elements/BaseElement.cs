using AppiumMobileTestProject.DriverAndUtils;
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
                WaiterUtil.WaitForSearch(Locator);
                return AppiumTestDriver.FindElement(Locator);
            }
        }

        public bool IsExist() => AppiumTestDriver.FindElements(Locator).Any();

        public bool IsDisplayed()
        {
            WaiterUtil.WaitForSearch(Locator);
            return Element.Displayed;
        }

        public bool IsNotDisplayed()
        {
            try
            {
                WaiterUtil.WaitForSearch(Locator);
            }
            catch (WebDriverTimeoutException)
            {
                return true;
            }
            return false;
        }

        public void Click()
        {
            Logger.Instance.Info($"Click element '{Name}'");
            WaiterUtil.WaitForEnabled(Locator);
            Element.Click();
        }

        public string GetText()
        {
            var text = Element.Text;
            Logger.Instance.Info($"Text from element '{Name}': '{text}'");
            return text;
        }

        public string GetAttributeText(string attributeName)
        {
            var text = Element.GetAttribute(attributeName);
            Logger.Instance.Info($"Text from attribute '{attributeName}': '{text}'");
            return text;
        }
    }
}
