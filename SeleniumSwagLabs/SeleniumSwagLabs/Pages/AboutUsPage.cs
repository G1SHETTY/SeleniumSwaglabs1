using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
	public class AboutUsPage : UtilityClass
	{
		private IWebDriver driver;
		// Varibles to store the elements of About page
		private By resources      = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[4]/div[1]/div");
		private By pricing        = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[3]/div/div");
		private By solutions      = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[1]/div[1]/div/a");
		private By platform       = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[2]/div[1]/div/a");
		private By company        = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[1]/div/a");
		private By security       = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[2]/div/div/div/ul/li/div/ul/li/div/ul/li[6]/div/ul/li/a/span");
		private By news           = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[2]/div/div/div/ul/li/div/ul/li/div/ul/li[7]/div/ul/li/a/span");
		

		public AboutUsPage(IWebDriver driver)
		{
			this.driver = driver;
		}
		// About page methods
		public void resourcesLink()
		{
			driver.FindElement(resources).Click();
		}
		public void pricingLink()
		{
			driver.FindElement(pricing).Click();
		}
		public void solutionsLink()
		{
			driver.FindElement(solutions).Click();
		}
		public void platformLink()
		{
			driver.FindElement(platform).Click();
		}
		public void companyLink()
		{
			driver.FindElement(company).Click();
		}

		public void securityLink()
		{
			driver.FindElement(security).Click();
		}

		public void newsLink()
		{
			driver.FindElement(news).Click();
		}

	}
}
