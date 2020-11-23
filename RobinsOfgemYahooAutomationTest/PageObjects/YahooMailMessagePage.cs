using OpenQA.Selenium;
using RobinsOfgemYahooAutomationTest.Helpers;
using System;

namespace RobinsOfgemYahooAutomationTest.PageObjects
{
    public class YahooMailMessagePage
    {
        public void DeleteEmail()
        {
            var deleteButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.ToolbarDeleteButton));
            deleteButton.Click();
        }

        public void MoveEmailToJunk()
        {
            var moveButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.ToolbarMoveButton));
            moveButton.Click();
            var junkButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.JunkFolderButton));
            junkButton.Click();
        }

        public void MarkEmailAsRead()
        {
            var moreButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.ToolbarMoreButton));
            moreButton.Click();
            var emailReadButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.MarkAsReadButton));
            emailReadButton.Click();
        }

        internal void MarkEmailAsUnread()
        {
            var moreButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.ToolbarMoreButton));
            moreButton.Click();
            var emailUnreadButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.MarkAsUnreadButton));
            emailUnreadButton.Click();
        }

        public string GetEmailBodyText()
        {
            var bodyTextContainer = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.EmailBodyTextContainer));
            return bodyTextContainer.Text;
        }

        public string GetEmailDateSent()
        {
            var messageDateContainer = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.MessageDate));
            return messageDateContainer.Text;
        }

        internal void ClickBackButton()
        {
            var backButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.BackButton));
            backButton.Click();
        }

        public string GetEmailFromAddress()
        {
            var messageFromAddress = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.MessageFrom));
            return messageFromAddress.Text;
        }

        public string GetEmailSubject()
        {
            var messageSubjectTextContainer = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailMessageDecorators.MessageSubjectText));
            return messageSubjectTextContainer.Text;
        }
    }
}
