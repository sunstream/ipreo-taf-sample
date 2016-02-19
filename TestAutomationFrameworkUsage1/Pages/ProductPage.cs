using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace TestAutomationFrameworkUsage.Pages
{
    public class ProductPage : BasePage
    {
        [FindBy(How.ClassName, "specs-phone-name-title")]
        public HtmlLabel DeviceName;
    }
}