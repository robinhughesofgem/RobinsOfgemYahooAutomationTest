using OpenQA.Selenium;
using RobinsOfgemYahooAutomationTest.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace RobinsOfgemYahooAutomationTest.PageObjects
{
    public class YahooMailMessageFolderPage
    {
        public YahooMailMessageFolderPage SortByNewestFirst()
        {
            var sortButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailFolderDecorators.SortButton));
            sortButton.Click();
            var sortByDateDesc = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailFolderDecorators.SortByDateDesc));
            sortByDateDesc.Click();
            return this;
        }

        public void EnterEmailMessage(IWebElement email)
        {
            email.Click();
        }

        public List<IWebElement> GetEmailsWithSubject(string subject)
        {
            var emails = SeleniumHelpers.WaitForElements(By.CssSelector(DataAttributeDecorators.YahooMailFolderDecorators.EmailListItem));
            return emails.Where(x => x.FindElement(By.CssSelector(DataAttributeDecorators.YahooMailFolderDecorators.EmailSubject)).Text == subject).ToList();
        }
    }
}
