﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void AddNewProductClick()
        
        {
            IWebElement addNewProductClick = driver.FindElement(By.XPath("//a[text()='Add New Product']"));
            addNewProductClick.Click();
            string newProductUrl = "http://localhost:3000/new-product"; 
            string currentUrl = driver.Url;
            Assert.AreEqual(newProductUrl, currentUrl);
            Thread.Sleep(2000);
        }

        [Test]
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


    }
}
