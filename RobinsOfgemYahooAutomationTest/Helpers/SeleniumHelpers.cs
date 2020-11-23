using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RobinsOfgemYahooAutomationTest.Core;
using System;
using System.Collections.ObjectModel;

namespace RobinsOfgemYahooAutomationTest.Helpers
{
    public static class SeleniumHelpers
    {
        public static string DataDecorator(string attributeName, string selector)
        {
            return $"[data-{attributeName}='{selector}']";
        }

        public static void WaitForElementToBeVisible(By by, int waitTime = 10)
        {
            WebDriverWait wait = new WebDriverWait(AppDriver.Driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public static IWebElement WaitForElement(By by, int waitTime = 10)
        {
            WebDriverWait wait = new WebDriverWait(AppDriver.Driver, TimeSpan.FromSeconds(waitTime));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(x => x.FindElement(by));
        }

        public static ReadOnlyCollection<IWebElement> WaitForElements(By by, int waitTime = 10)
        {
            WebDriverWait wait = new WebDriverWait(AppDriver.Driver, TimeSpan.FromSeconds(waitTime));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(x => x.FindElements(by));
        }
    }
}
