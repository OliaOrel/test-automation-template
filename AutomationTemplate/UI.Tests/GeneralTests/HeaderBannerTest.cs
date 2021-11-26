using FluentAssertions;
using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    class HeaderBannerTest : BaseGeneralTest
    {
        [Test]
        public void HeaderBanner_ClickOnBanner_SaleProducts()
        {
            //arrange
           
            //act
            var MyMainPage = Header.ClickHeaderBanner();
            var ProductContainers = MyMainPage.ProductContainers;
            var DiscountPercentage = MyMainPage.DiscountPercentage;
            int ProductContainersCounter = WebElementHelper.ElementCounter(ProductContainers);
            int DiscountPercentageCounter = WebElementHelper.ElementCounter(DiscountPercentage);

            Console.WriteLine(ProductContainersCounter);
            Console.WriteLine(DiscountPercentageCounter);

            //assert
            ProductContainersCounter.Should().Be(DiscountPercentageCounter);
        }
    }
}
