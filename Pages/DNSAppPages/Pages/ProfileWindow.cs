using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class ProfileWindow : ScreenPage
    {
        private Button Enter => new(By.XPath($"//*[{PackageNameForXPath}login_button\"]"), "Enter Button");

        private Button Section(string sectionName) => new(By.XPath($"//*[{PackageNameForXPath}button_text\" and @text=\"{sectionName}\"]"), $"'{sectionName}' button");

        private static Label SectionLocationText => new(By.XPath($"//*[{PackageNameForXPath}settlement_text\"]"), "Section Location Text label ");       

        public MainToolbarForm mainToolbarForm => new();
            
        public ProfileWindow() : base(SectionLocationText, "Profile Window")
        { }

        public string GetSectionLocation() => SectionLocationText.GetText();

        public void ClickSection(string sectionName) => Section(sectionName).Click();

        public bool IsEnterBtnDisplayed() => Enter.IsDisplayed();
    }
}
