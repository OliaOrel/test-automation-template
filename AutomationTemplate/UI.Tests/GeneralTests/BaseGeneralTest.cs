using NUnit.Framework;
using UI.PageObjects; //
using UI.PageObjects.Shared;

namespace UI.Tests.GeneralTests
{
    public class BaseGeneralTest : BaseUiTest
    {
        protected Header Header;

        protected Footer Footer;

        protected MainPage MainPage; //

        [SetUp]
        public void GeneralSetUp()
        {
            Header = new Header(Driver);

            Footer = new Footer(Driver);

            MainPage = new MainPage(Driver); //
        }
    }
}
