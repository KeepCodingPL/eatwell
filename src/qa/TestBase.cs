using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace EatWell.QA
{
    public class TestBase
    {
        public static IWebDriver driver = new ChromeDriver();
        string url = ConfigurationManager.AppSettings["url"];
        
        [SetUp]
        public void startBrowser()
        {

            if (driver != null)
            {

                String browser = "Chrome";
                switch (browser)
                {
                    case "Chrome":
                        driver = new ChromeDriver();
                        break;
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                    case "Edge":
                        driver = new EdgeDriver();
                        break;
                }
            }

            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
