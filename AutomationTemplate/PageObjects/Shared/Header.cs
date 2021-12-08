using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects.Shared
{
    public class Header : BasePage
    {
        public By SearchFieldBy => By.Id("search_query_top");

        public By SearchButton => By.Name("submit_search");

        public By HeaderBanner => By.XPath("//div[@class='banner']");

        public By Logo => By.ClassName("logo");

        public By WomenButton => By.XPath("//a[@title='Women']");

        public By DressesButton => By.XPath("//div/ul/li/a[@title='Dresses']");

        public By TshirtsButton => By.XPath("//div/ul/li/a[@title='T-shirts']");

        public Header(IWebDriver driver) : base(driver)
        {
        }

        public Header ClickSearchField()
        {
            FindElement(SearchFieldBy)
                .Click();

            return this;
        }

        public Header EnterSearchText(string text)
        {
            FindElement(SearchFieldBy)
                .SendKeys(text);
            return this;
        }

        public SearchResultsPage ClickSearchButton()
        {
            FindElement(SearchButton)
                .Click();

            return new SearchResultsPage(Driver);
        }

        public MainPage ClickHeaderBanner()
        {
            FindElement(HeaderBanner)
                .Click();

            return new MainPage(Driver);
        }

        public MainPage ClickLogo()
        {
            FindElement(Logo)
                .Click();

            return new MainPage(Driver);
        }

        public CategoryPage ClickWomenButton()
        {
            FindElement(WomenButton)
                .Click();

            return new CategoryPage(Driver);
        }

        public CategoryPage ClickDressesButton()
        {
            FindElement(DressesButton)
                .Click();

            return new CategoryPage(Driver);
        }

        public CategoryPage ClickTshirtsButton()
        {
            FindElement(TshirtsButton)
                .Click();

            return new CategoryPage(Driver);
        }

    }
}
