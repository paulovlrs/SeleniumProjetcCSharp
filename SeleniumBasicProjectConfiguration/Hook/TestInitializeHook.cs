using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Config;

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

      // Inicio e maximizo o navegador 
      OpenBrowser(Settings.BrowserType);
      Maximizar();
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

    public static void FinalizarDriver()
    {
      DriverContext.Driver.Close();
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
