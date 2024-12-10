using AppiumMobileTestProject.Elements;
using Aquality.Selenium.Core.Logging;

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
            Logger.Instance.Info($"Window '{Name}' displayed");
            return Element.IsDisplayed();
        }
    }
}
