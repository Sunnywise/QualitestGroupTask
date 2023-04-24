using OpenQA.Selenium;
using ProjectTask.Hooks;
using System.Threading;

namespace ProjectTask.PageObjects
{
    public class ShoppingPage
    {
        public IWebDriver driver;
        public ShoppingPage()
        {
            driver = ShoppingBaseTest.driver;
        }

        private IWebElement _firstItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Flying Ninja” to your cart']"));
        private IWebElement _secondItem => driver.FindElement(By.CssSelector(".button.product_type_simple.add_to_cart_button.ajax_add_to_cart[href='?add-to-cart=27']"));
        private IWebElement _thirdItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Patient Ninja” to your cart']"));
        private IWebElement _fourthItem => driver.FindElement(By.XPath("//a[@aria-label='Add “Ship Your Idea” to your cart']"));
        private IWebElement _viewOnCart => driver.FindElement(By.XPath("//a[normalize-space()='Cart']"));
        private IWebElement _fourRandomItems => driver.FindElement(By.ClassName("page-title"));
        private IWebElement _searchLowestPrice => driver.FindElement(By.XPath("//*[@id='post-8']/div/div/form/table/tbody/tr[1]/td[2]/a/img"));
        private IWebElement _delLowestPrice => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/a[1]"));
        private IWebElement _threeItemsRemaining => driver.FindElement(By.ClassName("woocommerce-message"));


        public void FirstItemAddToCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,350)");
            Thread.Sleep(5000);
            _firstItem.Click();
        }

        public void SecondItemAddToCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,350)");
            Thread.Sleep(5000);
            _secondItem.Click();
        }

        public void ThirdItemAddToCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(5000);
            _thirdItem.Click();
        }

        public void FourthItenAddToCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");
            Thread.Sleep(3000);
            _fourthItem.Click();
        }

        public void UserViewOnCartItems()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,50)");
            Thread.Sleep(3000);
            _viewOnCart.Click();
        }

        public bool FourTotalRandomSelectedItems()
        {
            Thread.Sleep(3000);
            return _fourRandomItems.Displayed;
        }

        public bool SearchLowestPriceItem()
        {
           return _searchLowestPrice.Displayed;
        }

        public void DeleteLowestPriceItem()
        {
             _delLowestPrice.Click();
        }

        public bool VerifyThreeItems()
        {
            return _threeItemsRemaining.Displayed;
        }

    }
}
