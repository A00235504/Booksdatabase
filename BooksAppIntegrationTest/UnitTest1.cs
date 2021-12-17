using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void StartUp()
        {
            //DriverManager manager = new DriverManager();
            //manager.SetUpDriver(new ChromeConfig());

            //same code as above but in short form

            var options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Normal;

            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();

        }


        [TestMethod]
        public void TestingTheBooksAppWebPageTitle()
        {
            
            _webDriver.Navigate().GoToUrl("https://localhost:5001/");

            Assert.AreEqual("Home Page - BooksAppWebFinalSubmission", _webDriver.Title);
            Assert.IsTrue(_webDriver.Title.Contains("Home Page - BooksAppWebFinalSubmission"));
        }

        [TestMethod]
        public void TestingTheBooksAppPageHasAnyContentSearchBookNamesHere()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/");
            
            Assert.IsTrue(_webDriver.PageSource.Contains("Search book names here"));
        }

        [TestCleanup]
        public void ShutDown()
        {
            _webDriver.Quit();
        }
    }
}
