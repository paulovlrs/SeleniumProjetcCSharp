﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumBasicProjectConfiguration.Helpers;
using SeleniumBasicProjectConfiguration.Hook;
using TechTalk.SpecFlow;

namespace SeleniumUnitTestProjetc.Hook
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
            Initialize();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterFeature]
        public static void TestEnd()
        {
            ReportHelpers.Flush();
            CloseBrowser();
        }
    }
}
