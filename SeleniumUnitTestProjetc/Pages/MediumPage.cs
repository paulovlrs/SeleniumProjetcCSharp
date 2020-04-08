using OpenQA.Selenium;
using SeleniumBasicProjectConfiguration.Base;

namespace SeleniumUnitTestProjetc.Pages
{
    public class MediumPage : BasePage
    {
        private IWebElement NameAuthor => DriverContext.Driver.FindElement(By.XPath("//a[@class='es et bg bh bi bj bk bl bm bn eu bq br ev ew' and contains(text(),'Bruno Batista')]"));

        public bool VerificaNomeAutor(string name)
        {
            if (NameAuthor.Text.Contains(name))
            {
                return true;
            }
            return false;
        }
    }
}
