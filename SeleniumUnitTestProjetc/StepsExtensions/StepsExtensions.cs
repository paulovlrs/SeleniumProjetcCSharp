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
    // Como são métodos genéricos e reaprovetaveis em diversos cenários de teste
    // Dessa forma permite uma padronização

    [Given(@"Acesso o (.*)")]
    public void GivenAcessoO(string pageName)
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

      ReportHelpers.Log("Acesso a página " + pageName);
      LogHelpers.Write("Acesso a página " + pageName);
      // Verifico o tipo de acesso, tornando génerico o direcionamento de páginas
      if (pageName == "cadastro de usuario")
      {
        CurrentPage = CurrentPage.As<HomePage>().ClickLinkCriarUsuario();

        // Verifico se existe elemento(s)
        CurrentPage.As<NovoUsuarioPage>().VerificaSeElementosDisponiveisCadastroUsuario();
      }
      else if (pageName == "Textos")
      {
        CurrentPage = CurrentPage.As<HomePage>().ClickLinkTextos();
      }
      else if (pageName == "Upload de Arquivo")
      {
        CurrentPage = CurrentPage.As<HomePage>().ClickLinkUploadDeArquivo();
      }
    }

    [When(@"Prencher os dados de entrada")]
    public void WhenPrencherOsDadosDeEntrada(Table table)
    {
      try
      {// Necessário o pacote *Specflow.Assist.Dynamic* para realizar a criação de variáveis utilizando tabelas
        dynamic data = table.CreateDynamicInstance();
        // Os nomes dos parametros devem ser exatamente iguais ao da tabela da feature
        CurrentPage.As<NovoUsuarioPage>().PreencherDadosDeEntrada(data.Nome, data.UltimoNome, data.Email, data.Endereco, data.Universidade, data.Profissao, data.Genero, data.Idade);

        ReportHelpers.Log("Prencho os dados de entrada");
        LogHelpers.Write("Prencho os dados de entrada");
        LogHelpers.PrintScreen();
      }
      catch (Exception e)
      {
        Assert.Fail("Não foi possível validar os dados de entrada, erro: " + e.Message);
      }
    }
  }
}
