using AppiumMobileTestProject.Elements;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class FiltersWindow : BasePage
    {
        private Button Section(string sectionName) => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/title_text\" and @text=\"{sectionName}\"]"), $"Section '{sectionName}' button");

        private static TextBox SearchByCategory => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/search_edit\"]"), "Search By Category textbox");

        private Button Apply => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/apply_button\"]"), $"Apply button");

        private CheckBox VolumeValue(string gB) => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/check\" and contains(@text, '{gB}')]"), $"Checkbox wit value '{gB}'");

        public FiltersWindow() : base(SearchByCategory, "Accessories And Services Window")
        { }

        public void ClickSection(string sectionName) => Section(sectionName).Click();

        public void CheckVolumeValue(string value) => VolumeValue(value).Click();

        public void ClickApply() => Apply.Click();
    }
}
