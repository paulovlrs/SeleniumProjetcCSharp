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
        // Objetos da Página
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Começar Automação Web')]")]
        private IWebElement buttonComecarAutomacaoWeb { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Começar Automação de Api')]")]
        private IWebElement buttonComecarAutomacaoAPI { get; set; }

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
