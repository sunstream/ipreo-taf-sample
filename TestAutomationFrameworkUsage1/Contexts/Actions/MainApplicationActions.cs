using Ipreo.AutomationFramework.UI.Services;
using TestAutomationFrameworkUsage.Pages;

namespace TestAutomationFrameworkUsage.Contexts.Actions
{
    public class MainApplicationActions
    {
        public void OpenSite()
        {
            DriverService.Driver.Navigation.GoToUrl(LandingPage.URL);
        }
    }
}