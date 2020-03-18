using System.Configuration;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    public class ProjectConfiguration : ConfigurationSection
    {
        // O namespace System.Configuration contém os tipos que fornecem o modelo de programação para 
        // lidar com os dados de configuração.

        // ProjectConfiguration é o nome da tag do XML configurado(App.config do SeleniumUnitTestProjetc)
        // Para que fosse possível iniciar, deve ser chamado dentro da tag "configSections" as configurações 
        // de leitura do XML
        private static ProjectConfiguration _projectConfigElement = (ProjectConfiguration)ConfigurationManager.GetSection("ProjectConfiguration");

        public static ProjectConfiguration ProjectSettings
        {
            get { return _projectConfigElement; }
        }

        [ConfigurationProperty("testSettings")]
        public ProjectElementCollection TestSettings
        {
            get { return (ProjectElementCollection)base["testSettings"]; }
        }
    }
}