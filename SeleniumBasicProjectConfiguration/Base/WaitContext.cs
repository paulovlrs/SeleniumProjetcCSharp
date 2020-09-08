using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasicProjectConfiguration.Base
{
  public static class WaitContext
  {
    private static WebDriverWait _wait;

    public static WebDriverWait WaitDriver
    {
      get
      {
        _wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(10));
        return _wait;
      }
      set
      {
        _wait = value;
      }
    }
  }
}
