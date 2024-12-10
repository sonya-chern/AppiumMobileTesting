using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class EmptyCartWindow : ScreenPage
    {
        private Label EmptyContent = new(By.XPath($"//*[{PackageNameForXPath}empty_content_summary_text\"]"), "Empty Content text label");
        
        private static Button EmptyContentAction => new(By.XPath($"//*[{PackageNameForXPath}empty_content_action_button\"]"), "EmptyContent Action button");

        public MainToolbarForm mainToolbarForm => new();
            
        public EmptyCartWindow() : base(EmptyContentAction, "Empty Cart Window")
        { }

        public string GetCartTextFromEmptyContentLabel() => EmptyContent.GetText();

        public bool GoToCatalogBtnIsDisplayed() => EmptyContentAction.IsDisplayed();
    }
}
