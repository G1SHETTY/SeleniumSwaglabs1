using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    public class ApplicationHooks : UtilityClass
{
    public HomePage hp;
    public AboutUsPage ap;
    public LoginPage lp;

    [BeforeScenario]
    public void BeforSenario()
    {
        LaunchBrowser("CHROME");
        LaunchApp(url);
        implicitWait();

            lp = new LoginPage(driver);
            hp = new HomePage(driver);
            ap = new AboutUsPage(driver);
    }

        [AfterScenario]
        public void AfterScenario()
        {
            implicitWait();
            CloseBrowser();
        }
    }
}
