using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace TestAutomationFrameworkUsage.Pages
{
    
    public class LandingPage : BasePage
    {
        public const string URL = "http://www.gsmarena.com/";

        [FindBy(How.ClassName, "pad-finder")]
        public HtmlButton PhoneFinderButton;

    }
}
