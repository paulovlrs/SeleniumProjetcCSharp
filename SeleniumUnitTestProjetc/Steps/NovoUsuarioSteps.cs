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
        }

        [Given(@"Acesso o cadastro de usuario")]
        public void GivenAcessoOCadastroDeUsuario()
        {
            CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
            CurrentPage = CurrentPage.As<HomePage>().ClickLinkCriarUsuario();

            // Verifico se existe elemento(s)
            CurrentPage.As<NovoUsuarioPage>().VerificaSeElementosDisponiveis();
        }

        [When(@"Prencher os dados de entrada")]
        public void WhenPrencherOsDadosDeEntrada(Table table)
        {
            // Necessário o pacote *Specflow.Assist.Dynamic*
            dynamic data = table.CreateDynamicInstance();
            // Os nomes dos parametros devem ser exatamente iguais ao da tabela da feature
            CurrentPage.As<NovoUsuarioPage>().PreencherDadosDeEntrada(data.Nome, data.UltimoNome, data.Email, data.Endereco, data.Universidade, data.Profissao, data.Genero, data.Idade);
                //"Paulo Victor L R", "Silva", "teste@teste.com", "Rua 1", "PUC", "QA", "M", 29);
        }

        [When(@"Salvar")]
        public void WhenSalvar()
        {
            CurrentPage.As<NovoUsuarioPage>().CliqueCriarUsuario();
        }

        [Then(@"O Sistema retorna mensagem")]
        public void ThenOSistemaRetornaMensagem(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            if (CurrentPage.As<NovoUsuarioPage>().RetornoMensagemSucesso().Contains(data.Mensagem))
                System.Console.Write("Sucesso");
            
        }

    }
}
