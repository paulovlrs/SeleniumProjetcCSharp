using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumUnitTestProjetc.Utils;
using SeleniumBasicProjectConfiguration.Base;

namespace SeleniumUnitTestProjetc.Pages
{
    public class HomePage : BasePage
    {
        // Objetos da Página
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Formulário')]")]
        private IWebElement LinkFormulario { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Criar Usuários')]")]
        private IWebElement LinkCriarUsuario { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Lista de Usuários')]")]
        private IWebElement LinkListaUsario { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Busca de elementos')]")]
        private IWebElement LinkBuscaElementos { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Links')]")]
        private IWebElement LinkLinks { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Inputs e TextField')]")]
        private IWebElement LinkInputTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Botões')]")]
        private IWebElement LinkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Radio e Checkbox')]")]
        private IWebElement LinkRadioCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Dropdown e Select')]")]
        private IWebElement LinkDropdownSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Textos')]")]
        private IWebElement LinkTextos { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Tabela')]")]
        private IWebElement LinkTabela { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Mudança de foco')]")]
        private IWebElement LinkMudancaFoco { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Alert')]")]
        private IWebElement LinkAlerta { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Iframe')]")]
        private IWebElement LinkIframe { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Janela')]")]
        private IWebElement LinkJanela { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Modal')]")]
        private IWebElement LinkModal { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Widgets')]")]
        private IWebElement LinkWidgets { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Accordion')]")]
        private IWebElement LinkAccordion { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Autocomplete')]")]
        private IWebElement LinkAutocomplete { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Datapicker')]")]
        private IWebElement LinkDatapicker { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Iterações')]")]
        private IWebElement LinkIteracoes { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Drag And Drop')]")]
        private IWebElement LinkDragAndDrop { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Mousehover')]")]
        private IWebElement LinkMousehover { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Outros')]")]
        private IWebElement LinkOutros { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Upload de Arquivo')]")]
        private IWebElement LinkUploadDeArquivo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Basic Auth(user:admin, password: admin)')]")]
        private IWebElement LinkBasicAuth { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Scroll')]")]
        private IWebElement LinkScroll { get; set; }

        // Como são chamadas de novas telas, eu realiazio o retorno da classe corresponde
        public void ClickLinkAccordion() { }
        public void ClickLinkAlerta() { }
        public void ClickLinkAutocomplete() { }
        public void ClickLinkBasicAuth() { }
        public void ClickLinkButton() { }

        /// <summary>
        /// Expande o menu de "Formulário" e aciona a opção "Criar Usuários", redirecionando para a página de criação de usuários.
        /// </summary>
        public NovoUsuarioPage ClickLinkCriarUsuario()
        {
            LinkFormulario.Click();
            LinkCriarUsuario.Click();
            return new NovoUsuarioPage();
        }
        public void ClickLinkDatapicker() { }
        public void ClickLinkDragAndDrop() { }
        public void ClickLinkDropdownSelect() { }
        public void ClickLinkIframe() { }
        public void ClickLinkInputTextField() { }
        public void ClickLinkJanela() { }
        public void ClickLinkLinks() { }
        public ListaDeUsuariosPage ClickLinkListaUsario()
        {
            LinkFormulario.Click();
            LinkListaUsario.Click();
            return new ListaDeUsuariosPage();
        }
        public void ClickLinkModal() { }
        public void ClickLinkMousehover() { }
        public void ClickLinkRadioCheckBox() { }
        public void ClickLinkScroll() { }
        public TabelaPage ClickLinkTabela()
        {
            LinkBuscaElementos.Click();
            LinkTabela.Click();
            return new TabelaPage();
        }
        public void ClickLinkTextos() { }
        public void ClickLinkUploadDeArquivo() { }

    }
}
