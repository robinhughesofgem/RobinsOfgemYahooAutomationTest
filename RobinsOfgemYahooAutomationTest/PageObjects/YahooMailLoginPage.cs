using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RobinsOfgemYahooAutomationTest.Helpers;

namespace RobinsOfgemYahooAutomationTest.PageObjects
{
    public class YahooMailLoginPage
    {
        [FindsBy(How = How.Id, Using = "login-username")]
        private IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "login-passwd")]
        private IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "login-signin")]
        private IWebElement EmailNextButton { get; set; }

        [FindsBy(How = How.Id, Using = "login-signin")]
        private IWebElement PasswordNextButton { get; set; }

        public void EnterLoginDetails(string email, string password)
        {
            EmailField.SendKeys(email);
            EmailNextButton.Click();
            SeleniumHelpers.WaitForElementToBeVisible(By.Id("login-passwd"));
            PasswordField.SendKeys(password);
            PasswordNextButton.Click();
        }
    }
}
