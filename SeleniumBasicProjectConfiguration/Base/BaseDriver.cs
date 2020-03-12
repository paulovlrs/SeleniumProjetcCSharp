using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumBasicProjectConfiguration.Base
{
    public class BaseDriver
    {
        private IWebDriver _driver { get; set; }
        public BasePage CurrentPage
        {
            // Essa alteração permite que não seja passada uma referência nula, pois estava perdendo a referência.
            get
            {
                return (BasePage)ScenarioContext.Current["currentPage"];
            }
            set
            {
                ScenarioContext.Current["currentPage"] = value;
            }
        }

        // instancia generica de página
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        // verifica se é a página no qual estou usando atualmente
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
