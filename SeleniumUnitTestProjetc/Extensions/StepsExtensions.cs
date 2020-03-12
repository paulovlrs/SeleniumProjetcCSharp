using SeleniumBasicProjectConfiguration.Base;
using SeleniumUnitTestProjetc.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumUnitTestProjetc.Extensions
{
    [Binding]
    public class StepsExtensions : BaseSteps
    {
        // Como são métodos genéricos e reaprovetaveis em diversos cenários de teste
        // Dessa forma permite uma padronização

        [Given(@"Acesso o (.*)")]
        public void GivenAcessoO(string pageName)
        {
            // Dessa forma permite que o acesso seja genérico
            if (pageName == "cadastro de usuario")
            {
                CurrentPage = CurrentPage.As<HomePage>().ClickLinkCriarUsuario();

                // Verifico se existe elemento(s)
                CurrentPage.As<NovoUsuarioPage>().VerificaSeElementosDisponiveis();
            }
        }

        [When(@"(.*) Prencher os dados de entrada")]
        public void WhenPrencherOsDadosDeEntrada(string infoData, Table table)
        {
            // Devido a necessidade informar uma valor, decidi colocar o valor "*", como um simbolo de preencher todos os campos

            // Necessário o pacote *Specflow.Assist.Dynamic*
            dynamic data = table.CreateDynamicInstance();

            if (infoData == "*")
            {
                // Os nomes dos parametros devem ser exatamente iguais ao da tabela da feature
                CurrentPage.As<NovoUsuarioPage>().PreencherDadosDeEntrada(data.Nome, data.UltimoNome, data.Email, data.Endereco, data.Universidade,
                    data.Profissao, data.Genero, data.Idade);
            }
            else if (infoData == "Nao")
            {
                // Não preencho os dados obrigatório
                CurrentPage.As<NovoUsuarioPage>().PreencherDadosDeEntrada("", "", "", data.Endereco, data.Universidade, data.Profissao, data.Genero, data.Idade);
            }
        }
    }
}
