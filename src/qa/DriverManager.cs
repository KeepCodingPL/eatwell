using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace EatWell.QA
{
    public class DriverManager
    {
        public static IWebDriver driver = new ChromeDriver();
        public string url = ConfigurationManager.AppSettings["url"];

        /*
         if (driver != null)
            {
                string browser = "Chrome";
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
         */
    }
}
