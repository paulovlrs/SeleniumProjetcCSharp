using System;
using System.Xml.XPath;
using System.IO;
using SeleniumBasicProjectConfiguration.ConfigElement;
using static SeleniumBasicProjectConfiguration.Hook.TestInitializeHook;

namespace SeleniumBasicProjectConfiguration.Config
{
    public class ConfigReader
    {
        /* método defasado
         * public static string InitializeTest()
        {
            // retorno a configuração da URL do arquivo "App.Config"
            return ConfigurationManager.AppSettings["AUT"].ToString();
        }*/

        // Observação ao configurar XML, lembresse de verificar se está definido "Copy if newer" nas propriedades do XML
        //public static void SetFrameworkSettings()
        //{
        //    XPathItem aut;
        //    XPathItem testType;
        //    XPathItem isLog;
        //    XPathItem logPath;
        //    XPathItem buildName;
        //    XPathItem isReport;

        //    // Força a pegar o diretório da aplicação
        //    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        //    // Ler arquivo xml
        //    string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
        //    FileStream stream = new FileStream(strFileName, FileMode.Open);

        //    // Ler o fluxo do arquivo
        //    XPathDocument document = new XPathDocument(stream);
        //    // Navegar sobre o arquivo
        //    XPathNavigator navigator = document.CreateNavigator();

        //    // Obtenha os dados do XML e atribuo nas variáveis do tipo XPathItem (GlobalConfig.xml)
        //    aut = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/AUT");
        //    testType = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/TestType");
        //    isLog = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/IsLog");
        //    logPath = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/LogPath");
        //    buildName = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/BuildName");
        //    isReport = navigator.SelectSingleNode("SeleniumBasicProjectConfiguration/RunSettings/IsReport");

        //    // Defino as propriedades a serem usadas do XML
        //    Settings.AUT = aut.ToString();
        //    Settings.TestType = testType.ToString();
        //    Settings.IsLog = isLog.ToString();
        //    Settings.LogPath = logPath.ToString();
        //    Settings.BuildName = buildName.ToString();
        //    Settings.IsReport = isReport.ToString();
        //}

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