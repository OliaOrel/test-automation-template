﻿using System;
using System.Linq;
using OpenQA.Selenium;

namespace UI.Services
{
    public class WebElementHelper
    {
        private readonly IWebDriver _driver;

        public WebElementHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsElementPresented(By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }
            catch (Exception e) when (e is NoSuchElementException || e is StaleElementReferenceException)
            {
                return false;
            }
        }

        public string GetElementText(By by)
        {
            return _driver.FindElement(by).Text;
        }

        public string GetElementAttribut(By by, string attributeName)
        {
            return _driver.FindElement(by).GetAttribute(attributeName);
        }

        public int ElementCounter(By by)
        {
            return _driver.FindElements(by).Count;

        }


        public string GenerateRandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()|;:'";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int GenerateRandomInt(int min, int max)
        {
            var random = new Random();

            return random.Next(min, max);
        }
    }
}
