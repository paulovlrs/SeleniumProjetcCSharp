using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumBasicProjectConfiguration.Base;
using System;
using System.IO;

namespace SeleniumUnitTestProjetc.Pages
{
    public class UploadDeArquivosPage : BasePage
    {
        private IWebElement ButtonFileUpload => DriverContext.Driver.FindElement(By.XPath("//input[@type='file']"));
        private IWebElement FilePathBar => DriverContext.Driver.FindElement(By.XPath("//img[@id='thumbnail']"));
        string currentDirectoryFileName;

        public void CliqueUploadArquivo(string fileName)
        {
            // Pega o diretório da aplicação 
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            // Recebe o diretório da aplicação no "Debug" >:D
            currentDirectoryFileName = Environment.CurrentDirectory.ToString();
            // Removo os caracteres do diretório, adiciono o local da pasta e o arquivo a ser usado
            currentDirectoryFileName = currentDirectoryFileName.Remove(currentDirectoryFileName.Length - 10) + "\\FilesForTesting\\" + fileName;

            ButtonFileUpload.SendKeys(currentDirectoryFileName);            
        }

        public bool VerificaImagemAnexada()
        {
            if (FilePathBar.Displayed == true)
                return true;
            return false;
        }
    }
}
