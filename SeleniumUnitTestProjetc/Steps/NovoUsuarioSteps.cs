using SeleniumBasicProjectConfiguration.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumUnitTestProjetc.Steps
{
    [Binding]
    public class NovoUsuarioSteps : BaseSteps
    {
        [Given(@"Que eu esteja na tela principal")]
        public void GivenQueEuEstejaNaTelaPrincipal()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Acesso o cadastro de usuario")]
        public void GivenAcessoOCadastroDeUsuario()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Prencher os dados de entrada")]
        public void WhenPrencherOsDadosDeEntrada(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Salvar")]
        public void WhenSalvar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"O Sistema retorna mensagem")]
        public void ThenOSistemaRetornaMensagem(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
