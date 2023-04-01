using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationExercize.Pages
{
    class AccountCreatedPage
    {
        readonly IWebDriver _driver;
        public By page = By.CssSelector(".row [data-qa='account-created']");
        public By continueBtn = By.CssSelector(".btn-primary");

        public AccountCreatedPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page));
        }
    }
}
