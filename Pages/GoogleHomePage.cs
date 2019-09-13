using OpenQA.Selenium;

namespace DotnetSeleniumTemplate.Pages
{
    using Data;
    using HelperClasses;

    /// <summary>
    /// This class is used for the GoogleSearch test. The elements are found on the web page by 
    /// using a key in the specified Dictionary.
    /// </summary>
    public class GoogleHomePage
    {
        public static IWebElement GoogleSearchElements(IWebDriver driver, string key)
        {
            return GetDataValues.FindElementByXPath(driver,
                WebElementIdsXPaths.GoogleElements, key);
        }                
    }}