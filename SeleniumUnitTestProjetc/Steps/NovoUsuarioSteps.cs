using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;
using SeleniumUnitTestProjetc.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumUnitTestProjetc.Steps
{
  [Binding]
  public class NovoUsuarioSteps : BaseSteps
  {
    [When(@"Clicar no botão Criar")]
    public void WhenClicarNoBotaoCriar()
    {
      CurrentPage.As<NovoUsuarioPage>().CliqueCriarUsuario();
      LogHelpers.PrintScreen();
    }

    [Then(@"O Sistema retorna a mensagem")]
    public void ThenOSistemaRetornaAMensagem(Table table)
    {
      // Alterar o método para se comportar como o método de acesso, validar de acordo com o tipo de retorno que desejo
      // Essa mudança me garantira performance nos teste

      dynamic data = table.CreateDynamicInstance();

      // realizo a validação das mensagens de sucesso ou alerta, separado no dentro do método por questão de perfomance
      // antes era uma verificação genérica, ocasionando demora na execução do teste

      if (CurrentPage.As<NovoUsuarioPage>().ValidarMensagem(data.Mensagem) == true)
      {
        ReportHelpers.Sucesso("Mensagem exibida com sucesso");
      }
      else
      {
        CurrentPage.As<NovoUsuarioPage>().FalhaExecucao("Não foi possível exibir a mensagem");
        ReportHelpers.Falha("Não foi possível exibir a mensagem");
      }
      ReportHelpers.Log("Finalizado teste");
      LogHelpers.PrintScreen();
    }

    [When(@"Prencher os dados de entrada")]
    public void WhenPrencherOsDadosDeEntrada(Table table)
    {
      try
      {
        CurrentPage = GetInstance<NovoUsuarioPage>();

        // Verifico se existe elemento(s)
        CurrentPage.As<NovoUsuarioPage>().VerificaSeElementosDisponiveisCadastroUsuario();

        // Necessário o pacote *Specflow.Assist.Dynamic* para realizar a criação de variáveis utilizando tabelas
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
