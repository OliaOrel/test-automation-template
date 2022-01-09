using FluentAssertions;
using NUnit.Framework;
using System;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class SearchTests : BaseGeneralTest
    {
        [Test]
        public void Search_EnterValidData_ValidOutput()
        {
            //arrange
            const string searchData = "faded";
            const string searchResultText = "Faded Short Sleeve T-shirts";

            //act
            var searchResultBy = Header.ClickSearchField()
                                       .EnterSearchText(searchData)
                                       .ClickSearchButton()
                                       .GetSearchResultBy(searchResultText);

            //assert
            WebElementHelper.IsElementPresented(searchResultBy)
                            .Should()
                            .BeTrue();
        }

        [Test]
        public void Search_EnterInvalidData_NoResultsAlertIsPresent()
        {
            //arrange
            string searchData = WebElementHelper.GenerateRandomString(10);
           
            //act
            var searchResultBy = Header.ClickSearchField()
                                       .EnterSearchText(searchData)
                                       .ClickSearchButton()
                                       .GetNoResultAlertBy();

            //assert
            WebElementHelper.IsElementPresented(searchResultBy)
                            .Should()
                            .BeTrue();
        }

        [Test]
        public void Search_EnterInvalidData_NoResultsAlertWithText()
        {
            //arrange
            string searchData = WebElementHelper.GenerateRandomString(10);

            //act
            var searchResultBy = Header.ClickSearchField()
                                       .EnterSearchText(searchData)
                                       .ClickSearchButton()
                                       .GetNoResultAlertBy();

            Console.WriteLine(WebElementHelper.GetElementText(searchResultBy));

            //assert
            WebElementHelper.GetElementText(searchResultBy)
                            .Should()
                            .StartWith("No results were found for your search")
                            .And
                            .Contain(searchData);
        }

    }
}
