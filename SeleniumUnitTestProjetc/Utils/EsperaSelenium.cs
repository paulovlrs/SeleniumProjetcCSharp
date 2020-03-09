using System;
using OpenQA.Selenium;
using SeleniumBasicProjectConfiguration.Base;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumUnitTestProjetc.Utils
{
    public static class EsperaSelenium
    {
       /* public static IWebElement RetornarElementoVisivel(By idElement)
        {
            IWebElement element;
            bool stale = true;
            int tentativa = 0;
            while (stale)
            {
                try
                {

                    element = DriverContext.TempoEsperaElemento.Until(ExpectedConditions.ElementExists(idElement));
                    element = DriverContext.TempoEsperaElemento.Until(ExpectedConditions.ElementIsVisible(idElement));
                    stale = false;
                    // criar registro de log de falhas
                    throw new System.InvalidOperationException($"Elemento localizado: {idElement} - Tentativa: {tentativa}");
                    return element;
                }
                catch (StaleElementReferenceException e)
                {
                    // criar registro de log de falhas
                    throw new System.InvalidOperationException($"ERRO - O elemento não foi encontrado - tentativa: {tentativa} mensagem de erro: - {e.Message}");
                    stale = true;
                }
                catch (WebDriverTimeoutException error)
                {
                    // criar registro de log de falhas
                    throw new System.InvalidOperationException(error.Message);
                    return null;
                }
                tentativa++;
            }
            return null;
        }

        public static void VerificaElementoClicavel(IWebElement idElement)
        {
            IWebElement element = DriverContext.TempoEsperaElemento.Until(ExpectedConditions.ElementToBeClickable(idElement));
            bool stale = true;
            if (element != null)
            {
                while (stale)
                {
                    try
                    {
                        DriverContext.TempoEsperaElemento.Until(ExpectedConditions.ElementToBeClickable(idElement));
                    }
                    catch (StaleElementReferenceException e)
                    {
                        throw new System.InvalidOperationException(e.Message);
                        stale = true;
                    }
                    catch (NoSuchElementException e)
                    {
                        throw new System.InvalidOperationException(e.Message);
                        stale = true;
                    }
                    catch (TimeoutException error)
                    {
                        throw new System.InvalidOperationException(error.Message);                        
                    }
                }
            }
        }*/

    }
}
