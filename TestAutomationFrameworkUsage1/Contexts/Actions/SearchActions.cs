using System;
using System.Linq;
using Ipreo.AutomationFramework.UI.Services;
using TestAutomationFrameworkUsage.Containers;
using TestAutomationFrameworkUsage.Extensions.Common.Components;
using TestAutomationFrameworkUsage.Pages;

namespace TestAutomationFrameworkUsage.Contexts.Actions
{
    public class SearchActions
    {
        private SearchWidget _searchWidget;
        private SearchResultsPage _searchResults;

        public SearchActions()
        {
            _searchWidget = PageService.Create<SearchWidget>();
            _searchResults = PageService.Create<SearchResultsPage>();
        }

        public void SetSearchTerm(string searchTerm)
        {
            _searchWidget.SetSearchTerm(searchTerm);
            _searchWidget.ReviewsResultsSection.WaitUntilElementPresent();
            _searchWidget.NewsResultsSection.WaitUntilElementPresent();
            _searchWidget.PhoneResultsSection.MoreDeviceResults.WaitUntilElementPresent();
        }

        public void SubmitSearch()
        {
            _searchWidget.Submit.Click();
        }

        public void PerformSearch(string deviceName)
        {
            _searchWidget.PerformSearch(deviceName);
        }

        public void WaitUntilSearchSuggestionsRefreshAndContain(string value)
        {
            TimeSpan refreshTimeout = TimeSpan.FromSeconds(5);
            new SmartWait()
                .SetTimeout(refreshTimeout)
                .WaitUntil(_searchWidget.PhoneResultsSection.SearchSuggestions, results =>
                {
                    if (!(results.Any() && results[0].GetText().Contains(value)))
                    {
                        results.Refresh();
                        return false;
                    }
                    return true;
                });
        }

        public void SeeAllDeviceResults()
        {
            _searchWidget.NewsResultsSection.WaitUntilElementPresent(10);
            _searchWidget.ReviewsResultsSection.WaitUntilElementPresent(10);
            _searchWidget.PhoneResultsSection.MoreDeviceResults.WaitUntilElementPresent(10);
            _searchWidget.PhoneResultsSection.MoreDeviceResults.Click();
        }

        
        
    }
}