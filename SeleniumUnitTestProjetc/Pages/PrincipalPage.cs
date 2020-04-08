using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumBasicProjectConfiguration.Base;

namespace SeleniumUnitTestProjetc.Pages
{
    public class PrincipalPage : BasePage
    {
        // Elementos da Página
        private IWebElement buttonComecarAutomacaoWeb => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(),'Começar Automação Web')]"));
        private IWebElement buttonComecarAutomacaoAPI => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(),'Começar Automação de Api')]"));

        /// <summary>
        /// Acessa a página de "Começar Automação".
        /// </summary>
        public HomePage ClickButtonComecarAutomacaoWeb()
        {           
            buttonComecarAutomacaoWeb.Click();
            return new HomePage();
        }
    }
}
