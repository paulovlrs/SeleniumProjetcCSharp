using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumBasicProjectConfiguration.Base
{
  public static class DriverContext
  {
    private static IWebDriver _driver;

    // Classe para chamar o driver, ao inves de fazer diversas chamadas
    public static IWebDriver Driver
    {
      get
      {
        return _driver;
      }
      set
      {
        _driver = value;
      }
    }
    public static Browser Browser { get; set; }
  }
}
