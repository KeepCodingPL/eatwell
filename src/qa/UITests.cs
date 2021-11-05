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
        [Test]
        [TestCategory("Products")]
        public void AddNewProductClickTest()
        {
            var allProductsPage = new AllProductsPage();

            allProductsPage.ClickAddNewProduct();

            var newProductUrl = "https://ashy-sky-0c1ce5203.azurestaticapps.net/new-product";
            var currentUrl = driver.Url;

            Assert.IsTrue(allProductsPage.CompareURL(currentUrl, newProductUrl));
        }

        [Test]
        public void FailTest()
        {
            //This test is created for AzureDevOps related configurations *DO NOT DELETE THIS*
            Assert.IsTrue(false);
        }

    }
}
