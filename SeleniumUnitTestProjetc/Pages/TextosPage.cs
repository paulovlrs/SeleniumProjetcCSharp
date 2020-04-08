using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Extensions;
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

        string text = "5 dicas para fazer um teste automatizado em Ruby com qualidade, chega de gambiarra!";

        // Possível melhoria futura, seria uma busca do elemento com a mensagem e um clique em seguida
        private IWebElement CardInfo => DriverContext.Driver.FindElement(By.XPath("//b[contains(text(),'"+ text + "')]"));

        // Devido ao problema de mapeamento de elementos com mesmos IDs e classes, foi adotado essa solução
        // será feita no futuro uma busca genérica
        private IWebElement ClickLinkNews => DriverContext.Driver.FindElement(By.XPath("//a[@href='https://medium.com/automa%C3%A7%C3%A3o-com-batista/5-dicas-para-fazer-um-teste-automatizado-em-ruby-com-qualidade-chega-de-gambiarra-9be62ffb2812']"));

        // Elemento ao acessar a página
        private IWebElement ElementPageTitle => DriverContext.Driver.FindElement(By.XPath("[class='dj b dk dv dm dw do dx dq dy ds dz di']"));

        public void ClickNews()
        {
            // criar validação de lista de mensagens
            ClickLinkNews.Click();
        }

        public MediumPage VisualizarReportagem()
        {
            return new MediumPage();
        }
    }
}
