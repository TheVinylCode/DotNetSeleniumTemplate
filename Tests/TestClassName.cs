using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DotnetAutomationTemplate.Tests
{
    /// <summary>
    /// This is a test class, denoted by [TestFixure].
    /// It also contains a test method, denoted by [TestCase]
    /// </summary>
    [TestFixture] 
    public class TestClassName : IDisposable
    {
        private IWebDriver _driver;

        [TestCase(/*you can add an argument here*/)]
        public void TestName()
        {
            //insert code here
        }

        //this ends the session
        public void Dispose()
        {
            _driver.Close();
        }
    }
}