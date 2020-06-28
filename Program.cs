using System;
using System.Reflection;

namespace netschool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.GetEntryAssembly()
                                        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                        .InformationalVersion
                                        .ToString();

                Console.WriteLine($"NetSchool v{versionString}");
                Console.WriteLine("-------------");
                // Console.WriteLine("\nUsage:");
                // Console.WriteLine("  botsay <message>");
                ShowBot(string.Join(' ', args));
                return;
            }

            // ShowBot(string.Join(' ', args));
        }
        static void ShowBot(string message)
        {
            string bot = $"\n        {message}";
            bot += @"
    __________________
                      \
                       \
 _   _      _            _                 _ 
| \ | |    | |          | |               | |
|  \| | ___| |_ ___  ___| |__   ___   ___ | |
| . ` |/ _ \ __/ __|/ __| '_ \ / _ \ / _ \| |
| |\  |  __/ |_\__ \ (__| | | | (_) | (_) | |
\_| \_/\___|\__|___/\___|_| |_|\___/ \___/|_|
";
            Console.WriteLine(bot);
        }
    }
}
