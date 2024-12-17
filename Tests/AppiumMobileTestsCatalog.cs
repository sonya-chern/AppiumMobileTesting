using AppiumMobileTestProject.Pages.DNSAppPages.Pages;
using AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages;
using AppiumMobileTestProject.TestDataManager;

namespace AppiumMobileTestProject.Tests
{
    public class AppiumMobileTestsCatalog : BaseTest
    {
        private static MainWindow MainWindow => new();
        private static CatalogWindow CatalogWindow => new();
        private AccessoriesAndServicesWindow AccessoriesAndServicesWindow => new();
        private ForMobilesWindow ForMobilesWindow => new();
        private MemoryCardsWindow MemoryCardsWindow => new();
        private FiltersWindow FiltersWindow => new();
        private ProductWindow ProductWindow => new();
        private CartWindow CartWindow => new();

        [Test]
        public void TestCatalog()
        {
            Assert.That(MainWindow.IsDisplayed(), Is.True, "Main Window is not displayed");

            MainWindow.MainToolbarForm.ClickCatalog();

            Assert.That(CatalogWindow.IsDisplayed(), Is.True, "Catalog Window is not displayed");

            CatalogWindow.ClickAccessoriesAndServices();

            Assert.That(AccessoriesAndServicesWindow.IsDisplayed(), Is.True, "Accessories And Services Window is not displayed");

            AccessoriesAndServicesWindow.ClickForMobiles();

            Assert.That(ForMobilesWindow.IsDisplayed(), Is.True, "For Mobiles Window is not displayed");

            ForMobilesWindow.ClickÌemoryCards();

            Assert.That(MemoryCardsWindow.IsDisplayed(), Is.True, "Ìemory Cards Window is not displayed");

            MemoryCardsWindow.ClickFilters();

            Assert.That(FiltersWindow.IsDisplayed(), Is.True, "Filters Window is not displayed");

            FiltersWindow.ClickSection(TestDataConfiguration.FilterMemoryCardSection);
            FiltersWindow.CheckVolumeValue(TestDataConfiguration.VolumMemoryCard);
            FiltersWindow.ClickApply();

            Assert.That(MemoryCardsWindow.IsFilterDisplayed(TestDataConfiguration.FilterMemoryCard), Is.True,
                    $"Filter '{TestDataConfiguration.FilterMemoryCard}' is not displayed for Memory Card Window");

            var firstProductName = MemoryCardsWindow.GetProductNames()[0];
            var firstProductPrice = MemoryCardsWindow.GetPrices()[0];

            MemoryCardsWindow.OpenProductPage(firstProductName);

            Assert.That(ProductWindow.IsDisplayed(), Is.True, "Product Window is not displayed");

            var priceInProductCard = ProductWindow.GetPrice();

            Assert.That(firstProductPrice, Is.EqualTo(priceInProductCard),
                    $"Product '{firstProductName}' price in Memory Cards Window '{firstProductPrice}' but in its card price is '{priceInProductCard}'");

            ProductWindow.ClickBuy();

            var actualTextOnBuyButton = ProductWindow.GetTextFromButtonAfterPurchase();
            Assert.That(TestDataConfiguration.TextOnButtonInProductPage, Is.EqualTo(actualTextOnBuyButton));

            var actualCartNotification = ProductWindow.MainToolbarForm.GetCartNotification();
            Assert.That(actualCartNotification, Does.Contain(TestDataConfiguration.CartNotification), $"Actual cart notification is '{actualCartNotification}'");

            ProductWindow.MainToolbarForm.ClickCart();

            Assert.That(CartWindow.IsDisplayed(), Is.True, "Carts Window is displayed");

            var productNameInCart = CartWindow.GetProductInCart(firstProductName);
            Assert.That(productNameInCart, Is.Not.Empty, $"Product '{firstProductName}' is not exist in cart");

            var actualProductPriceInCart = CartWindow.GetProductPriceInCart(productNameInCart);

            Assert.That(firstProductPrice, Is.EqualTo(actualProductPriceInCart),
                    $"Product '{productNameInCart}' price in Memory Cards Window '{firstProductPrice}' but in the cart price is '{actualProductPriceInCart}'");

            CartWindow.DeleteProduct(productNameInCart);
            Assert.That(CartWindow.NotificationForDeletingProduct.IsDisplayed(), Is.True, "Notification For Deleting Product is not displayed");

            CartWindow.NotificationForDeletingProduct.ClickDelete();

            var snackbarText = CartWindow.GetTextFromSnackbar();

            Assert.That(TestDataConfiguration.SnackBarInfo, Is.EqualTo(snackbarText));

            var textFromEmptyCart = CartWindow.GetCartTextFromEmptyContentLabel();
            Assert.That(textFromEmptyCart, Is.EqualTo(TestDataConfiguration.ExpectedTextFromEmptyCart),
                $"Expected text '{TestDataConfiguration.ExpectedTextFromEmptyCart}' but was '{textFromEmptyCart}'");
        }
    }
}