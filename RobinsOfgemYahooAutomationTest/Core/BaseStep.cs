using RobinsOfgemYahooAutomationTest.Enums;
using System.Configuration;
using TechTalk.SpecFlow;

namespace RobinsOfgemYahooAutomationTest.Core
{
    [Binding]
    public class BaseStep
    {
        [BeforeTestRun]
        public static void DoSetup()
        {
            AppDriver.InitBrowser(ConfigurationManager.AppSettings["browser"].ToEnum<GlobalEnums.BrowserType>());
        }

        [AfterTestRun]
        public static void CloseDriver()
        {
            AppDriver.CloseDriver();
        }
    }
}
