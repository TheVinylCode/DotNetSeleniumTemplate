using OpenQA.Selenium;

namespace DotnetSeleniumTemplate.Actions
{
    using Pages;

    /// <summary>
    /// This class contains methods that use elements from 
    /// classes in Pages. The elements perform specific actions 
    /// in the browser.
    /// </summary>
    public class Action1
    {
        private IWebDriver _driver;
        public void ActionToInteractWithElements1()
        {
            Page1.Element1(_driver).Clear();
            Page1.Element1(_driver).SendKeys("");            
        }
        public void ActionToInteractWithElement2()
        {
            Page1.Element2(_driver).Click();
        }    
        public void ActionToInteractWithElement3()
        {
            Page1.SelectElement1(_driver).SelectByText("");
        }
    }
}
