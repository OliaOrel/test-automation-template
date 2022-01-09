using FluentAssertions;
using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    class FooterTests : BaseGeneralTest
    {
        [Test]
        public void Specials_ClickOnLink_SaleProducts()
        {
            //arrange

            //act
            var mainPage = Footer.ClickSpecials();
            var ProductContainers = mainPage.ProductContainers;
            var DiscountPercentage = mainPage.DiscountPercentage;
            int ProductContainersCounter = WebElementHelper.ElementCounter(ProductContainers);
            int DiscountPercentageCounter = WebElementHelper.ElementCounter(DiscountPercentage);

            Console.WriteLine(ProductContainersCounter);
            Console.WriteLine(DiscountPercentageCounter);

            //assert
            ProductContainersCounter.Should()
                                    .Be(DiscountPercentageCounter);
        }

        [Test]
        public void AboutUs_ClickOnLink_AboutUsInfoPage()
        {
            //arrange
            string pageHeadingTitle = "ABOUT US";

            //act
            var searchResultBy = Footer.ClickAboutUs()
                                       .PageHeading();
            string resultPageHeadingTitle = WebElementHelper.GetElementText(searchResultBy);

            //assert
            resultPageHeadingTitle.Should()
                               .Be(pageHeadingTitle);
        }
    }
}
