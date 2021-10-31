using EatWell.QA.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace EatWell.QA
{

    [TestClass]
    public class UITests : TestBase
    {
        AllProductsPage allProductsPage = new AllProductsPage();

        [Test]
        [TestCategory("Products")]
        public void AddNewProductClick()
        {
            //Click the Add New Product Button
            allProductsPage.ClickAddNewProduct();

            //Assert
            string newProductUrl = "https://ashy-sky-0c1ce5203.azurestaticapps.net/new-product"; //move to the  AppConfig
            string currentUrl = driver.Url;

            Assert.IsTrue(allProductsPage.URLComparison(currentUrl, newProductUrl));
            Thread.Sleep(2000);
        }

        [Test]
        [TestCategory("Products")]
        public void AllProductsClick()
        {
            IWebElement addNewProductClick = driver.FindElement(By.XPath("//a[text()='Add New Product']"));
            addNewProductClick.Click();
            Thread.Sleep(2000);
            IWebElement allProductsClick = driver.FindElement(By.XPath("//a[text()='All Products']"));
            allProductsClick.Click();
            string currentUrl = driver.Url;
            Assert.AreEqual(ConfigurationManager.AppSettings["url"], currentUrl);
            Thread.Sleep(2000);
        }

        [Test]
        [TestCategory("Buttons")]
        public void EditButton1()
        {
            IWebElement editButtonClick = driver.FindElement(By.XPath("(//button[text()='Edit'])[1]"));
            editButtonClick.Click();
            Assert.IsTrue(editButtonClick.Displayed);
            Thread.Sleep(2000);
        }

        [Test]
        public void DeleteButton1()
        {
            IWebElement deleteButtonClick = driver.FindElement(By.XPath("(//button[text()='Delete'])[1]"));
            deleteButtonClick.Click();
            Assert.IsTrue(deleteButtonClick.Displayed);
            Thread.Sleep(2000);
        }

        [Test]
        public void FailTest()
        {
            //This test is created for AzureDevOps related configurations *DO NOT DELETE THIS*
            Assert.IsTrue(false);
        }

    }
}
