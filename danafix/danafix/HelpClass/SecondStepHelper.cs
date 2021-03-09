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
    public class SecondStepHelper : HelpBase
    {
        public SecondStepHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void SecondStep(FirstStepData address)
        {
            WaitUntil.WaitElement(driver, By.Id("application_full_address"));
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.Id("select2-application_living_province_id-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Bali']")).Click();
            driver.FindElement(By.Id("select2-application_living_city_id-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Kabupaten Bangli']")).Click();
            driver.FindElement(By.Id("application_full_address")).Click();
            driver.FindElement(By.Id("application_full_address")).Clear();
            driver.FindElement(By.Id("application_full_address")).SendKeys(address.Address);
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
