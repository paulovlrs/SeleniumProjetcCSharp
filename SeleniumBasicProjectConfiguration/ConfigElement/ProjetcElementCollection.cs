using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    [ConfigurationCollection(typeof(ProjectConfiguration), AddItemName ="testeSettings", CollectionType =ConfigurationElementCollectionType.BasicMap)]
    public class ProjetcElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
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
