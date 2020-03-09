using SeleniumBasicProjectConfiguration.Base;
using static SeleniumBasicProjectConfiguration.Hook.TestInitializeHook;

namespace SeleniumBasicProjectConfiguration.Config
{
    public class Settings
    {
        public static string TestType { get; set; }
        public static string AUT { get; set; }
        public static string BuildName { get; set; }
        public static BrowserType BrowserType { get; set; }
        public static string IsLog { get; set; }
        public static string LogPath { get; set; }
        public static string IsReport { get; set; }
    }
}
