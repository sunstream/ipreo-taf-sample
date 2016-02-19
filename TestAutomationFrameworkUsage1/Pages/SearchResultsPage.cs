using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace TestAutomationFrameworkUsage.Pages
{
    public class SearchResultsPage : BasePage
    {
        
        [FindBy(How.Xpath, "//div[@class='st-text' and not(./p[@class='note'])]//b")]
        public HtmlLabel ResultsCount;

        [FindBy(How.ClassName, "article-info-name")]
        public HtmlLabel Header;

        [FindBy(How.Xpath, "//div[@class='section-body']//li")]
        public ElementsCollection<HtmlLink> FoundDevices;

        [FindBy(How.ClassName, "section-body")]
        public HtmlLabel ResultsContainer;
    }
}