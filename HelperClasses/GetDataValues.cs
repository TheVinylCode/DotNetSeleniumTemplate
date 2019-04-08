using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace DotnetSeleniumTemplate.HelperClasses
{
    /// <summary>
    /// This class contains methods to get data from a Dictionary and 
    /// string that are passed in. If the data is found, it is returned.
    /// if it isn't, null is returned. 
    /// </summary>
    public static class GetDataValues
    {
        public static IWebElement FindElementById(IWebDriver driver,
            Dictionary<string, string> dictionary, string key)
        {
            if (driver == null)
                throw new ArgumentNullException(nameof(driver));
                    
            if (!dictionary.ContainsKey(key))
                return null;

            return driver.FindElement(By.Id(dictionary[key]));
        }
        
        public static IWebElement FindElementByXPath(IWebDriver driver,
            Dictionary<string, string> dictionary, string key)
        {
            if (driver == null)
                throw new ArgumentNullException(nameof(driver));

            if (!dictionary.ContainsKey(key))
                return null;

            return driver.FindElement(By.XPath(dictionary[key]));
        }

        public static SelectElement FindElementBySelector(IWebDriver driver,
            Dictionary<string, string> dictionary, string key)
        {
            if (driver == null)
                throw new ArgumentNullException(nameof(driver));

            if (!dictionary.ContainsKey(key))
                return null;

            return new SelectElement(driver.FindElement(By.XPath(dictionary[key])));
        }

        public static IWebElement FindElementByCss(IWebDriver driver,
            Dictionary<string, string> dictionary, string key)
        {
            if (driver == null)
                throw new ArgumentNullException(nameof(driver));

            if (!dictionary.ContainsKey(key))
                return null;

            return driver.FindElement(By.CssSelector(dictionary[key]));
        }

        public static string GetNonWebElementData(Dictionary<string, string> dictionary,
            string key)
        {
            if (!dictionary.ContainsKey(key))
                return null;

            return dictionary[key];
        }
    }
}