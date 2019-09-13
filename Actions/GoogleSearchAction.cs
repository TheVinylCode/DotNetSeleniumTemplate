using OpenQA.Selenium;

namespace DotnetSeleniumTemplate.Actions
{
    using Pages;

    /// <summary>
    /// This class contains the method that will enter search 
    /// terms into the Google search bar and submit the terms. 
    /// </summary>
    public class GoogleSearchAction
    { 
        public static void EnterGoogleSearchTerms(IWebDriver driver, string searchTerms)
        {
            GoogleHomePage.GoogleSearchElements(driver, "GoogleSearchBar").SendKeys(searchTerms);
        }

        public static void SubmitGoogleSearchTerms(IWebDriver driver)
        {
            IWebElement element = GoogleHomePage.GoogleSearchElements(driver, "GoogleSearchButton");
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript("arguments[0].click();", element); 
        }
    }
}
