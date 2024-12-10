using AppiumMobileTestProject.Pages.DNSAppPages.Pages;
using AppiumMobileTestProject.TestDataManager;

namespace AppiumMobileTestProject.Tests
{
    public class AppiumMobileTests : BaseTest
    {
        private const string SectionFavourites = "Избранное";
        private SplashScreenLocationWindow splashScreenLocationWindow => new();
        private SplashScreenEnterWindow splashScreenEnterWindow => new();
        private AlertPermissionNotification alertPermissionNotification => new();
        private MainWindow mainWindow => new();
        private EmptyCartWindow emptyCartWindow => new();
        private ProfileWindow profileWindow => new();
        private EmptyFavouritesWindow emptyFavouritesWindow => new();

        [Test]
        public void TestSplashScreens()
        {
            //var actualCityNameInSplashScreen = splashScreenLocationWindow.GetCityName();
            //Assert.That(actualCityNameInSplashScreen, Does.Contain(TestDataConfiguration.City),
            //    $"Expected city in splash screen '{TestDataConfiguration.City}' but was '{actualCityNameInSplashScreen}'");

            //splashScreenLocationWindow.ClickConfirm();

            //Assert.True(splashScreenEnterWindow.IsDisplayed(), "Splash Screen Enter window is not displayed");

            //splashScreenEnterWindow.ClickEnterLater();

            //Assert.True(alertPermissionNotification.IsDisplayed(), "Alert 'Permission Notification' is not displayed");

            //alertPermissionNotification.ClickEnterLater();

            Assert.True(mainWindow.IsDisplayed(), "Main Window is not displayed");

            var actualCityInMainWidow = mainWindow.GetCityLocation();
            Assert.That(actualCityInMainWidow, Is.EqualTo(TestDataConfiguration.City),
                $"Expected city in splash screen '{TestDataConfiguration.City}' but was '{actualCityInMainWidow}'");

            mainWindow.mainToolbarForm.ClickCart();

            Assert.True(emptyCartWindow.IsDisplayed(), "Empty Cart Window is not displayed");

            var textFromEmptyCart = emptyCartWindow.GetCartTextFromEmptyContentLabel();
            Assert.Multiple(() =>
            {
                Assert.That(textFromEmptyCart, Is.EqualTo(TestDataConfiguration.ExpectedTextFromEmptyCart),
                $"Expected text '{TestDataConfiguration.ExpectedTextFromEmptyCart}' but was '{textFromEmptyCart}'");
            Assert.True(emptyCartWindow.GoToCatalogBtnIsDisplayed(), "Go To Catalog button is not displayed");
            });

            emptyCartWindow.mainToolbarForm.ClickProfile();

            Assert.True(profileWindow.IsDisplayed(), "Profile Window is not displayed");

            Assert.Multiple(() =>
            {
                Assert.True(profileWindow.IsEnterBtnDisplayed(), "Enter button is not displayed");
                var actualLocationFromProfile = profileWindow.GetSectionLocation();
                Assert.That(actualLocationFromProfile, Is.EqualTo(TestDataConfiguration.City),
                    $"Expected city in profile window is '{TestDataConfiguration.City}' but was '{actualLocationFromProfile}'");
            });            

            profileWindow.ClickSection(SectionFavourites);

            Assert.True(emptyFavouritesWindow.IsDisplayed(), "Profile Window is not displayed");

            var textFromEmptyFavouvitesWindow = emptyFavouritesWindow.GetEmptyContent();
            Assert.Multiple(() =>
            {
            Assert.That(textFromEmptyFavouvitesWindow, Is.EqualTo(TestDataConfiguration.ExpectedTextFromEmptyFavourites),
                $"Expected text '{TestDataConfiguration.ExpectedTextFromEmptyFavourites}' but was '{textFromEmptyFavouvitesWindow}'");
            Assert.True(emptyFavouritesWindow.IsGoToCatalogBtnDisplayed(), "Go To Catalog button is not displayed");
            Assert.True(emptyFavouritesWindow.IsGoToProfileBtnDisplayed(), "Go To Profile button is not displayed");
            });
        }
    }
}