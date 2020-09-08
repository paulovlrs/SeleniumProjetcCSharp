using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUnitTestProjetc.Hook;
using SeleniumUnitTestProjetc.Pages;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;

namespace SeleniumUnitTestProjetc.Test
{
    //[TestClass]
    public class TabelaTest : HookInitialize
    {
        //[TestMethod]
        public void VerificaTabela() 
        {
            CurrentPage = GetInstance<PrincipalPage>();
            LogHelpers.Write("Acesso a página principal");
            CurrentPage = CurrentPage.As<PrincipalPage>().ClickButtonComecarAutomacaoWeb();
            CurrentPage = CurrentPage.As<HomePage>().ClickLinkTabela();

            /*var tabela = PaginaCorrente.As<TabelaPage>().ReceberElementosTabela();


            HtmlTableHelpers.ReadTable(tabela);
            // Informo <quantidade> de colunas, a <coluna> para se buscar o valor, <valor> procurado e <ação>
            HtmlTableHelpers.PerformActionOnCell("2", "Nome", "Arroz", "1");
            */

            /*
             * https://stackoverflow.com/questions/34724911/handling-tables-in-c-sharp-selenium
             * https://sqa.stackexchange.com/questions/26278/selenium-webdriver-c-and-accessing-rows-in-a-table
             * https://www.toolsqa.com/selenium-webdriver/c-sharp/handle-dynamic-webtables-with-selenium-in-csharp/
             * https://stackoverflow.com/questions/43853855/webdriver-how-to-click-on-a-button-for-a-specific-row-of-a-table-c
             */


            FinalizarDriver();
        }
    }
}
