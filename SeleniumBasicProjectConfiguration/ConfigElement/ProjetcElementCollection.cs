using System.Configuration;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    // Realiza a leitura de todas as tag "testSetting" que se encotra dentro da tag "ProjectConfiguration >> testSettings" do xml(App.Config do SeleniumUnitTestProjetc)
    [ConfigurationCollection(typeof(ProjectElement), AddItemName = "testSetting", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class ProjectElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            // Retorna a classe para instanciar o objeto
            return new ProjectElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as ProjectElement).Name;
        }

        public new ProjectElement this[string type]
        {
            get
            {
                return (ProjectElement)base.BaseGet(type);
            }
        }
    }
}
