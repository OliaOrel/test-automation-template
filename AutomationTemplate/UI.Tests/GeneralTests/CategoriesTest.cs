using FluentAssertions;
using NUnit.Framework;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class CategoriesTests : BaseGeneralTest
    {
        [Test]
        public void WomenCategory_ClickButton_PageOpens()
        {
            //arrange
            string categoryTitle = "WOMEN ";

            //act
            var searchResultBy = Header.ClickWomenButton().CategoryTitleBy();
            string resultCategoryTitle = WebElementHelper.GetElementText(searchResultBy);

            //assert
            resultCategoryTitle.Should()
                               .Be(categoryTitle);
        }

        [Test]
        public void DressesCategory_ClickButton_PageOpens()
        {
            //arrange
            string categoryTitle = "DRESSES ";

            //act
            var searchResultBy = Header.ClickDressesButton().CategoryTitleBy();
            string resultCategoryTitle = WebElementHelper.GetElementText(searchResultBy);

            //assert
            resultCategoryTitle.Should()
                               .Be(categoryTitle);
        }

        [Test]
        public void TshirtsCategory_ClickButton_PageOpens()
        {
            //arrange
            string categoryTitle = "T-SHIRTS ";

            //act
            var searchResultBy = Header.ClickTshirtsButton().CategoryTitleBy();
            string resultCategoryTitle = WebElementHelper.GetElementText(searchResultBy);

            //assert
            resultCategoryTitle.Should()
                               .Be(categoryTitle);
        }



    }
}
