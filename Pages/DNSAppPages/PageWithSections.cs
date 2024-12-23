using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages
{
    public abstract class PageWithSections : BasePage
    {
        private Label FocusedElement(string sectionName) => new(By.XPath($"//*[@focused='true']//*[@text='{sectionName}']"), $"Focused '{sectionName}' element");
        protected static Label Section(string sectionName) => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/title_text\" and @text=\"{sectionName}\"]"), $"'{sectionName}' section label");

        public PageWithSections(string sectionName, string pageName) : base(Section(sectionName), pageName)
        { }

        protected void ClickSection<T>(string sectionName, string windowName, T dict) where T : Dictionary<string, int>
        {           
            var sectionPosition = dict[sectionName];
            DriverUtils.ClickKeyboardKeyDown(dict[sectionName]);
            if (!IsRightSectionSelected(sectionName))
            {
                throw new Exception($"Section '{sectionName}' is not in '{sectionPosition}' position, check the section position in the dictionary on '{windowName}'");
            }
            DriverUtils.ClickKeyboardPerform();
        }

        private bool IsRightSectionSelected(string sectionName) => FocusedElement(sectionName).IsDisplayed();
    }
}