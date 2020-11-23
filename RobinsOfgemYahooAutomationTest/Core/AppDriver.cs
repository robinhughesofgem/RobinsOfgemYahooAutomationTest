using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using static RobinsOfgemYahooAutomationTest.Enums.GlobalEnums;

namespace RobinsOfgemYahooAutomationTest.Core
{
    public class AppDriver
    {
        private static IWebDriver driver = null;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("The browser instance was not initialised .you should first call the method InitBrowser");
                }

                return driver;
            }

            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(BrowserType browserType)
        {
            int commandTimeOut = 10;

            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, true, true);
                    chromeOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true, true);

                    driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), chromeOptions, TimeSpan.FromMinutes(commandTimeOut));

                    break;

                case BrowserType.Edge:
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, true);
                    edgeOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true);

                    driver = new EdgeDriver(EdgeDriverService.CreateDefaultService(), edgeOptions, TimeSpan.FromMinutes(commandTimeOut));

                    break;

                case BrowserType.Firefox:
                    FirefoxOptions ffOptions = new FirefoxOptions();
                    ffOptions.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, true, true);
                    ffOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true, true);

                    driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(), ffOptions, TimeSpan.FromMinutes(commandTimeOut));

                    break;

                case BrowserType.InternetExplorer:
                    InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                    ieOptions.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, false, false);
                    ieOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true, true);
                    ieOptions.IgnoreZoomLevel = true;

                    driver = new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(), ieOptions, TimeSpan.FromMinutes(commandTimeOut));

                    break;

                default:
                    throw new NotImplementedException("BrowserType not implemented");
            }

            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(60));
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        public static void LoadURL(string url) => driver.Url = url;

        public static string GetCurrentURL() => driver.Url;
    }
}
