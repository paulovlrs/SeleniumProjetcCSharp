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
        public BasePage CurrentPage
        {
            // Novo formato para o selenium 3.11 superior
            get => (BasePage)ScenarioContext.Current["currentPage"];
            set => ScenarioContext.Current["currentPage"] = value;
        }

        // instancia generica de página
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
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
