using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Config;

namespace SeleniumBasicProjectConfiguration.Helpers
{
    public class ReportHelpers : BasePage
    {
        private static ExtentReports Extent;

        private static ExtentTest Test;

        private static ExtentHtmlReporter HtmlReporter;

        private static string diretory;

        public static void ConfiguraRelatorio()
        {
            if (Extent == null)
            {
                HtmlReporter = new ExtentHtmlReporter(@"C:\Log\Report\report.html");
                HtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                HtmlReporter.Config.DocumentTitle = "Teste Selenium | Paulo Victor";
                HtmlReporter.Config.ReportName = "Teste Selenium | Paulo Victor";

                Extent = new ExtentReports();

                Extent.AttachReporter(HtmlReporter);
                Extent.AddSystemInfo("OS", "Windows");
                Extent.AddSystemInfo("Host Name", "PV-Selenium-Teste");
                Extent.AddSystemInfo("Environment", "QA");
                Extent.AddSystemInfo("UserName", "Paulo");
                                
                //HtmlReporter.LoadConfig(@"C:\Log\extent-config.xml");
            }
        }

        /// <summary>
        /// Cria o Nome do cenário de teste
        /// </summary>
        /// <param name="nameTest"></param>
        public static void CriarTeste(string nameTest)
        {
            Test = Extent.CreateTest(nameTest);
        }

        public static void DiretoryNameReport(string diretoryName)
        {
            // Pego as configurações diretamente do XML(GlobalConfig.xml)
            diretory = diretoryName;
        }

        public static void Falha(string message)
        {
            Test.Log(Status.Fail, message);
        }

        public static void Log(string message)
        {
            Test.Log(Status.Info, message);
        }
        public static void Sucesso(string message)
        {
            Test.Log(Status.Pass, message);
        }

        public static void Flush()
        {
            Extent.Flush();
        }
    }
}