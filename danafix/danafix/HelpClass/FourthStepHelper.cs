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
    public class FourthStepHelper : HelpBase
    {
        public FourthStepHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void FourthStep()
        {
            //WaitUntil.WaitElement(driver, By.Id("front_ktp"));
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.Id("front_ktp")).Click();
            driver.FindElement(By.Id("front_ktp")).Clear();
            driver.FindElement(By.Id("front_ktp")).SendKeys("C:\\fakepath\\images (6).jpg");
        }
    }
}
