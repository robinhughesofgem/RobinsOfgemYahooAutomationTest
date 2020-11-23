using RobinsOfgemYahooAutomationTest.Helpers;

namespace RobinsOfgemYahooAutomationTest.PageObjects.DataAttributeDecorators
{
    class YahooMailMessageDecorators
    {
        public static string BackButton { get; } = SeleniumHelpers.DataDecorator("test-id", "toolbar-back-to-list");
        
        public static string MessageDate { get; } = SeleniumHelpers.DataDecorator("test-id", "message-date");

        public static string MessageFrom { get; } = SeleniumHelpers.DataDecorator("test-id", "message-from");

        public static string MessageSubjectText { get; } = SeleniumHelpers.DataDecorator("test-id", "message-group-subject-text");

        public static string ToolbarDeleteButton { get; } = SeleniumHelpers.DataDecorator("test-id", "toolbar-delete");

        public static string ToolbarMoveButton { get; } = SeleniumHelpers.DataDecorator("test-id", "folder-menu-button");

        public static string JunkFolderButton { get; } = SeleniumHelpers.DataDecorator("test-id", "item-move-to-folder-id-26");

        public static string ToolbarMoreButton { get; } = SeleniumHelpers.DataDecorator("test-id", "toolbar-more");

        public static string MarkAsReadButton { get; } = SeleniumHelpers.DataDecorator("test-id", "mark-as-read");

        public static string MarkAsUnreadButton { get; } = SeleniumHelpers.DataDecorator("test-id", "mark-as-unread");

        public static string EmailBodyTextContainer { get; } = SeleniumHelpers.DataDecorator("test-id", "message-view-body-content");
    }
}
