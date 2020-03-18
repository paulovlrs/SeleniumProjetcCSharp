﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Config;
using SeleniumBasicProjectConfiguration.Helpers;

namespace SeleniumBasicProjectConfiguration.Hook
{
    public abstract class TestInitializeHook : BaseDriver
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void Initialize()
        {
            // Atribuo as configurações do XML
            ConfigReader.SetFrameworkSettings("staging");

            // Inicia a criação de arquivo de Log
            //LogHelpers.NameTestCase(nameTestCase);
            LogHelpers.CreateLogFile();

            // Inicio e maximizo o navegador 
            OpenBrowser(Settings.BrowserType);
            Maximizar();
            LogHelpers.Write("Aberto o browser !!!");
        }

        // Definir o browser que será usado
        public static void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        public static void Navigate()
        {
            // Acesso o site da aplicação
            DriverContext.Browser.GoToUrl(Settings.AUT);
        }

        public static void Maximizar()
        {
            DriverContext.Driver.Manage().Window.Maximize();
        }

        public static void CloseBrowser()
        {
            DriverContext.Driver.Close();

            // Adicionado o Quit() pois não estava fechando o WebDriver usando apenas o Close()
            DriverContext.Driver.Quit();
        }

        public enum BrowserType
        {
            InternetExplorer,
            FireFox,
            Chrome
        }
    }
}
