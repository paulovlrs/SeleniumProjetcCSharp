using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumUnitTestProjetc.Utils;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Extensions;

namespace SeleniumUnitTestProjetc.Pages
{
    public class HomePage : BasePage
    {
        //Elementos da Página
        private IWebElement LinkFormulario => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Formulário')]"));
        private IWebElement LinkCriarUsuario => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Criar Usuários')]"));
        private IWebElement LinkListaUsario => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Lista de Usuários')]"));
        private IWebElement LinkBuscaElementos => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Busca de elementos')]"));
        private IWebElement LinkLinks => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Links')]"));
        private IWebElement LinkInputTextField => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Inputs e TextField')]"));
        private IWebElement LinkButton => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Botões')]"));
        private IWebElement LinkRadioCheckBox => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Radio e Checkbox')]"));
        private IWebElement LinkDropdownSelect => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Dropdown e Select')]"));
        private IWebElement LinkTextos => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Textos')]"));
        private IWebElement LinkTabela => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Tabela')]"));
        private IWebElement LinkMudancaFoco => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Mudança de foco')]"));
        private IWebElement LinkAlerta => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Alert')]"));
        private IWebElement LinkIframe => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Iframe')]"));
        private IWebElement LinkJanela => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Janela')]"));
        private IWebElement LinkModal => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Modal')]"));
        private IWebElement LinkWidgets => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Widgets')]"));
        private IWebElement LinkAccordion => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Accordion')]"));
        private IWebElement LinkAutocomplete => DriverContext.Driver.FindElement(By.XPath("/a[contains(text(), 'Autocomplete')]"));
        private IWebElement LinkDatapicker => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Datapicker')]"));
        private IWebElement LinkIteracoes => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Iterações')]"));
        private IWebElement LinkDragAndDrop => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Drag And Drop')]"));
        private IWebElement LinkMousehover => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Mousehover')]"));
        private IWebElement LinkOutros => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Outros')]"));
        private IWebElement LinkUploadDeArquivo => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Upload de Arquivo')]"));
        private IWebElement LinkBasicAuth => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Basic Auth(user:admin, password: admin)')]"));
        private IWebElement LinkScroll => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Scroll')]"));

        //Como são chamadas de novas telas, eu realizo o retorno da classe corresponde
        public void ClickLinkAccordion() { }
        public void ClickLinkAlerta() { }
        public void ClickLinkAutocomplete() { }
        public void ClickLinkBasicAuth() { }
        public void ClickLinkButton() { }

        ///<summary>
        ///Expande o menu de "Formulário" e aciona a opção "Criar Usuários", redirecionando para a página de criação de usuários.
        ///</summary>
        public NovoUsuarioPage ClickLinkCriarUsuario()
        {
            //Verifico internamente se os elementos estão presentes
            GetLinkFormulario().AssertElementPresent();
            LinkFormulario.Click();

            LinkCriarUsuario.AssertElementPresent();
            LinkCriarUsuario.Click();
            return new NovoUsuarioPage();
        }

        private IWebElement GetLinkFormulario()
        {
            return LinkFormulario;
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

        public TextosPage ClickLinkTextos()
        {
            //Verifico internamente se os elementos estão presentes
            LinkBuscaElementos.AssertElementPresent();
            LinkBuscaElementos.Click();

            LinkTextos.AssertElementPresent();
            LinkTextos.Click();
            return new TextosPage();
        }
        public void ClickLinkUploadDeArquivo() { }

    }
}
