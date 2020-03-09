using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumUnitTestProjetc.Utils;
using SeleniumBasicProjectConfiguration.Base;

namespace SeleniumUnitTestProjetc.Pages
{
    public class ListaDeUsuariosPage : BasePage
    {
        /*[FindsBy (How = How.XPath, Using = "//td[contains(text(),'"+x+"')]")]
        private IWebElement LabelNome { get; set; }*/

        /*[FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/table/tbody/tr[1]/td[11]/a")]
        private IWebElement DeletarPrimeiraOpcao { get; }*/

        [FindsBy(How = How.XPath, Using = "//*[@class='highlight striped responsive-table']")]
        private IWebElement tabela { get; set; }

        public IWebElement ReceberElementosTabela()
        {
            return tabela;
        }

        public void PesquisaNome(string nome)
        {
            // Uso o valor informado para pesquisa e adiciono caminho para localizar o xpath
            nome = "//td[contains(text(),'" + nome + "')]";
            By idLabelNome = By.XPath(nome);


            //IWebElement LabelNome = EsperaSelenium.RetornarElementoVisivel(idLabelNome);

            /* Para estudar e pesquisar:
             * Obter o innertext: https://stackoverflow.com/questions/43933778/how-to-get-inner-text-of-an-element-in-selenium
             * Pegar o primeiro elemento: https://stackoverflow.com/questions/40916740/how-to-use-count-function-in-xpath-of-selenium
             * Pegar valores de array: https://stackoverflow.com/questions/34892868/how-we-store-weblist-element-into-array-using-selenium-webdriver
             * Pesquisando em varias páginas: https://respostas.guj.com.br/24694-problema-com-ajax-e-selenium
             * 
             */
        }

        public void DeletarNome(string nome)
        {
            Thread.Sleep(500);
            IWebDriver driver = DriverContext.Driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            By mySelector = By.XPath("/html/body/div[3]/div/table/tbody/tr[1]/td[11]/a");
            IWebElement DeletarPrimeiraOpcao = driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr[1]/td[11]/a"));
            DeletarPrimeiraOpcao.Click();
            // Confirmar Pop-up do navegador
            DriverContext.Driver.SwitchTo().Alert().Accept();
            //DeletarNome("");
            /* Matar Processo
             * taskkill /F /IM chromedriver.exe /T
             */
        }

    }
}
