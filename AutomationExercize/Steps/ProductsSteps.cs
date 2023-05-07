using System;
using AutomationExercize.Helpers;
using AutomationExercize.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationExercize.Steps
{
    [Binding]
    public class ProductsSteps : Base 
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.productsLink);
        }
        
        [When(@"user enters product in search box")]
        public void WhenUserEntersProductInSearchBox()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.EnterTextInElement(pp.searchProduct, TestConstants.SearchProduct);
        }
        
        [When(@"user clicks on magnifying-glass button")]
        public void WhenUserClicksOnMagnifying_GlassButton()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.ClickOnElement(pp.mgButton);
        }
        
        [Then(@"user is redirected to '(.*)' section")]
        public void ThenUserIsRedirectedToSection(string text)
        {
            ProductsPage pp = new ProductsPage(Driver);
            Assert.True(ut.ElementIsDisplayed(pp.searchedProducts), "Searched Products are NOT displayed!");
        }
    }
}
