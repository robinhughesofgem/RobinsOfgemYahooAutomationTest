using RobinsOfgemYahooAutomationTest.Helpers;

namespace RobinsOfgemYahooAutomationTest.PageObjects.DataAttributeDecorators
{
    public class YahooMailSideBarDecorators
    {
        public static string JunkFolderButton { get; } = SeleniumHelpers.DataDecorator("test-folder-name", "Junk");

        public static string TrashButton { get; } = SeleniumHelpers.DataDecorator("test-folder-name", "Trash");

        public static string InboxButton { get; } = SeleniumHelpers.DataDecorator("test-folder-name", "Inbox");
    }
}
