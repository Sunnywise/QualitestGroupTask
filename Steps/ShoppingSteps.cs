using NUnit.Framework;
using OpenQA.Selenium;
using ProjectTask.Hooks;
using ProjectTask.PageObjects;
using TechTalk.SpecFlow;

namespace ProjectTask.Features
{
    [Binding]
    public class ShoppingSteps
    {
        public IWebDriver driver = ShoppingBaseTest.driver;
        ShoppingPage _shoppingPage = new ShoppingPage();
        
        [Given(@"I add four random items to my cart\.")]
        public void GivenIAddFourRandomItemsToMyCart_()
        {
            _shoppingPage.FirstItemAddToCart();
            _shoppingPage.SecondItemAddToCart();
            _shoppingPage.ThirdItemAddToCart();
            _shoppingPage.FourthItenAddToCart();
        }

        [When(@"I view my cart\.")]
        public void WhenIViewMyCart_()
        {
            _shoppingPage.UserViewOnCartItems();
        }

        [When(@"I search for the lowest price item\.")]
        public void WhenISearchForTheLowestPriceItem_()
        {
            _shoppingPage.SearchLowestPriceItem();
        }
        
        [When(@"I am able to remove the lowest price item from my cart\.")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart_()
        {
            _shoppingPage.DeleteLowestPriceItem();
        }
        
        [Then(@"I find total four items listed in my cart\.")]
        public void ThenIFindTotalFourItemsListedInMyCart_()
        {
           Assert.That(_shoppingPage.FourTotalRandomSelectedItems());
        }
        
        [Then(@"I am able to verify three items in my cart\.")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart_()
        {
            Assert.IsTrue(_shoppingPage.VerifyThreeItems());
        }
    }
}
