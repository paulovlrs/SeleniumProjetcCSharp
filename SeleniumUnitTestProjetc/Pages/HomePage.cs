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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUnitTestProjetc.Pages
{
  public class HomePage : BasePage
  {
    #region Elementos da Página
    private By ByElemento;
    private IWebElement ListaMenu => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Formulário')]"));
    private IWebElement ListaOpcaoMenu => DriverContext.Driver.FindElement(ByElemento);
    private IWebElement LinkListaUsario => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Lista de Usuários')]"));
    private IWebElement LinkBuscaElementos => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Busca de elementos')]"));
    private IWebElement LinkTextos => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Textos')]"));
    private IWebElement LinkTabela => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Tabela')]"));
    private IWebElement LinkUploadDeArquivo => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(), 'Upload de Arquivo')]"));
    #endregion

    #region Variáveis
    private WebDriverWait _wait = WaitContext.WaitDriver;
    #endregion

    public HomePage SelecionarMenu(string menu)
    {
      try
      {
        //Verifico internamente se os elementos estão presentes e clicável
        ListaMenu.AssertElementClickable();
        ListaMenu.Click();
        return this;
      }
      catch (Exception e)
      {
        Assert.Fail("Não foi possível acessar o menu '" + menu + "', erro: " + e.Message);
        return null;
      }
    }

    ///<summary>
    /// Seleciono a opção de redirecionando para a página de acordo com o parametro informado
    ///</summary>
    public HomePage SelecionarOpcaoMenu(string opcaoMenu)
    {
      try
      {
        //Verifico internamente se os elementos estão presentes
        ByElemento = By.XPath("//a[contains(.,'" + opcaoMenu + "')]");
        ListaOpcaoMenu.AssertElementClickable();
        ListaOpcaoMenu.AssertElementPresent();        
        ListaOpcaoMenu.Click();

        return this;
      }
      catch (Exception e)
      {
        Assert.Fail("Não foi possível acessar a opção '" + opcaoMenu + "', erro: " + e.Message);
        return null;
      }
    }

    public ListaDeUsuariosPage ClickLinkListaUsario()
    {
      ListaMenu.Click();
      LinkListaUsario.Click();
      return new ListaDeUsuariosPage();
    }

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
    public UploadDeArquivosPage ClickLinkUploadDeArquivo()
    {
      LinkUploadDeArquivo.AssertElementPresent();
      LinkUploadDeArquivo.Click();
      return new UploadDeArquivosPage();
    }
  }
}
