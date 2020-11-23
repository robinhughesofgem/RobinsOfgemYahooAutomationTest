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
    public class YahooMailSideBarSteps : Steps
    {
        private readonly ScenarioContext _scenarioContext;

        public YahooMailSideBarSteps(ScenarioContext scenarioContext)
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

        [Then(@"The email should be in the correct place")]
        public void VerifyEmailInCorrectFolder()
        {
            AccessFolderForEmail();
            new YahooMailMessageFolderSteps(ScenarioContext).VerifyEmailPresentInFolder();
        }

        private void AccessFolderForEmail()
        {
            switch (Email.EmailFolder)
            {
                case EmailFolder.Trash:
                    Page.YahooMailSideBarPage.ClickTrashFolderButton();
                    break;
                case EmailFolder.Junk:
                    Page.YahooMailSideBarPage.ClickJunkFolderButton();
                    break;
                case EmailFolder.Inbox:
                    Page.YahooMailSideBarPage.ClickInboxButton();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
