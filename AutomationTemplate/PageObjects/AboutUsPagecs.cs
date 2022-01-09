using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects
{
    public class AboutUsPage : BaseAutomationPracticePage
    {
        public AboutUsPage(IWebDriver driver) : base(driver)
        {
        }

        public By PageHeading() => By.ClassName("page-heading");

    }
}
