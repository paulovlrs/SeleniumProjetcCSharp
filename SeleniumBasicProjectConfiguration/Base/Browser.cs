using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumBasicProjectConfiguration.Config;

namespace SeleniumBasicProjectConfiguration.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }        

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }  
}
