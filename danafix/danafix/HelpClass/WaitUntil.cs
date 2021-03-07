using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace danafix
{
    public static class WaitUntil
    {
        public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 60)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));

        }

        public static void WaitSomeTime (int seconds)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }
    }
}
