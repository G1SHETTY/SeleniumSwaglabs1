using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class HomeAndAboutPageStepDefinitions : ApplicationHooks
    {
       // To Launch the chrome browser and the swaglabs application
        [Given(@"Chrome is open and SwagLabs app is opened")]
        public void GivenChromeIsOpenAndSwagLabsAppIsOpened()
        {
         
            browserMaximize();
            threadSleep();
        }

        // To Login to the Swaglabs application
        [When(@"user enters username ""([^""]*)"" and password ""([^""]*)"" and click on Login")]
        public void WhenUserEntersUsernameAndPasswordAndClickOnLogin(string uname, string pwrd)
        {
            lp.usernameField(uname);
            lp.passwordField(pwrd);
            lp.loginButton();
            threadSleep();
        }

        // To open a menu bar
        [When(@"User clicks on Menu button")]
        public void WhenUserClicksOnMenuButton()
        {
            hp.menuButton();
            threadSleep();
        }

        [Then(@"it should display all the options in Menu")]
        public void ThenItShouldDisplayAllTheOptionsInMenu()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // To open allitems option
        [When(@"User clicks on All Items link")]
        public void WhenUserClicksOnAllItemsLink()
        {
            hp.allItemsLink();
            threadSleep();
        }

        [Then(@"it should display All Items")]
        public void ThenItShouldDisplayAllItems()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // Logout from the application
        [When(@"User clicks on Logout link")]
        public void WhenUserClicksOnLogoutLink()
        {
            hp.logOutLink();
            implicitWait();
        }

        [Then(@"it should be Logout from the application")]
        public void ThenItShouldBeLogoutFromTheApplication()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // Reset the application states
        [When(@"User clicks on Reset App State link")]
        public void WhenUserClicksOnResetAppStateLink()
        {

            hp.resetAppStateLink();
            implicitWait();
        }

        [Then(@"it should reset the app state")]
        public void ThenItShouldResetTheAppState()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // To open a swaglabs page by using twitter link
        [When(@"user clicks on Twitter link")]
        public void WhenUserClicksOnTwitterLink()
        {
            hp.linkedInLink();
            implicitWait();
        }

        [Then(@"it should display the Twitter page")]
        public void ThenItShouldDisplayTheTwitterPage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // To open a swaglabs page by using facebook link
        [When(@"user clicks on Facebook link")]
        public void WhenUserClicksOnFacebookLink()
        {
            hp.facebookLink();
            implicitWait();
        }

        [Then(@"it should display the Facebook page")]
        public void ThenItShouldDisplayTheFacebookPage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // to open a swaglabs page by using linkedin link
        [When(@"user clicks on LinkedIn link")]
        public void WhenUserClicksOnLinkedInLink()
        {
            hp.linkedInLink();
            implicitWait();
        }

        [Then(@"it should display the LinkedIn page")]
        public void ThenItShouldDisplayTheLinkedInPage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // To close the menu bar
        [When(@"clicks on Close menu button")]
        public void WhenClicksOnCloseMenuButton()
        {
            hp.closeMenuButton();
            implicitWait();
        }

        [Then(@"it should close the Menu")]
        public void ThenItShouldCloseTheMenu()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();
        }

        // To open a about link
        [When(@"user clicks on About Link")]
        public void WhenUserClicksOnAboutLink()
        {
            hp.aboutUsPage();
            implicitWait();
        }

        [Then(@"it should display the AboutPage")]
        public void ThenItShouldDisplayTheAboutPage()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        [Then(@"It Should Display All The Option In Alligned Manner In AboutPage")]
        public void ThenItShouldDisplayAllTheOptionInAllignedMannerInAboutPage()
        {

            browserMinimize();
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }


        // To access the company link
        [When(@"user Clicks on company link")]
        public void WhenUserClicksOnCompanyLink()
        {
            ap.companyLink();
            implicitWait();

        }

        [Then(@"it should display all the options in company link")]
        public void ThenItShouldDisplayAllTheOptionsInCompanyLink()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the news link 
        [When(@"user Clicks on news link")]
        public void WhenUserClicksOnNewsLink()
        {
            ap.newsLink();
            implicitWait();
        }

        [Then(@"it should be able to access")]
        public void ThenItShouldBeAbleToAccess()
        {
            string expectedResult = "News | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the security link
        [When(@"user clicks on security")]
        public void WhenUserClicksOnSecurity()
        {
            ap.securityLink();
            implicitWait();
        }

        [Then(@"it should be display security page")]
        public void ThenItShouldBeDisplaySecurityPage()
        {
            string expectedResult = "Security | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the Resource link
        [When(@"user Clicks on Resource link")]
        public void WhenUserClicksOnResourceLink()
        {
            ap.resourcesLink();
            implicitWait();
        }

        [Then(@"it should be display all the options of resource")]
        public void ThenItShouldBeDisplayAllTheOptionsOfResource()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the platform link
        [When(@"user Clicks on platform link")]
        public void WhenUserClicksOnPlatformLink()
        {
            ap.platformLink();
            implicitWait();
        }

        [Then(@"it should be  able to access platform")]
        public void ThenItShouldBeAbleToAccessPlatform()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the solutions link
        [When(@"user Clicks on solutions link")]
        public void WhenUserClicksOnSolutionsLink()
        {
            ap.solutionsLink();
            implicitWait();
        }

        [Then(@"it should be  able to access solution")]
        public void ThenItShouldBeAbleToAccessSolution()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To access the pricing link
        [When(@"user Clicks on pricing link")]
        public void WhenUserClicksOnPricingLink()
        {

            ap.pricingLink();
            implicitWait();
        }

        [Then(@"it should be  able to access pricing")]
        public void ThenItShouldBeAbleToAccessPricing()
        {
            string expectedResult = "Pricing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To check the working of  back navigation arrow
        [When(@"user Clicks on back navigation arrow")]
        public void WhenUserClicksOnBackNavigationArrow()
        {
            browserBackNavigation();
            implicitWait();
        }

        [Then(@"it should display the home page")]
        public void ThenItShouldDisplayTheHomePage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }

        // To check the working of refresh  and forward navigation arrow
        [When(@"user clicks on refresh button and forward arrow")]
        public void WhenUserClicksOnRefreshButtonAndForwardArrow()
        {
            browserRefresh();
            browserForwardNavigation();
            implicitWait();
        }
        [Then(@"it should display the About cross testing page")]
        public void ThenItShouldDisplayTheAboutCrossTestingPage()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            captureScreenShot();
            Console.Write(actualResult);
            implicitWait();

        }
    }
}


