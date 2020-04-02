using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumBasicProjectConfiguration.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUnitTestProjetc.Pages
{
    public class TextosPage : BasePage
    {
        // Aplicando as novas formas de declarações de objetos da página 
        // a partir das mudanças do selenium 3.11

        /*private RemoteWebDriver _driver;

        public TextosPage(RemoteWebDriver driver) => _driver = driver;*/

        string text = "5 dicas para fazer um teste automatizado em Ruby com qualidade, chega de gambiarra!";

        // Possível melhoria futura, seria uma busca do elemento com a mensagem e um clique em seguida
        public IWebElement CardInfo => DriverRemote.Driver.FindElementByXPath("//b[contains(text(),'"+ text + "')]");

        // Devido ao problema de mapeamento de elementos com mesmos IDs e classes, foi adotado essa solução  
        public IWebElement ClickLinkNews => DriverRemote.Driver.FindElementByXPath("(//a[@class='btn-floating halfway-fab waves-light red'])[5]");

        // Elemento ao acessar a página
        public IWebElement ElementPageTitle => DriverRemote.Driver.FindElementByCssSelector("[class='dj b dk dv dm dw do dx dq dy ds dz di']");

        public void ClickNews(string message)
        {
            text = message;
            // criar validação de lista de mensagens
            ClickLinkNews.Click();
        }
    }
}
