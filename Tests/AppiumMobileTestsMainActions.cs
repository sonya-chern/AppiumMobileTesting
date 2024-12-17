using AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages;
using AppiumMobileTestProject.Pages.DNSAppPages.Pages.SplashScreenPages;
using AppiumMobileTestProject.TestDataManager;

namespace AppiumMobileTestProject.Tests
{
    public class AppiumMobileTestsMainActions : BaseTest
    {
        private SplashScreenLocationWindow SplashScreenLocationWindow => new();
        private SplashScreenEnterWindow SplashScreenEnterWindow => new();
        private AlertPermissionNotification AlertPermissionNotification => new();
        private MainWindow MainWindow => new();
        private CartWindow CartWindow => new();
        private ProfileWindow ProfileWindow => new();
        private FavouritesWindow EmptyFavouritesWindow => new();

        [Test]
        public void TestSplashScreens()
        {
            Assert.That(SplashScreenLocationWindow.IsDisplayed(), Is.True, "Splash Screen Location Window is not displayed");

            var actualCityNameInSplashScreen = SplashScreenLocationWindow.GetCityName();
            Assert.That(actualCityNameInSplashScreen, Does.Contain(TestDataConfiguration.City),
                $"Expected city in splash screen '{TestDataConfiguration.City}' but was '{actualCityNameInSplashScreen}'");

            SplashScreenLocationWindow.ClickConfirm();

            Assert.That(SplashScreenEnterWindow.IsDisplayed(), Is.True, "Splash Screen Enter window is not displayed");

            SplashScreenEnterWindow.ClickEnterLater();

            Assert.That(AlertPermissionNotification.IsDisplayed(), Is.True, "Alert 'Permission Notification' is not displayed");

            AlertPermissionNotification.ClickEnterLater();

            Assert.That(MainWindow.IsDisplayed(), Is.True, "Main Window is not displayed");

            var actualCityInMainWidow = MainWindow.GetCityLocation();
            Assert.That(actualCityInMainWidow, Is.EqualTo(TestDataConfiguration.City),
                $"Expected city in splash screen '{TestDataConfiguration.City}' but was '{actualCityInMainWidow}'");

            MainWindow.MainToolbarForm.ClickCart();

            Assert.That(CartWindow.IsDisplayed(), Is.True, "Empty Cart Window is not displayed");

            var textFromEmptyCart = CartWindow.GetCartTextFromEmptyContentLabel();
            Assert.Multiple(() =>
            {
                Assert.That(textFromEmptyCart, Is.EqualTo(TestDataConfiguration.ExpectedTextFromEmptyCart),
                $"Expected text '{TestDataConfiguration.ExpectedTextFromEmptyCart}' but was '{textFromEmptyCart}'");
                Assert.That(CartWindow.GoToCatalogBtnIsDisplayed(), Is.True, "Go To Catalog button on Cart Window is not displayed");
            });

            CartWindow.MainToolbarForm.ClickProfile();

            Assert.That(ProfileWindow.IsDisplayed(), Is.True, "Profile Window is not displayed");

            Assert.Multiple(() =>
            {
                Assert.That(ProfileWindow.IsEnterBtnDisplayed(), Is.True, "Enter button on Profile Window is not displayed");
                var actualLocationFromProfile = ProfileWindow.GetSectionLocation();
                Assert.That(actualLocationFromProfile, Is.EqualTo(TestDataConfiguration.City),
                    $"Expected city in profile window is '{TestDataConfiguration.City}' but was '{actualLocationFromProfile}'");
            });

            ProfileWindow.ClickSection(TestDataConfiguration.Favorites);

            Assert.That(EmptyFavouritesWindow.IsDisplayed(), Is.True, "Empty Favourites Window is not displayed");

            var textFromEmptyFavouvitesWindow = EmptyFavouritesWindow.GetEmptyContent();
            Assert.Multiple(() =>
            {
                Assert.That(textFromEmptyFavouvitesWindow, Is.EqualTo(TestDataConfiguration.ExpectedTextFromEmptyFavourites),
                    $"Expected text '{TestDataConfiguration.ExpectedTextFromEmptyFavourites}' but was '{textFromEmptyFavouvitesWindow}'");
                Assert.That(EmptyFavouritesWindow.IsGoToCatalogBtnDisplayed(), Is.True, "Go To Catalog button is not displayed");
                Assert.That(EmptyFavouritesWindow.IsGoToProfileBtnDisplayed(), Is.True, "Go To Profile button is not displayed");
            });
        }
    }
}