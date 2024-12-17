using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class FiltersWindow : ScreenPage
    {
        private Button Section(string sectionName) => new(By.XPath($"//*[{PackageNameForXPath}title_text\" and @text=\"{sectionName}\"]"), $"Section '{sectionName}' button");

        private static TextBox SearchByCategory => new(By.XPath($"//*[{PackageNameForXPath}search_edit\"]"), "Search By Category textbox");

        private Button Apply => new(By.XPath($"//*[{PackageNameForXPath}apply_button\"]"), $"Apply button");

        private CheckBox VolumeValue(string gB) => new(By.XPath($"//*[{PackageNameForXPath}check\" and @text=\"{gB}\"]"), $"Checkbox wit value '{gB}'");

        public FiltersWindow() : base(SearchByCategory, "Accessories And Services Window")
        { }

        public void ClickSection(string sectionName) => Section(sectionName).Click();

        public void CheckVolumeValue(string value) => VolumeValue(value).Click();

        public void ClickApply() => Apply.Click();
    }
}
