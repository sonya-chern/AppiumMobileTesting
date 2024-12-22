using Microsoft.Extensions.Configuration;

namespace AppiumMobileTestProject.TestDataManager
{
    public class TestDataConfiguration
    {
        public static string City = Config["city"];
        public static string ExpectedTextFromEmptyCart = Config["textFromEmptyCart"];
        public static string ExpectedTextFromEmptyFavourites = Config["textFromEmptyavourites"];
        public static string FilterMemoryCard = Config["filterMemoryCard"];
        public static string VolumMemoryCard = Config["volumMemoryCard"];
        public static string FilterMemoryCardSection = Config["filterMemoryCardSection"];
        public static string TextOnButtonInProductPage = Config["textOnButtonInProductPage"];
        public static string CartNotification = Config["cartNotification"];
        public static string SnackBarInfo = Config["snackBarInfo"];
        public static string Favorites = Config["favorites"];
        public static string AccessoriesAndServices = Config["accessoriesAndServices"];
        public static string ForMobiles = Config["forMobiles"];
        public static string MemoryCard = Config["memoryCard"];

        private const string PathToConfig = @"TestDataManager\testData.json";

        private static IConfiguration Config => new ConfigurationBuilder().AddJsonFile(PathToConfig).Build();
    }
}
