using APQATest.Driver;
using APQATest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace APQATest.Tests
{
    public class TestBase
    {
        public IWebDriver driver;
        public LoginPage basePage;
        public HomePage homePage;

        [SetUp]
        public void Setup()
        {
            driver = new DriverManager().CreateDriver("chrome");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            basePage = new LoginPage(driver);
            homePage = new HomePage(driver);

        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close();
            //driver.Quit();
        }
    }
}
