using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSeleniumTemplate.Pages
{
    using Data;
    using HelperClasses;

    /// <summary>
    /// This class is used for the GoogleSearch test. The elements are found on the web page by 
    /// using a key in the specified Dictionary.
    /// </summary>
    public class GoogleHomepageSample
    {
        public static IWebElement GoogleSearchBarElement(IWebDriver driver)
        {
            return GetDataValues.FindElementByXPath(driver,
                WebElementIdsXPaths.GoogleElements, "GoogleSearchBar");
        }                
    }
}