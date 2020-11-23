using OpenQA.Selenium.Support.PageObjects;
using RobinsOfgemYahooAutomationTest.PageObjects;

namespace RobinsOfgemYahooAutomationTest.Core
{
    public static class Page
    {
        public static YahooMailLoginPage YahooMailLoginPage => GetPage<YahooMailLoginPage>();

        public static YahooMailMessageFolderPage YahooMailMessageFolderPage => GetPage<YahooMailMessageFolderPage>();

        public static YahooMailMessagePage YahooMailMessagePage => GetPage<YahooMailMessagePage>();

        public static YahooMailSideBarPage YahooMailSideBarPage => GetPage<YahooMailSideBarPage>();

        private static T GetPage<T>()
            where T : new()
        {
            var page = new T();
            PageFactory.InitElements(AppDriver.Driver, page);
            return page;
        }
    }
}
