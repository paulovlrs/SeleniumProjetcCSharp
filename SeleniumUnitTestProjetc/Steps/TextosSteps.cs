using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;
using SeleniumUnitTestProjetc.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumUnitTestProjetc.Steps
{
    [Binding]
    public class TextosSteps : BaseSteps
    {
        [When(@"clicar no link da reportagem")]
        public void WhenClicarNoLinkDaReportagem(Table table)
        {
            CurrentPage.As<TextosPage>().ClickNews();
            ReportHelpers.Log("Acesso a página");
            LogHelpers.Write("Acesso a página");
            CurrentPage = CurrentPage.As<TextosPage>().VisualizarReportagem();
            ReportHelpers.Log("Clico na reportagem");
            LogHelpers.Write("Clico na reportagem");
        }

        [Then(@"Devo ser redicerionado para a pagina do medium")]
        public void ThenDevoSerRedicerionadoParaAPaginaDoMedium(Table table)
        {
            ReportHelpers.Log("Acesso a página do Medium");
            // Necessário o pacote *Specflow.Assist.Dynamic* para realizar a criação de variáveis
            dynamic data = table.CreateDynamicInstance();

            // Os nomes dos parametros devem ser exatamente iguais ao da tabela da feature
            if (CurrentPage.As<MediumPage>().VerificaNomeAutor(data.Autor) == true)
            {
                ReportHelpers.Sucesso("Autor reconhecido");
                //LogHelpers.Write("Autor reconhecido");
            }
            else
            {
                ReportHelpers.Falha("Não foi exibido o nome do autor");
                // LogHelpers.Write("Não foi exibido o nome do autor");
            }
            ReportHelpers.Log("Finalizado o cenário");
            LogHelpers.Write("Finalizado o cenário");
            LogHelpers.PrintScreen();
        }
    }
}