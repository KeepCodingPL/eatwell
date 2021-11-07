using OpenQA.Selenium;

namespace EatWell.QA.Pages
{
    public abstract class BasePage : DriverManager
    {
        private readonly string _addNewProductClickBtnPath = "//a[text()='Add New Product']";

        public void ClickAddNewProduct()
        {
            var addNewProductClick = driver.FindElement(By.XPath(_addNewProductClickBtnPath));
            addNewProductClick.Click();
        }

        public bool CompareURL(string currentUrl, string expectedUrl) => currentUrl.Equals(expectedUrl) ? true : false; //lambda function
       

    }
}
