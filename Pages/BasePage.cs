using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Utils;
using Aquality.Selenium.Core.Logging;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages
{
    public abstract class BasePage
    {
        private readonly string Name;
        private readonly BaseElement Element;

        public BasePage(BaseElement element, string name)
        {
            Name = name;
            Element = element;
            Logger.Instance.Info($"An instance of window '{Name}' created");
        }

        public bool IsDisplayed()
        {            
            var displayedState = Element.IsDisplayed();
            Logger.Instance.Info($"Window '{Name}' is displayed: '{displayedState}'");
            return displayedState;
        }        
    }
}
