using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;
using TestAutomationFrameworkUsage.Containers;

namespace TestAutomationFrameworkUsage.Pages
{
    public abstract class BasePage : Page
    {
        [FindBy(How.ClassName, "pad-finder")]
        public SearchWidget SearchWidget;
    }
}