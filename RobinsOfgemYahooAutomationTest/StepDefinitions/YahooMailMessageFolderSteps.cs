using NUnit.Framework;
using OpenQA.Selenium;
using RobinsOfgemYahooAutomationTest.Constants;
using RobinsOfgemYahooAutomationTest.Core;
using RobinsOfgemYahooAutomationTest.Models;
using RobinsOfgemYahooAutomationTest.SpecFlowContext;
using TechTalk.SpecFlow;

namespace RobinsOfgemYahooAutomationTest.StepDefinitions
{
    [Binding]
    public class YahooMailMessageFolderSteps : Steps
    {
        private readonly ScenarioContext _scenarioContext;

        public YahooMailMessageFolderSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        private EmailModel Email
        {
            get
            {
                return Context.Get<EmailModel>(_scenarioContext, ScenarioContextConstants.Email);
            }
            set
            {
                Context.Set(_scenarioContext, ScenarioContextConstants.Email, value);
            }
        }

        [Given(@"I enter the most recent email with the subject '(.*)' to Check the body text")]
        public void GivenIEnterTheMostRecentEmailWithTheSubjectToCheckTheBodyText(string subject)
        {
            Page.YahooMailMessageFolderPage.SortByNewestFirst();
            EnterMostRecentEmailWithGivenSubject(subject);
        }

        public void EnterMostRecentEmailWithGivenSubject(string subject)
        {
            var emails = Page.YahooMailMessageFolderPage.GetEmailsWithSubject(subject);
            emails[0].Click();
        }

        public void VerifyEmailPresentInFolder()
        {
            bool found = false;
            while (!found)
            {
                var emails = Page.YahooMailMessageFolderPage.GetEmailsWithSubject(Email.Subject);

                for (int i = 0; i < emails.Count; i++)
                {
                    IWebElement email = emails[i];
                    email.Click();

                    if (Email.From == Page.YahooMailMessagePage.GetEmailFromAddress()
                        && Email.BodyText == Page.YahooMailMessagePage.GetEmailBodyText()
                        && Email.DateSent == Page.YahooMailMessagePage.GetEmailDateSent())
                    {
                        found = true;
                        break;
                    }

                    Page.YahooMailMessagePage.ClickBackButton();
                    emails = Page.YahooMailMessageFolderPage.GetEmailsWithSubject(Email.Subject);
                }
            }

            Assert.IsTrue(found);
        }
    }
}
