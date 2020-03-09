using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumUnitTestProjetc.Pages;
using TreinamentoSeleniumAvancado.Base;

namespace SeleniumUnitTestProjetc
{
    [TestClass]
    public class UnitTest1
    {

        string URL = "https://automacaocombatista.herokuapp.com/home/index";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(URL);
            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            ClickButtonAutomacao();
        }

        public void ClickButtonAutomacao()
        {
            PrincipalPage principalPage = new PrincipalPage();
            principalPage.buttonComecarAutomacaoWeb.Click();

            HomePage homePage = new HomePage();
            homePage.LinkFormulario.Click();
            homePage.LinkCriarUsuario.Click();

            NovoUsuarioPage novoUsuarioPage = new NovoUsuarioPage();

            novoUsuarioPage.PreencherCampos("Paulo", "Silva", "teste@teste.com", "Rua 1", "PUC", "QA", "M", 29);

        }
    }
}
