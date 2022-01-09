using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects.Shared
{
    public class Footer : BasePage
    {
        public By Specials => By.XPath("//li/a[@title='Specials']");

        public By AboutUs => By.XPath("//li/a[@title='About us']");

        public Footer(IWebDriver driver) : base(driver)
        {
        }

        public MainPage ClickSpecials()
        {
            FindElement(Specials)
                .Click();

            return new MainPage(Driver);
        }

        public AboutUsPage ClickAboutUs()
        {
            FindElement(AboutUs)
                .Click();

            return new AboutUsPage(Driver);
        }
    }
}
