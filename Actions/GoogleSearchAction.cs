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
            GoogleHomepageSample.GoogleSearchBarElement(driver).SendKeys(searchTerms);
        }

        public static void SubmitGoogleSearchterms(IWebDriver driver)
        {
            GoogleHomepageSample.GoogleSearchBarElement(driver).SendKeys(Keys.Return);
        }
    }
}
