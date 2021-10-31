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
    public class TestBase : DriverManager
    {
        [SetUp]
        public void startBrowser()
        {
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
