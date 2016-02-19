using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Behaviors;
using Ipreo.AutomationFramework.UI.Components.Search;
using TestAutomationFrameworkUsage.Extensions.Common.Components;

namespace TestAutomationFrameworkUsage.Containers
{
    public class SearchWidget : Container
    {
        [FindBy(How.Id, "topsearch-text")]
        private HtmlTextField SearchField;

        [FindBy(How.Xpath, "//input[@type='submit']")]
        public HtmlButton Submit;

        [FindBy(How.ClassName, "phone-results")]
        public SearchResultsWidget PhoneResultsSection;

        [FindBy(How.ClassName, "reviews-results")]
        public HtmlLabel ReviewsResultsSection;

        [FindBy(How.ClassName, "news-results")]
        public HtmlLabel NewsResultsSection;

        public void SetSearchTerm(string value)
        {
            SearchField.Click();
            SearchField.WithBehavior<ISimulateUserInputBehavior>().SetText(value);
        }

        public void PerformSearch(string deviceName)
        {
            SearchField.SetText(deviceName);
            Submit.WaitUntilElementPresent();
            Submit.Click();
        }
        
    }
}