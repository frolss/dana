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
    public class HomePageHelper : HelpBase
    {
        public HomePageHelper(IWebDriver driver) : base(driver)
        {
        }
        public void PhoneNumberInput(HomePageData phone)
        {
            driver.FindElement(By.Id("application_mobile_phone")).Click();
            driver.FindElement(By.Id("application_mobile_phone")).SendKeys(phone.Mobilephone);
            driver.FindElement(By.XPath("//span[text()='Ambil uang sekarang']")).Click();
        }
    }
}
