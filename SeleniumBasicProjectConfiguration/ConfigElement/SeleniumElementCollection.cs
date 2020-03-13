using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    [ConfigurationCollection(typeof(SeleniumConfigElement), AddItemName ="testeSettings", CollectionType =ConfigurationElementCollectionType.BasicMap)]
    public class SeleniumElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            throw new NotImplementedException();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            throw new NotImplementedException();
        }
    }
}
