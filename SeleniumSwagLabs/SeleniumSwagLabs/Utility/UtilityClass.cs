using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace SeleniumSwagLabs
{
    public class UtilityClass : ConfigClass
    {
        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "CHROME":
                    driver = new ChromeDriver();
                    break;

                case "FIREFOX":
                    driver = new FirefoxDriver();
                    break;

                default: throw new ArgumentException("Error");
            }
        }

        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }
        public void browserMinimize()
        {
            driver.Manage().Window.Minimize();
        }
        public void browserBackNavigation()
        {
            driver.Navigate().Back();
        }
        public void browserRefresh()
        {
            driver.Navigate().Refresh();
        }
        public void browserForwardNavigation()
        {
            driver.Navigate().Forward();
        }

        public void pageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(page_Load_Timeout);
        }

        public void implicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicit_Wait);
        }

        public void threadSleep()
        {
            Thread.Sleep(3000);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public string ValidatePageTitle()
        {
            return driver.Title;
        }

        public void captureScreenShot()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(screenShotPath + "/screenshot.png", ScreenshotImageFormat.Png);


        }
    }
}
