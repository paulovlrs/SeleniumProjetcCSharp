using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace SeleniumBasicProjectConfiguration.Base
{
    public abstract class BasePage : BaseDriver
    {
        // Inicializar os elementos da página se torna geral
        public BasePage()
        {
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
