using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
    public class HomePage : UtilityClass
    {
        private IWebDriver driver;
        // variables to store the Home page elements
        private By button        = By.Id("react-burger-menu-btn");
        private By closeMenu     = By.XPath("//*[@id='react-burger-cross-btn']");
        private By allItems      = By.XPath("//*[@id='inventory_sidebar_link']");
        private By aboutUs       = By.XPath("//a[@id='about_sidebar_link']");
        private By logOut        = By.XPath("//*[@id='logout_sidebar_link']");
        private By resetAppstate = By.XPath("//*[@id='reset_sidebar_link']");
        private By twiiter       = By.XPath("//*[@id='page_wrapper']/footer/ul/li[1]/a");
        private By facebook      = By.XPath("//*[@id='page_wrapper']/footer/ul/li[2]/a");
        private By linkedIn      = By.XPath("//*[@id='page_wrapper']/footer/ul/li[3]/a");
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Home page methods
        public void menuButton()
		{
            driver.FindElement(button).Click();
        }
        public void closeMenuButton()
        {
            driver.FindElement(closeMenu).Click();
        }
        public void allItemsLink()
        {
            driver.FindElement(allItems).Click();
        }
        public void twiiterLink()
        {
            driver.FindElement(twiiter).Click();
        }
        public void facebookLink()
        {
            driver.FindElement(facebook).Click();
        }
        public void linkedInLink()
        {
            driver.FindElement(linkedIn).Click();
        }
        public void aboutUsPage()
        {
            driver.FindElement(aboutUs).Click();
        }
        public void resetAppStateLink()
        {
            driver.FindElement(resetAppstate).Click();
        }
        public void logOutLink()
        {
            driver.FindElement(logOut).Click();
        }
    }
}
