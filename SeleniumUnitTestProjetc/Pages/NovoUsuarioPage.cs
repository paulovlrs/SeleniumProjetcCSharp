using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Extensions;

namespace SeleniumUnitTestProjetc.Pages
{
    public class NovoUsuarioPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "user_name")]
        private IWebElement InputNome { get; set; }

        [FindsBy(How = How.Id, Using = "user_lastname")]
        private IWebElement InputUltimoNome { get; set; }

        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement InputEmail { get; set; }

        [FindsBy(How = How.Id, Using = "user_address")]
        private IWebElement InputEndereco { get; set; }

        [FindsBy(How = How.Id, Using = "user_university")]
        private IWebElement InputUniversidade { get; set; }

        [FindsBy(How = How.Id, Using = "user_profile")]
        private IWebElement InputProfissao { get; set; }

        [FindsBy(How = How.Id, Using = "user_gender")]
        private IWebElement InputGenero { get; set; }

        [FindsBy(How = How.Id, Using = "user_age")]
        private IWebElement InputIdade { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class = 'actions btn waves-effect green']")]
        private IWebElement ButtonCriar { get; set; }

        internal void CheckIfNovoUsuarioExist()
        {
            InputNome.AssertElementPresent();
        }

        [FindsBy(How = How.CssSelector, Using = "[class = 'btn waves-light red']")]
        private IWebElement ButtonVoltar { get; set; }

        /// <summary>
        /// Preenche os campos da tela de "Cadastrar usuário".
        /// </summary>
        public void PreencherCampos(string nome, string ultimoNome, string email, string endereco, string universidade, string profissao, string genero, int idade)
        {
            InputNome.SendKeys(nome);
            InputUltimoNome.SendKeys(ultimoNome);
            InputEmail.SendKeys(email);
            InputEndereco.SendKeys(endereco);
            InputUniversidade.SendKeys(universidade);
            InputProfissao.SendKeys(profissao);
            InputGenero.SendKeys(genero);
            InputIdade.SendKeys(idade.ToString());
            ButtonCriar.Click();
        }
    }
}
