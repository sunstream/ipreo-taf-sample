using System;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Services;

namespace TestAutomationFrameworkUsage.Extensions.Common.Components
{
    public static class ElementExtensions
    {
        public static void WaitUntilElementPresent(this IElement element, int seconds = 5)
        {
            new SmartWait().SetTimeout(TimeSpan.FromSeconds(seconds)).WaitUntil(element, e => e.Exists);
        }

        public static void WaitUntilElementHidden(this IElement element, int seconds = 3)
        {
            new SmartWait().SetTimeout(TimeSpan.FromSeconds(seconds)).WaitUntil(element, e => !e.Displayed);
        }
    }
}