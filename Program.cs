using System;
using System.IO;

namespace ActionsEnvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.GetCurrentDirectory();
            var configuration = TestHelper.GetApplicationConfiguration(directory);
            Console.WriteLine(configuration.AccountingBaseUrl);
        }
    }
}
