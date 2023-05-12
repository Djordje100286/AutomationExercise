using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationExercize.Pages
{
    class ProductsPage
    {
        readonly IWebDriver _driver;
        public By productsPage = By.Id("advertisement");
        public By searchProduct = By.CssSelector(".container [type='text']");
        public By mgButton = By.CssSelector(".container [type='button']");
        public By searchedProducts = By.ClassName("title");
        public By viewProduct = By.ClassName("fa fa-plus-square");
        public By addBtn = By.ClassName("cart");
        public By productName = By.XPath("//*[@class='product-information']//h2");
        public By viewCart = By.XPath("//*[@id='cartModal']//a");

        public ProductsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productsPage));
        }
    }
}
