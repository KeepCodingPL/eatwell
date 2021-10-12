using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.QA
{
    
    [TestClass]
    class TestExamples : TestBase
    {
        [Test]
        public void FirstNameTest()
        {
            
            IWebElement nameBox = driver.FindElement(By.XPath("//input[@name='firstname']"));
            nameBox.SendKeys("Hasbi");
            Thread.Sleep(2000);
            
        }

        [Test]
        public void LastNameTest()
        {
           
            IWebElement nameBox = driver.FindElement(By.XPath("//input[@name='lastname']"));
            nameBox.SendKeys("KAYNAK");
            Thread.Sleep(2000);
            
        }
    }
}
