using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace draft.Drivers

{
    public class CustomDriver
    {
        public static IWebDriver GetChromeDriver()
        {
            return GetDriver(Browsers.Chrome);
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }

        private static IWebDriver GetDriver(Browsers browserName)
        {
            IWebDriver driver = null;

            switch (browserName)
            {
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }
    }
}

