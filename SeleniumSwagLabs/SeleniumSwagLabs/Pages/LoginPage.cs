using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
    public class LoginPage : UtilityClass
    {
        private IWebDriver driver;
        // variables to store the login page elements
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By login    = By.Id("login-button");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Login page methods
        public void usernameField(string uname)
        {
            driver.FindElement(username).SendKeys(uname);
        }
        public void passwordField(string pwrd)
        {
            driver.FindElement(password).SendKeys(pwrd);
        }
        public void loginButton()
        {
            driver.FindElement(login).Click();
        }
    }
}
