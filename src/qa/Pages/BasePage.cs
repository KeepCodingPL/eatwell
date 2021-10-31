using OpenQA.Selenium;

namespace EatWell.QA.Pages
{
    public abstract class BasePage : DriverManager
    {
        #region Paths

        string addNewProductClickBtnPath = "//a[text()='Add New Product']";

        #endregion

        #region PageMethods

        public void ClickAddNewProduct()
        {
            IWebElement addNewProductClick = driver.FindElement(By.XPath(addNewProductClickBtnPath));
            addNewProductClick.Click();
        }

        #endregion

        #region UtilityMethods

        public bool URLComparison(string currentUrl, string expectedUrl)
        {
            if (currentUrl.Equals(expectedUrl))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
