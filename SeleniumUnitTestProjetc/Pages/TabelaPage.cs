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
    public class TabelaPage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "centered highlight")]
        private IWebElement tabela { get; set; }



        public IWebElement ReceberElementosTabela()
        {
            return tabela;
        }

    }
}
