using Microsoft.Extensions.Configuration;

namespace AppiumMobileTestProject.TestDataManager
{
    public class TestDataConfiguration
    {
        public static string City = Config["city"];
        public static string ExpectedTextFromEmptyCart = Config["textFromEmptyCart"];
        public static string ExpectedTextFromEmptyFavourites = Config["textFromEmptyavourites"];

        private const string PathToConfig = @"TestDataManager\testData.json";

        private static IConfiguration Config => new ConfigurationBuilder().AddJsonFile(PathToConfig).Build();
    }
}
