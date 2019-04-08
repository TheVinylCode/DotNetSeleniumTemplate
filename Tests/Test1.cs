using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace SeleniumAutomationTemplate.Tests
{
    /// <summary>
    /// This is a test class, denoted by [TestFixure].
    /// It also contains a test method, denoted by [TestCase]
    /// </summary>
    [TestFixture] 
    public class TestClass1 : IDisposable
    {
        private IWebDriver _driver;

        [TestCase(/*you can add an argument here*/)]
        public void Test1()
        {
            //insert code here
        }

        public void Dispose()
        {
            _driver.Close();
        }
    }
}