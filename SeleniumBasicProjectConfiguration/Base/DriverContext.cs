using OpenQA.Selenium;

namespace SeleniumBasicProjectConfiguration.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        //private static IAlert _alert;

        // Classe para chamar o driver, ao inves de fazer diversas chamadas
        public static IWebDriver Driver
        {
            get
            {
                //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
        public static Browser Browser { get; set; }
    }
}
