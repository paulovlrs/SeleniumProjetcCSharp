using System;
using System.Xml.XPath;
using System.IO;
using SeleniumBasicProjectConfiguration.ConfigElement;
using static SeleniumBasicProjectConfiguration.Hook.TestInitializeHook;

namespace SeleniumBasicProjectConfiguration.Config
{
    public class ConfigReader
    {       
        /// <summary>
        /// Configurações parametrizadas do XML(App.config)
        /// </summary>
        /// <param name="nameSettings">Informar "staging", "preprod" ou "production"</param>
        public static void SetFrameworkSettings(string nameSettings)
        {
            // Defino as propriedades a serem usadas do XML(App.config do SeleniumUnitTestProjetc)
            Settings.AUT = ProjectConfiguration.ProjectSettings.TestSettings[nameSettings].AUT;
            Settings.TestType = ProjectConfiguration.ProjectSettings.TestSettings[nameSettings].TestType;
            Settings.IsLog = ProjectConfiguration.ProjectSettings.TestSettings[nameSettings].IsLog;
            Settings.LogPath = ProjectConfiguration.ProjectSettings.TestSettings[nameSettings].LogPath;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), ProjectConfiguration.ProjectSettings.TestSettings[nameSettings].Browser);
        }

    }
}