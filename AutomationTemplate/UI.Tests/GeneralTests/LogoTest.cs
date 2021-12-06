using FluentAssertions;
using NUnit.Framework;
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
            var currentURL = Header.ClickLogo()
                                   .GetURL();

            //assert
            currentURL.Should()
                      .Be("http://automationpractice.com/index.php");
        }
    }
}
