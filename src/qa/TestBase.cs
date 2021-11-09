using NUnit.Framework;
using System.Threading;

namespace EatWell.QA
{
    public class TestBase : DriverManager
    {
        [SetUp]
        public void startBrowser()
        {
            driver.Navigate().GoToUrl(Url);

            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void QuitDriver()
        {
            Thread.Sleep(2000);

            if (driver != null)
                driver.Quit();
        }
    }

   
}
