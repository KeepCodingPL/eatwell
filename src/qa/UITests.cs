using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace EatWell.QA
{

    [TestClass]
    public class UITests : TestBase
    {
        [Test]
        public void AddNewProductButton()
        {
            IWebElement addNewProductButton = driver.FindElement(By.XPath("//a[text()='Add New Product']"));
            addNewProductButton.Click(); 
            Thread.Sleep(2000);
        }
    }
}
