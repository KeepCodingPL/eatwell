using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace EatWell.QA
{
    public class DriverManager
    {
        public static IWebDriver driver = new ChromeDriver();
        public string Url = ConfigurationManager.AppSettings["url"];
    }
}
