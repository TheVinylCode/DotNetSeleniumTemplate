using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DotnetSeleniumTemplate.Tests
{
    using Actions;
    using HelperClasses;
    using Data;
    /// <summary>
    /// This is a test class, denoted by [TestFixure].
    /// It also contains a test method, denoted by [TestCase]
    /// </summary>
    [TestFixture]
    public class GoogleSearchTest : IDisposable
    {
        private readonly IWebDriver _driver = new ChromeDriver();
       
        [TestCase("https://www.google.com")]
        public void GoogleSearch(String url)
        {
            _driver.Url = "https://www.google.com";

            GoogleSearchAction.EnterGoogleSearchTerms(_driver, "why use selenium for automation?");
            GoogleSearchAction.SubmitGoogleSearchTerms(_driver);

            Assert.IsTrue(GetDataValues.FindElementByXPath(_driver, WebElementIdsXPaths.GoogleElements, "GoogleLogo").Displayed);
        }

        public void Dispose()
        {
            _driver.Close();
        }
    }
}