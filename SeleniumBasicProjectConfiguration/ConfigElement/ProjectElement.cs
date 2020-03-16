using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.ConfigElement
{
    public class ProjectElement : ConfigurationSection
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)base["name"];
            }
        }

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUTget
        {
            get
            {
                return (string)base["aut"];
            }

        }
    }
}
