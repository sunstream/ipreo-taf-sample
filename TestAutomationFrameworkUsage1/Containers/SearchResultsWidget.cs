using System;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace TestAutomationFrameworkUsage.Containers
{
    public class SearchResultsWidget : Container
    {
        [FindBy(How.TagName, "li")]
        public ElementsCollection<HtmlLink> SearchSuggestions;

        [FindBy(How.ClassName, "more-news-link")]
        public HtmlLink MoreDeviceResults;

    }
}