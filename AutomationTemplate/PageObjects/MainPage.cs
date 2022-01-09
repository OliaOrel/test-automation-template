using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects
{
    public class MainPage : BaseAutomationPracticePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public By ProductContainers => By.XPath("//div[@class='product-container']//div[@class='right-block']");

        public By DiscountPercentage => By.XPath("//div[@class='product-container']//div[@class='right-block']//span[@class='price-percent-reduction']");

    }
}
