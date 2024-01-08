using OpenQA.Selenium;

namespace YourProject.Pages
{
    public class RegisterPage
    {
        public IWebDriver Driver;

        public RegisterPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}

