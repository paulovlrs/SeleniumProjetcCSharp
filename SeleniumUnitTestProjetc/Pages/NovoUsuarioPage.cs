using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Extensions;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumBasicProjectConfiguration.Helpers;
using Microsoft.JScript;

namespace SeleniumUnitTestProjetc.Pages
{
  public class NovoUsuarioPage : BasePage
  {
    // Elementos da página
    private IWebElement InputUser_name => DriverContext.Driver.FindElement(By.Id("user_name"));
    private IWebElement InputUser_lastname => DriverContext.Driver.FindElement(By.Id("user_lastname"));
    private IWebElement InputUser_email => DriverContext.Driver.FindElement(By.Id("user_email"));
    private IWebElement InputUser_address => DriverContext.Driver.FindElement(By.Id("user_address"));
    private IWebElement InputUser_university => DriverContext.Driver.FindElement(By.Id("user_university"));
    private IWebElement InputUser_profile => DriverContext.Driver.FindElement(By.Id("user_profile"));
    private IWebElement InputUser_gender => DriverContext.Driver.FindElement(By.Id("user_gender"));
    private IWebElement InputUser_age => DriverContext.Driver.FindElement(By.Id("user_age"));
    private IWebElement ButtonCreate => DriverContext.Driver.FindElement(By.CssSelector("[class = 'actions btn waves-effect green']"));
    private IWebElement ButtonBack => DriverContext.Driver.FindElement(By.CssSelector("[class = 'btn waves-light red']"));
    private IList<IWebElement> MessageErro => DriverContext.Driver.FindElements(By.Id("error_explanation"));
    IWebElement MessageNotice => DriverContext.Driver.FindElement(By.Id("notice"));

    /// <summary>
    /// Verifica se os campos da tela "Cadastrar usuário" estão disponíveis.
    /// </summary>
    internal void VerificaSeElementosDisponiveisCadastroUsuario()
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

    /// <summary>
    /// Retorna falha na execução e informa o motivo
    /// </summary>
    /// <param name="message"></param>
    public void FalhaExecucao(string message)
    {
      Assert.Fail(message);
    }

    /// <summary>
    /// Preenche os campos da tela de "Cadastrar usuário".
    /// </summary>
    public void PreencherDadosDeEntrada(string name, string lastName, string email, string address, string university, string profession, string genre, int age)
    {
      try
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
      catch (Exception e)
      {
        ReportHelpers.Log("Não foi possível preencher os dados de cadastros do usuário, erro:" + e.Message);
      }
    }

    /// <summary>
    /// Salva os dados preenchido da tela de "Cadastrar Usuário"
    /// </summary>
    public void CliqueCriarUsuario()
    {
      ButtonCreate.AssertElementPresent();
      ButtonCreate.Click();
    }

    /// <summary>
    /// Valida se a mensagem esperada está sendo exibida e retorna um valor booleano
    /// </summary>
    /// <param name="mensagem"></param>
    /// <returns>bool</returns>
    public bool ValidarMensagem(string message)
    {
      try
      {
        // Verifico se os elementos de mensagens estão preenchidos
        if (message == "Usuário Criado com sucesso" && MessageNotice.ReturnAssertElementPresent() != null && MessageNotice.Text.Contains(message))
        {
          return true;
        }
        else if (message == "3 errors proibiu que este usuário fosse salvo" && MessageErro.ReturnAssertElementListPresent() != null)
        {
          foreach (IWebElement element in MessageErro)
          {
            //allText[i++] = element.Text;
            if (element.Text.Contains(message))
              return true;
          }
        }
        return false;
      }

      catch(Exception e)
      {
        ReportHelpers.Log(System.Convert.ToString(e));
        return false;
      }
    }
  }
}
