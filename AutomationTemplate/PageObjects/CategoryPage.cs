using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects
{
    public class CategoryPage : BaseAutomationPracticePage
    {
        public CategoryPage(IWebDriver driver) : base(driver)
        {
        }

        public By CategoryTitleBy() => By.ClassName("cat-name");
    }
}
