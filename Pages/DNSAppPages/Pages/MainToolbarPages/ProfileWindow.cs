using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class ProfileWindow : BasePage
    {
        private Button Enter => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/login_button\"]"), "Enter Button");

        private Button Section(string sectionName) => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/button_text\" and @text=\"{sectionName}\"]"), $"'{sectionName}' button");

        private static Label SectionLocationText => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/settlement_text\"]"), "Section Location Text label ");

        public MainToolbarForm MainToolbarForm => new();

        public ProfileWindow() : base(SectionLocationText, "Profile Window")
        { }

        public string GetSectionLocation() => SectionLocationText.GetText();

        public void ClickSection(string sectionName) => Section(sectionName).Click();

        public bool IsEnterBtnDisplayed() => Enter.IsDisplayed();
    }
}
