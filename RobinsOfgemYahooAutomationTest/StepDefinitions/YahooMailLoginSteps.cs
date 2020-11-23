using RobinsOfgemYahooAutomationTest.Core;
using TechTalk.SpecFlow;

namespace RobinsOfgemYahooAutomationTest.StepDefinitions
{
    [Binding]
    public class YahooMailLoginSteps : Steps
    {
        [Given(@"I have logged into Yahoo with the email '(.*)' and Password '(.*)'")]
        public void LoginToGmailInbox(string email, string password)
        {
            AppDriver.LoadURL("https://Uk.Mail.Yahoo.Com");
            Page.YahooMailLoginPage.EnterLoginDetails(email, password);
        }
    }
}
