using NUnit.Framework;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;
using SeleniumUnitTestProjetc.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumUnitTestProjetc.Extensions
{
  [Binding]
  public class StepsExtensions : BaseSteps
  {
    internal string TestCase;

    [Given(@"Que eu esteja na tela principal")]
    public void GivenQueEuEstejaNaTelaPrincipal()
    {
      Navigate();
      CurrentPage = GetInstance<PrincipalPage>();
      CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
    }

    [Given(@"Acesso o menu ""(.*)""")]
    public void GivenAcessoOMenu(string menu)
    {
      // Recebo o nome do caso de teste sendo executado
      TestCase = TestContext.CurrentContext.Test.Name;

      LogHelpers.NameTestCase(TestCase);

      // Inicia a criação de arquivo de Log
      LogHelpers.CreateLogFile();

      // Configuração inicial do Relatório
      ReportHelpers.ConfiguraRelatorio();

      // Crio o caso de teste no relatório
      ReportHelpers.CriarTeste(TestCase);

      //ScenarioContext.Current.Pending();

      ReportHelpers.Log("Seleciono " + menu);
      LogHelpers.Write("Seleciono " + menu);

      CurrentPage.As<HomePage>().SelecionarMenu(menu);
    }

    [Given(@"seleciono a opção ""(.*)""")]
    public void GivenSelecionoAOpcao(string opcaoMenu)
    {
      ReportHelpers.Log("Seleciono a opção " + opcaoMenu);
      LogHelpers.Write("Seleciono a opção " + opcaoMenu);

      CurrentPage.As<HomePage>().SelecionarOpcaoMenu(opcaoMenu);
    }  
  }
}