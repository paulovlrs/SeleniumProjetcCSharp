using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumBasicProjectConfiguration.Base;
using SeleniumBasicProjectConfiguration.Helpers;
using NUnit.Framework;

namespace SeleniumBasicProjectConfiguration.Extensions
{
  public static class WebElementExtensions
  {
    public static string GetSelectDropDownList(this IWebElement element)
    {
      SelectElement ddl = new SelectElement(element);
      return ddl.AllSelectedOptions.First().ToString();
    }
    public static IList<IWebElement> GetSelectListOptions(this IWebElement element)
    {
      SelectElement ddl = new SelectElement(element);
      return ddl.AllSelectedOptions;
    }
    public static void SelectDropDownList(this IWebElement element, string value)
    {
      SelectElement ddl = new SelectElement(element);
      ddl.SelectByText(value);
    }
    public static void Hover(this IWebElement element)
    {
      Actions actions = new Actions(DriverContext.Driver);
      actions.MoveToElement(element).Perform();
    }
    public static void AssertElementPresent(this IWebElement element)
    {
      if (!IsElementPresent(element))
        throw new Exception(string.Format("Elemento não está presente"));
    }
    public static void AssertElementClickable(this IWebElement element)
    {
      try
      {
        WaitContext.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(element));
      }
      catch (Exception e)
      {
        throw new Exception(string.Format("Não foi possível clicar no elemento, erro: " + e.Message));
      }
    }

    private static bool IsElementPresent(IWebElement element)
    {
      try
      {
        return element.Displayed;
      }
      catch (Exception e)
      {
        Assert.Fail("Elemento não está disponível, erro: " + e.Message);
        return false;
      }
    }

    private static bool IsElementListPresent(IList<IWebElement> element)
    {
      try
      {
        int ele = element.Count;
        if (ele > 0)
          return true;
        else
          return false;
      }
      catch (Exception e)
      {
        return false;
      }
    }
    /// <summary>
    /// Verifica se existe a lista de elementos e retorna a mesma lista de elementos
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static IList<IWebElement> ReturnAssertElementListPresent(this IList<IWebElement> element)
    {
      if (!IsElementListPresent(element))
        return null;
      else
        return element;
    }
    /// <summary>
    /// Verifica se elemento está presente e retorna o mesmo elemento
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static IWebElement ReturnAssertElementPresent(this IWebElement element)
    {
      if (!IsElementPresent(element))
        return null;
      else
        return element;
    }
  }
}
