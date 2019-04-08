using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace DotnetSeleniumTemplate.HelperClasses
{
    /// <summary>
    /// This class contains methods that set up and return a driver 
    /// with a browser type. 
    /// 
    /// The following browsers are supported in the class: 
    ///     Google Chrome
    ///     Mozilla Firefox
    ///     Internet Explorer
    /// </summary>
    public class BrowserSetup
    {
        public static IWebDriver SetBrowserChrome(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); //--headless hides the browser
            
            var driver = new ChromeDriver(options);
            driver.Url = url;

            return driver;
        }

        public static IWebDriver SetBrowserFirefox(string url)
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--start-maximized"); //--headless hides the browser

            var driver = new FirefoxDriver(options);
            driver.Url = url;

            return driver;
        }

        public static IWebDriver SetBrowserInternetExplorer(string url)
        {
            var driver = new InternetExplorerDriver();
            driver.Url = url;

            return driver;
        }
    }
}