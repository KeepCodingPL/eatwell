using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatWell.QA
{
    class TestBase
    {
        public IWebDriver driver = new ChromeDriver();

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

            driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");

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
