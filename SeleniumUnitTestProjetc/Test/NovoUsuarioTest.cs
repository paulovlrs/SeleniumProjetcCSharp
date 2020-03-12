using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUnitTestProjetc.Hook;
using SeleniumUnitTestProjetc.Pages;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;

namespace SeleniumUnitTestProjetc.Test
{
    //[TestClass]
    public class NovoUsuarioTest : HookInitialize
    {
        //[TestMethod]
        public void CriandoUsuario()
        {
            // Recupero os elementos da página atual para permitir controlar
            CurrentPage = GetInstance<PrincipalPage>();

            // Executo ações de controle na página
            CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
            LogHelpers.Write("Acesso a página Home");
            LogHelpers.PrintScreen();
            CurrentPage = CurrentPage.As<HomePage>().ClickLinkCriarUsuario();
            LogHelpers.Write("Acesso a página de criar usuário");
            LogHelpers.PrintScreen();

            // Verifico se existe elemento(s)
            CurrentPage.As<NovoUsuarioPage>().VerificaSeElementosDisponiveis();

            // Preencho os campos
            CurrentPage.As<NovoUsuarioPage>().PreencherDadosDeEntrada("Paulo Victor L R", "Silva", "teste@teste.com", "Rua 1", "PUC", "QA", "M", 29);
            CurrentPage.As<NovoUsuarioPage>().CliqueCriarUsuario();
            LogHelpers.Write("Usuário inserido e salvo");
            //verifico se usuário foi criado com sucesso
            if (CurrentPage.As<NovoUsuarioPage>().ValidarMensagem("Usuário Criado com sucesso") == false)
                CurrentPage.As<NovoUsuarioPage>().FalhaExecucao("Usuário não foi criado");

            //var a = CurrentPage.As<NovoUsuarioPage>().MensagemSucesso();
            LogHelpers.PrintScreen();

            CloseBrowser();
        }
    }
}
