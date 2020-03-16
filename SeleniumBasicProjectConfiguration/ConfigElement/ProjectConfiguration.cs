using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    public class ProjectConfiguration : ConfigurationElement
    {
        // O namespace System.Configuration contém os tipos que fornecem o modelo de programação para lidar com os dados de configuração.

        // ProjectConfiguration é o nome da tag do XML configurado
        private static ProjectConfiguration _projetConfigElement = (ProjectConfiguration)ConfigurationManager.GetSection("ProjectConfiguration");

        public static ProjectConfiguration ProjectSettings
        {
            get
            {
                return _projetConfigElement;
            }
        }
        
        [ConfigurationProperty("testSettings")]
        public ProjetcElementCollection TestSetings
        {
            get
            {
                return (ProjetcElementCollection)base["testSettings"];
            }
        }
    }
}