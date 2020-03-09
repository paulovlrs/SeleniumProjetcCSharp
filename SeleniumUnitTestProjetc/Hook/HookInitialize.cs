using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumBasicProjectConfiguration.Hook;

namespace SeleniumUnitTestProjetc.Hook
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
            Initialize();
            Navigate();
        }
    }
}
