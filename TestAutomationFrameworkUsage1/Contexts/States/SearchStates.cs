using System;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Services;
using TestAutomationFrameworkUsage.Containers;
using TestAutomationFrameworkUsage.Extensions.Common.Components;
using TestAutomationFrameworkUsage.Pages;

namespace TestAutomationFrameworkUsage.Contexts.States
{
    public class SearchStates
    {
        private readonly SearchWidget _searchWidget;
        private readonly SearchResultsPage _searchResults;

        public SearchStates()
        {
            _searchWidget = PageService.Create<SearchWidget>();
            _searchResults = PageService.Create<SearchResultsPage>();
        }

        public bool IsValuePresentInSearchSuggestions(string deviceName)
        {
            bool result = false;
            FilterSearchResults(deviceName, _searchWidget.PhoneResultsSection.SearchSuggestions, deviceLink => { result = true; });
            return result;
        }

        public bool IsValuePresentInSearchResults(string deviceName)
        {
            _searchResults.ResultsContainer.WaitUntilElementPresent();
            bool result = false;
            FilterSearchResults(deviceName, _searchResults.FoundDevices, deviceLink => { result = true; });
            return result;
        }

        public bool IsSearchResultsPageActive()
        {
            return _searchResults.Header.Displayed;
        }

        public int GetResultsCount()
        {
            string results = _searchResults.ResultsCount.GetText();
            return Int32.Parse(results);
        }

        private void FilterSearchResults(string deviceName, ElementsCollection<HtmlLink> results, Action<HtmlLink> action)
        {
            foreach (var device in results)
            {
                var suggestedDeviceName = device.GetText().Replace(Environment.NewLine, " ");
                if (suggestedDeviceName == deviceName)
                {
                    action.Invoke(device);
                    break;
                }
            }
        }
    }
}