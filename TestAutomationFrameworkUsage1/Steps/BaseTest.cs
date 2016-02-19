﻿using Ipreo.AutomationFramework.UI.Services;
using TechTalk.SpecFlow;

namespace TestAutomationFrameworkUsage.Steps
{
    [Binding]
    public class BaseTest
    {
        [BeforeScenario]
        public void ResetDriverState()
        {
            DriverService.Driver.ResetCookies();
        }

        [AfterFeature]
        public static void TeardownDriver()
        {
            DriverService.Driver.Reset();
        }
    }
}