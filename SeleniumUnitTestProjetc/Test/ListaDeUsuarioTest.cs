using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumUnitTestProjetc.Hook;
using SeleniumUnitTestProjetc.Pages;
using SeleniumUnitTestProjetc.Utils;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;

namespace SeleniumUnitTestProjetc.Test
{
   // [TestClass]
    public class ListaDeUsuarioTest : HookInitialize
    {
       // [TestMethod]
        public void ListandoUsuario()
        {

            CurrentPage = GetInstance<PrincipalPage>();
            CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();

            CurrentPage = CurrentPage.As<HomePage>().ClickLinkListaUsario();
            //PaginaCorrente.As<ListaDeUsuariosPage>().DeletarNome("");

            /*var tabela = PaginaCorrente.As<ListaDeUsuariosPage>().ReceberElementosTabela();


            HtmlTableHelpers.ReadTable(tabela);
            // Informo <quantidade> de colunas, a <coluna> para se buscar o valor, <valor> procurado e <ação>
            HtmlTableHelpers.PerformActionOnCell("9", "Nome", "AAA", "delete");
            */
            FinalizarDriver();
        }
    }
}
