using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using UI.PageObjects.Base;
using System.Collections.ObjectModel;
using System;

namespace UI.PageObjects
{
    public class DetailedView : BaseAutomationPracticePage
    {
        public By QuantityInput => By.Id("quantity_wanted");

        public DetailedView(IWebDriver driver) : base(driver)
        {
        }

        public DetailedView ClickQuantityInput()
        {
            FindElement(QuantityInput)
                .Click();

            Console.WriteLine("Click Quantity Input");

            return this;
        }

        public DetailedView ClearQuantityInput()
        {
            FindElement(QuantityInput)
                .Clear();

            Console.WriteLine("Clear Quantity Input");

            return this;
        }

        public DetailedView EnterQuantityInput(string text)
        {
            FindElement(QuantityInput)
                .SendKeys(text);

            Console.WriteLine("Enter Quantity Input");

            return this;
        }
    }
}
