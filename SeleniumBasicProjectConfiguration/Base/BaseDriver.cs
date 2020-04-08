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
    // Para não perder as configurações nos formatos de PageObject e o novo padrão do selenium
    // Mantive ambos os formatos para ter uma ideia sobre as mudanças na estrutura de cada uma
    public class BaseDriver
    {
        //private IWebDriver _driver { get; set; }

        public BasePage CurrentPage
        {
            // Essa alteração permite que não seja passada uma referência nula, pois estava perdendo a referência.
            /*get
            {
                return (BasePage)ScenarioContext.Current["currentPage"];
            }
            set
            {
                ScenarioContext.Current["currentPage"] = value;*/

            // Novo formato para o selenium 3.11 superior
            get => (BasePage)ScenarioContext.Current["currentPage"];
            set => ScenarioContext.Current["currentPage"] = value;
        }

        // instancia generica de página
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            /*
            TPage pageInstance = new TPage()
            {   _driver = DriverContext.Driver  };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
            */

            // Novo formato para o selenium 3.11 superior
            return (TPage)Activator.CreateInstance(typeof(TPage));
        }

        // verifica se é a página no qual estou usando atualmente
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
