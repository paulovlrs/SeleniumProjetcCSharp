using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasicProjectConfiguration.Base
{
    public class BaseDriver
    {
        private IWebDriver _driver { get; set; }
        public BasePage PaginaCorrente { get; set; }

        // instancia generica de página
        protected TPage GetInstancia<TPage>() where TPage : BasePage, new()
        {
            TPage paginaInstancia = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, paginaInstancia);
            return paginaInstancia;
        }

        // verifica se é a página no qual estou usando atualmente
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
