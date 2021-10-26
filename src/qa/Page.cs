using OpenQA.Selenium;

namespace EatWell.QA
{
    public class Page : IPage
    {
        #region Paths
        string addNewProductClickBtnPath = "//a[text()='Add New Product']";

        //string a = "";
        #endregion

        #region Methods
        public void ClickAddNewProduct(IWebDriver driver)
        {
            IWebElement addNewProductClick = driver.FindElement(By.XPath(addNewProductClickBtnPath));
            addNewProductClick.Click();
        }
        #endregion Methods
    }
}
