using SeleniumBasicProjectConfiguration.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.Base
{
    public abstract class BaseSteps : BaseDriver
    {
        // Criado a Base Steps
        // A classe BasePage poderia ser usada, mas violaria as regras de estrutura
        // BasePage deve ser usado apenas para Pages e não as demais classes (Melhor prática de arquitetura)

        // Você pode realizar a comparação entre o 
        public static void Navigate()
        {
            // Acesso o site da aplicação
            DriverContext.Browser.GoToUrl(Settings.AUT);
        }

    }
}
