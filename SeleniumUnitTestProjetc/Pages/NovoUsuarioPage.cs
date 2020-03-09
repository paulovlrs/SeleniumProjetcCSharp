using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Extensions;
using System;
using System.Collections.Generic;

namespace SeleniumUnitTestProjetc.Pages
{
    public class NovoUsuarioPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "user_name")]
        private IWebElement InputUser_name { get; set; }

        [FindsBy(How = How.Id, Using = "user_lastname")]
        private IWebElement InputUser_lastname { get; set; }

        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement InputUser_email { get; set; }

        [FindsBy(How = How.Id, Using = "user_address")]
        private IWebElement InputUser_address { get; set; }

        [FindsBy(How = How.Id, Using = "user_university")]
        private IWebElement InputUser_university { get; set; }

        [FindsBy(How = How.Id, Using = "user_profile")]
        private IWebElement InputUser_profile { get; set; }

        [FindsBy(How = How.Id, Using = "user_gender")]
        private IWebElement InputUser_gender { get; set; }

        [FindsBy(How = How.Id, Using = "user_age")]
        private IWebElement InputUser_age { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class = 'actions btn waves-effect green']")]
        private IWebElement ButtonCreate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class = 'btn waves-light red']")]
        private IWebElement ButtonBack { get; set; }

        [FindsBy(How = How.Id, Using = "error_explanation")]
        private IList<IWebElement> MessageErro { get; set; }

        [FindsBy(How = How.Id, Using = "notice")]
        private IList<IWebElement> MessageNotice { get; set; }

        internal void CheckIfNovoUsuarioExist()
        {
            InputUser_name.AssertElementPresent();
        }        

        public void MensagemAlerta(string mensagem)
        {
            //IList<IWebElement> all = DriverContext.Driver.FindElements(By.Id("error_explanation"));
 
            String[] allText = new String[MessageErro.Count];
            int i = 0;
            
            // Criar validação da mensagem de erro esperado
            foreach (IWebElement element in MessageErro)
            {
                allText[i++] = element.Text;
            }         
        }

        /// <summary>
        /// Preenche os campos da tela de "Cadastrar usuário".
        /// </summary>
        public void PreencherCampos(string nome, string ultimoNome, string email, string endereco, string universidade, string profissao, string genero, int idade)
        {
            InputUser_name.SendKeys(nome);
            InputUser_lastname.SendKeys(ultimoNome);
            InputUser_email.SendKeys(email);
            InputUser_address.SendKeys(endereco);
            InputUser_university.SendKeys(universidade);
            InputUser_profile.SendKeys(profissao);
            InputUser_gender.SendKeys(genero);
            InputUser_age.SendKeys(idade.ToString());
            ButtonCreate.Click();
        }

        public string MensagemSucesso(string mensagem)
        {
            // criar validação de sucesso

            return null;
        }
    }
}
