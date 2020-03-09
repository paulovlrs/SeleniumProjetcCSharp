using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUnitTestProjetc.Hook;
using SeleniumUnitTestProjetc.Pages;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;

namespace SeleniumUnitTestProjetc.Test
{
    [TestClass]
    public class NovoUsuarioTest : HookInitialize
    {
        [TestMethod]
        public void CriandoUsuario()
        {
            // Recupero os elementos da página atual para permitir controlar
            PaginaCorrente = GetInstancia<PrincipalPage>();

            // Executo ações de controle na página
            PaginaCorrente = PaginaCorrente.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
            LogHelpers.Write("Acesso a página Home");
            LogHelpers.PrintScreen();
            PaginaCorrente = PaginaCorrente.As<HomePage>().ClickLinkCriarUsuario();
            LogHelpers.Write("Acesso a página de criar usuário");
            LogHelpers.PrintScreen();


            // Verifico se existe elemento(s)
            PaginaCorrente.As<NovoUsuarioPage>().CheckIfNovoUsuarioExist();

            PaginaCorrente.As<NovoUsuarioPage>().PreencherCampos("Paulo Victor L R", "Silva", "teste@teste.com", "Rua 1", "PUC", "QA", "M", 29);
            LogHelpers.Write("Usuário inserido e salvo");
            LogHelpers.PrintScreen();

            CloseBrowser();
        }
    }
}
