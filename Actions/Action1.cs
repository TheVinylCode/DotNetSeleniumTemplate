using OpenQA.Selenium;

namespace DotnetSeleniumTemplate.Actions
{
    using Pages;

    /// <summary>
    /// This class contains methods that use elements from 
    /// classes in Pages. The elements perform specific actions 
    /// in the browser.
    /// </summary>
    public static class Action1
    {
        
        public static void ActionToInteractWithElements1(IWebDriver driver)
        {
            Page1.Element1(driver).Clear();
            Page1.Element1(driver).SendKeys("");            
        }
        public static void ActionToInteractWithElement2(IWebDriver driver)
        {
            Page1.Element2(driver).Click();
        }    
        public static void ActionToInteractWithElement3(IWebDriver driver)
        {
            Page1.SelectElement1(driver).SelectByText("");
        }
    }
}
