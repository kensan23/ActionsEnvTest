
using Microsoft.Extensions.Configuration;
using System;
namespace ActionsEnvTest
{
    public static class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder().SetBasePath(outputPath).AddJsonFile("appsettings.json", optional: true).AddEnvironmentVariables().Build();
        }

        public static XeroConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new XeroConfiguration();
            var iConfig = GetIConfigurationRoot(outputPath);
            iConfig.GetSection("XeroConfiguration").Bind(configuration);
            return configuration;
        }

    }
}