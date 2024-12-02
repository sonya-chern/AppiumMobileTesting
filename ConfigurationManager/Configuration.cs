using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTestProject.ConfigurationManager
{
    public class Configuration
    {
        public static string? Url = Config["url"];

        private const string PathToConfig = @"ConfigurationManager\configuration.json";

        private static IConfiguration Config => new ConfigurationBuilder().AddJsonFile(PathToConfig).Build();
    }
}
