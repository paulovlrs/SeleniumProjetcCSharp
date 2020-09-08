using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace SeleniumBasicProjectConfiguration.Base
{
  // Para não perder as configurações nos formatos de PageObject e o novo padrão do selenium
  // Mantive ambos os formatos para ter uma ideia sobre as mudanças na estrutura de cada uma
  public abstract class BasePage : BaseDriver
  {
    // Inicializar os elementos da página se torna geral
    public BasePage()
    {
      DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
  }
}
