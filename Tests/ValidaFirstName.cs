using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ValidaFirstName
{
    [TestFixture]
    public class ValidaFirstName
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }

        [Test]
        public void EnterTextInFirstNameField()
        {
            
            string firstNameXPath = "//*[@id=\'basicBootstrapForm\']/div[1]/div[1]/input";

            IWebElement firstNameField = driver.FindElement(By.XPath(firstNameXPath));

            firstNameField.Click();
           
            firstNameField.SendKeys("TestName1");

            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
