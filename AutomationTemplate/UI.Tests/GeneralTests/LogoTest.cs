using FluentAssertions;
using NUnit.Framework;
using System;
using OpenQA.Selenium;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class LogoTest : BaseGeneralTest
    {
        [Test]
        public void Logo_Click_LoadMainPage()
        {
            //arrange

            //act
            Header.ClickLogo();
            string currentURL = WebElementHelper.GetUrl();

            Console.WriteLine(currentURL);

            //assert
            currentURL.Should()
                      .Be("http://automationpractice.com/index.php");
        }
    }
}
