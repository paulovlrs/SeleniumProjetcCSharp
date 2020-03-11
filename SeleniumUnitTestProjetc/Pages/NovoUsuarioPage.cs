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
        IWebElement MessageNotice { get; set; }

        /// <summary>
        /// Verifica se os campos da tela "Cadastrar usuário" estão disponíveis.
        /// </summary>
        internal void VerificaSeElementosDisponiveis()
        {
            InputUser_name.AssertElementPresent();
            InputUser_lastname.AssertElementPresent();
            InputUser_email.AssertElementPresent();
            InputUser_address.AssertElementPresent();
            InputUser_university.AssertElementPresent();
            InputUser_profile.AssertElementPresent();
            InputUser_gender.AssertElementPresent();
            InputUser_age.AssertElementPresent();
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
        public void PreencherDadosDeEntrada(string name, string lastName, string email, string address, string university, string profession, string genre, int age)
        {            
            InputUser_name.SendKeys(name);
            InputUser_lastname.SendKeys(lastName);
            InputUser_email.SendKeys(email);
            InputUser_address.SendKeys(address);
            InputUser_university.SendKeys(university);
            InputUser_profile.SendKeys(profession);
            InputUser_gender.SendKeys(genre);
            InputUser_age.SendKeys(age.ToString());
        }

        /// <summary>
        /// Salva os dados preenchido da tela de "Cadastrar Usuário"
        /// </summary>
        public void CliqueCriarUsuario()
        {
            ButtonCreate.Click();
        }
        /// <summary>
        /// Retorna mensagem após salvar os dados da tela "Cadastrar Usuário"
        /// </summary>
        /// <returns>
        /// string MessageNotice.Text
        /// </returns>
        public string RetornoMensagemSucesso()
        {
            // criar validação de sucesso
            return MessageNotice.Text;
        }
    }
}
