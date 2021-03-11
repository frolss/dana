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
            WaitUntil.WaitElement(driver, By.XPath("//div[text()='Upload foto KTP']"));
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//input[@type = 'file'][@id = 'front_ktp']")).SendKeys("C:\\Users\\Владелец\\Downloads\\foto.png");
            WaitUntil.WaitElement(driver, By.CssSelector("div.fileinput__text_ktp.upload.ok"));
            driver.FindElement(By.XPath("//input[@type = 'file'][@id = 'selfie_with_ktp']")).SendKeys("C:\\Users\\Владелец\\Downloads\\selfi.jpg");
            WaitUntil.WaitElement(driver, By.CssSelector("div.fileinput__text_selfie.upload.ok"));
            driver.FindElement(By.Name("commit")).Click();
            //driver.FindElement(By.Id("front_ktp")).Clear();
            //driver.FindElement(By.Id("front_ktp")).SendKeys("C:\\fakepath\\images (6).jpg");
        }
    }
}
