using RobinsOfgemYahooAutomationTest.Core;
using RobinsOfgemYahooAutomationTest.SpecFlowContext;
using TechTalk.SpecFlow;
using RobinsOfgemYahooAutomationTest.Constants;
using static RobinsOfgemYahooAutomationTest.Enums.GlobalEnums;
using System;
using RobinsOfgemYahooAutomationTest.Models;

namespace RobinsOfgemYahooAutomationTest.StepDefinitions
{
    [Binding]
    public class YahooMailMessageSteps : Steps
    {
        private readonly ScenarioContext _scenarioContext;

        public YahooMailMessageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        private EmailAction EmailAction
        {
            get
            {
                return Context.Get<EmailAction>(_scenarioContext, ScenarioContextConstants.EmailAction);
            }
            set
            {
                Context.Set(_scenarioContext, ScenarioContextConstants.EmailAction, value);
            }
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

        [When(@"The email body contains '(.*)' I delete the email, Otherwise I move it into the Junk folder")]
        public void SetEmailSortAction(string matchValue)
        {
            Email = new EmailModel();
            Email.BodyText = Page.YahooMailMessagePage.GetEmailBodyText();
            Email.DateSent = Page.YahooMailMessagePage.GetEmailDateSent();
            Email.From = Page.YahooMailMessagePage.GetEmailFromAddress();
            Email.Subject = Page.YahooMailMessagePage.GetEmailSubject();
            Email.EmailFolder = EmailFolder.Inbox;

            EmailAction = Email.BodyText == matchValue ? EmailAction.Delete : EmailAction.MoveToJunk;
            ManageEmail(EmailAction);
        }

        public void ManageEmail(EmailAction emailAction)
        {
            switch (emailAction)
            {
                case EmailAction.MarkAsRead:
                    Page.YahooMailMessagePage.MarkEmailAsRead();
                    Email.EmailRead = true;
                    break;
                case EmailAction.MarkAsUnread:
                    Page.YahooMailMessagePage.MarkEmailAsUnread();
                    Email.EmailRead = false;
                    break;
                case EmailAction.Delete:
                    Page.YahooMailMessagePage.DeleteEmail();
                    Email.EmailFolder = EmailFolder.Trash;
                    break;
                case EmailAction.MoveToJunk:
                    Page.YahooMailMessagePage.MoveEmailToJunk();
                    Email.EmailFolder = EmailFolder.Junk;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
