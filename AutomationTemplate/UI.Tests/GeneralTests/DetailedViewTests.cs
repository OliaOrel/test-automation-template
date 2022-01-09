using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class DetailedViewTests : BaseGeneralTest
    {
        [Test]
        public void Quantity_EnterValidData_ValidOutput()
        {
            //arrange
            string input = WebElementHelper.GenerateRandomInt(1, 100).ToString();

            int ProductContainersCounter = MainPage.GetProductContainersList()
                                                   .Count;
            int index = WebElementHelper.GenerateRandomInt(0, ProductContainersCounter / 2);

            //act

            MainPage.ClickProductContainer(index)
                    .ClickQuantityInput()
                    .ClearQuantityInput()
                    .EnterQuantityInput(input);

            //assert
            
            WebElementHelper.GetElementAttribut(MainPage.QuantityInput, "value")
                            .Should()
                            .Be(input);
        }
    }
}
