using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ValidaLastName
{
    [TestFixture]
    public class ValidaLastName
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
        public void EnterTextInLastNameField()
        {

            string lastNameXPath = "//*[@id=\"basicBootstrapForm\"]/div[1]/div[2]/input";

            IWebElement lastNameField = driver.FindElement(By.XPath(lastNameXPath));

            lastNameField.Click();

            lastNameField.SendKeys("TestName2");

            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
