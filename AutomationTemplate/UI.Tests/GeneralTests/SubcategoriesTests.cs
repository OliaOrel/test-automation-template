using FluentAssertions;
using NUnit.Framework;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class SubcategoriesTests : BaseGeneralTest
    {        
        [Test]
        public void TshirtsSubcategory_ClickButton_PageOpens()
        {
            //arrange
            string categoryTitle = "T-SHIRTS ";

            //act
            var searchResultBy = Header.HoverOnWomenButton()
                                       .ClickOnSubcategory()
                                       .CategoryTitleBy();

            //assert
            WebElementHelper.GetElementText(searchResultBy)
                            .Should()
                            .Be(categoryTitle);
        }
    }
}
