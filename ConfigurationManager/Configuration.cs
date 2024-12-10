using Microsoft.Extensions.Configuration;

namespace AppiumMobileTestProject.ConfigurationManager
{
    public class Configuration
    {       
        public static string Url = Config["url"];
        public static string Package = Config["package"];
        public static string TimeForDriverWait = Config["timeForDriverWait"];
        public static string PollingInterval = Config["pollingInterval"];

        private const string PathToConfig = @"ConfigurationManager\configuration.json";

        private static IConfiguration Config => new ConfigurationBuilder().AddJsonFile(PathToConfig).Build();
    }
}
