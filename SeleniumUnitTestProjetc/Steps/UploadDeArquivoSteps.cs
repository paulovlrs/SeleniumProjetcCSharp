using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;
using SeleniumUnitTestProjetc.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumUnitTestProjetc.Steps
{
    [Binding]
    public class UploadDeArquivoSteps : BaseSteps
    {
        [When(@"Adicionar um arquivo")]
        public void WhenAdicionarUmArquivo(Table table)
        {
            // Necessário o pacote *Specflow.Assist.Dynamic* para realizar a criação de variáveis
            dynamic data = table.CreateDynamicInstance();

            CurrentPage.As<UploadDeArquivosPage>().CliqueUploadArquivo(data.Arquivo);
            ReportHelpers.Log("Envio o arquivo");
            LogHelpers.Write("Envio o arquivo");
        }

        [Then(@"O arquivo deve ser exibido")]
        public void ThenOArquivoDeveSerExibido()
        {
            if (CurrentPage.As<UploadDeArquivosPage>().VerificaImagemAnexada() == true)
            {
                ReportHelpers.Sucesso("Envio o arquivo");
                LogHelpers.Write("Envio o arquivo");
            }
            else
            {
                ReportHelpers.Falha("Arquivo não é visualizado ou não foi enviado");
                LogHelpers.Write("Arquivo não é visualizado ou não foi enviado");
            }
        }
    }
}
