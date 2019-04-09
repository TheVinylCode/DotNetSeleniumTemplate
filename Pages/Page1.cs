using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSeleniumTemplate.Pages
{
    using Data;
    using HelperClasses;

    /// <summary>
    /// This class find and returns elements on a web page by 
    /// using a key in the specified Dictionary.
    /// </summary>
    public class Page1
    {
        public static IWebElement Element1(IWebDriver driver)
        {
            return GetDataValues.FindElementById(driver,
                WebElementIdsXPaths.DictionaryName, "Key1");
        }

        public static IWebElement Element2(IWebDriver driver)
        {
            return GetDataValues.FindElementById(driver,
                WebElementIdsXPaths.DictionaryName, "Key2");
        }

        public static IWebElement Element3(IWebDriver driver)
        {
            return GetDataValues.FindElementByCss(driver,
                WebElementIdsXPaths.DictionaryName, "Key3");            
        }

        public static SelectElement SelectElement1(IWebDriver driver)
        {
            return GetDataValues.FindElementBySelector(driver,
                WebElementIdsXPaths.DictionaryName, "Key4");
        }
    }
}