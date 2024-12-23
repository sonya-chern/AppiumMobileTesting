using AppiumMobileTestProject.Elements;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;
using OpenQA.Selenium;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class FavouritesWindow : BasePage
    {
        private static Label EmptyContent = new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/empty_content_summary_text\"]"), "Empty Content label");

        private Button GoToCatalog = new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/empty_content_action_button\"]"), "Go To Catalog button");

        private Button GoToProfile => new(By.XPath($"//*[@resource-id=\"ru.dns.shop.android:id/login_button\"]"), "Go To Profile button");

        public MainToolbarForm mainToolbarForm => new();

        public FavouritesWindow() : base(EmptyContent, "Empty Favourites Window")
        { }

        public string GetEmptyContent() => EmptyContent.GetText();

        public bool IsGoToCatalogBtnDisplayed() => GoToCatalog.IsDisplayed();

        public bool IsGoToProfileBtnDisplayed() => GoToProfile.IsDisplayed();
    }
}