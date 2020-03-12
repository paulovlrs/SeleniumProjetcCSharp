using SeleniumBasicProjectConfiguration.Base;
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
        [Given(@"Que eu esteja na tela principal")]
        public void GivenQueEuEstejaNaTelaPrincipal()
        {
            Navigate();
            CurrentPage = GetInstance<PrincipalPage>();
            CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
        }

        [When(@"Salvar")]
        public void WhenSalvar()
        {
            CurrentPage.As<NovoUsuarioPage>().CliqueCriarUsuario();
        }

        [Then(@"O Sistema retorna mensagem")]
        public void ThenOSistemaRetornaMensagem(Table table)
        {
            // Alterar o método para se comportar como o método de acesso, validar de acordo com o tipo de retorno que desejo
            // Essa mudança me garantira performance nos teste

            dynamic data = table.CreateDynamicInstance();

            // realizo a validação das mensagens de sucesso ou alerta
            if (CurrentPage.As<NovoUsuarioPage>().ValidarMensagem(data.Mensagem) == true)
                System.Console.Write("Sucesso");
            else
                CurrentPage.As<NovoUsuarioPage>().FalhaExecucao("Mensagem não foi exibida");
        }
    }
}
