using RobinsOfgemYahooAutomationTest.Helpers;

namespace RobinsOfgemYahooAutomationTest.PageObjects.DataAttributeDecorators
{
    public class YahooMailFolderDecorators
    {
        public static string EmailSubject { get; } = SeleniumHelpers.DataDecorator("test-id", "message-subject");

        public static string EmailListItem { get; } = SeleniumHelpers.DataDecorator("test-id", "message-list-item");

        public static string SortButton { get; } = SeleniumHelpers.DataDecorator("test-id", "toolbar-sort-menu-button");

        public static string SortByDateDesc { get; } = SeleniumHelpers.DataDecorator("test-id", "sort-by-date_desc");
    }
}
