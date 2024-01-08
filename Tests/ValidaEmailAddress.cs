using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
public class ValidaEmailAddress
{
    private IWebDriver driver;
    private string baseUrl = "https://demo.automationtesting.in/Register.html";

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();       
        driver.Navigate().GoToUrl(baseUrl);
    }

    [Test]
    public void EmailAddressValidation()
    {
        
        IWebElement emailField = driver.FindElement(By.XPath("//*[@id=\"eid\"]/input"));
        emailField.SendKeys("teste@@teste@teste");

        //BUG proposital: Mensagem de erro não será encontrada (#BUG 3 do relatório de defeitos)     
        IWebElement errorMessage = driver.FindElement(By.XPath("//*[contains(text(),'Insira um e-mail válido')]"));    
        

        Assert.That(errorMessage.Displayed, Is.True);
        Assert.That(errorMessage.Text, Is.EqualTo("Por favor, insira um endereço de e-mail válido."));        
        emailField.Clear();
    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }
}
