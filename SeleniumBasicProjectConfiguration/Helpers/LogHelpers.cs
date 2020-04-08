using OpenQA.Selenium;
using System;
using System.IO;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Config;
using SeleniumBasicProjectConfiguration.Hook;

namespace SeleniumBasicProjectConfiguration.Helpers
{
    public class LogHelpers : BasePage
    {
        // Passando o dia e horário eu evito duplicação de arquivo
        private static string _logFileName = string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
        public static StreamWriter _streamW = null;
        private static string diretorio;

        public static void NameTestCase(string nameFile)
        {
            _logFileName = nameFile + "-" + _logFileName;
        }

        private static void DiretoryName()
        {
            // Pego as configurações diretamente do XML(GlobalConfig.xml)
            diretorio = (Settings.LogPath + _logFileName + "\\");
            ReportHelpers.DiretoryNameReport(diretorio);
        }

        // criar arquivo de log
        public static void CreateLogFile()
        {
            DiretoryName();
            // verifica se existe o diretório e cria o arquivo de log
            if (Directory.Exists(diretorio))
            {
                _streamW = File.AppendText(diretorio + _logFileName + ".log");
            }
            // se não existe, é criado o diretório e o arquivo de log
            else
            {
                Directory.CreateDirectory(diretorio);
                _streamW = File.AppendText(diretorio + _logFileName + ".log");
            }
        }
        // Método para registrar log
        public static void Write(string logMessage)
        {
            _streamW.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamW.Write(":\t{0}\n", logMessage);
            _streamW.Flush();
        }

        public static void PrintScreen()
        {
            string fileNameImage = string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
            Screenshot printScreen = ((ITakesScreenshot)DriverContext.Driver).GetScreenshot();
            printScreen.SaveAsFile(diretorio + fileNameImage + ".jpeg", ScreenshotImageFormat.Jpeg);
        }
    }
}
