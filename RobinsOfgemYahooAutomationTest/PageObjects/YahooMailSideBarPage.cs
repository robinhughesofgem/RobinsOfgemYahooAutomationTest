using OpenQA.Selenium;
using RobinsOfgemYahooAutomationTest.Helpers;

namespace RobinsOfgemYahooAutomationTest.PageObjects
{
    public class YahooMailSideBarPage
    {
        public void ClickJunkFolderButton()
        {
            var junkFolderButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailSideBarDecorators.JunkFolderButton));
            junkFolderButton.Click();
        }

        public void ClickTrashFolderButton()
        {
            var trashFolderButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailSideBarDecorators.TrashButton));
            trashFolderButton.Click();
        }

        internal void ClickInboxButton()
        {
            var inboxButton = SeleniumHelpers.WaitForElement(By.CssSelector(DataAttributeDecorators.YahooMailSideBarDecorators.InboxButton));
            inboxButton.Click();
        }
    }
}
