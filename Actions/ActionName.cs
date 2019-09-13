using OpenQA.Selenium;

namespace DotnetSeleniumTemplate.Actions
{
    using Pages;

    /// <summary>
    /// This class contains methods that use elements from 
    /// classes in Pages. The elements perform specific actions 
    /// in the browser.
    /// </summary>
    public static class ActionName
    {
        
        public static void ActionToInteractWithElement1(IWebDriver driver)
        {
            PageName.Element1(driver).Clear();
            PageName.Element1(driver).SendKeys("");            
        }
        public static void ActionToInteractWithElement2(IWebDriver driver)
        {
            PageName.Element2(driver).Click();
        }    
        public static void ActionToInteractWithElement3(IWebDriver driver)
        {
            PageName.SelectElement1(driver).SelectByText("");
        }
    }
}