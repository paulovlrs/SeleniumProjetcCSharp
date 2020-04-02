using SeleniumBasicProjectConfiguration.Base;
using System;
using TechTalk.SpecFlow;

namespace SeleniumUnitTestProjetc.Steps
{
    [Binding]
    public class TextosSteps : BaseSteps
    {
        [When(@"clicar no link da reportagem")]
        public void WhenClicarNoLinkDaReportagem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Devo ser redicerionado para a pagina do medium")]
        public void ThenDevoSerRedicerionadoParaAPaginaDoMedium()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
