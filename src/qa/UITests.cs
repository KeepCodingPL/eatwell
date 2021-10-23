using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace EatWell.QA
{

    [TestClass]
    public class UITests : TestBase
    {
        [Test]
        public void AddNewProductClick()
        {
            IWebElement addNewProductClick = driver.FindElement(By.XPath("//a[text()='Add New Product']"));
            addNewProductClick.Click(); 
            Thread.Sleep(2000);
        }

        [Test]
        public void AllProductsClick()
        {
            IWebElement allProductsClick = driver.FindElement(By.XPath("//a[text()='All Products']"));
            allProductsClick.Click();
           // Assert.AreEqual();
            Thread.Sleep(2000);
        }
        [Test]
        public void EditButton()
        {
            IWebElement editButtonClick = driver.FindElement(By.XPath("//button[text()='Edit']"));
            editButtonClick.Click();
            Thread.Sleep(2000);
        }
        [Test]
        public void DeleteButton()
        {
            IWebElement deleteButtonClick = driver.FindElement(By.XPath("//button[text()='Delete']"));
            deleteButtonClick.Click();
            Thread.Sleep(2000);
        }


    }
}
