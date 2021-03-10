using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace danafix
{
    public class ThirdStepHelper : HelpBase
    {
        public ThirdStepHelper (ApplicationManager manager) : base(manager)
        {
        }

        public void ThirdStep (DataContact data)
        {
            WaitUntil.WaitElement(driver, By.Id("application_relative_mobile_phone"));
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.Id("select2-application_education_code-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Diploma 3 (D3)']")).Click();
            driver.FindElement(By.Id("select2-application_social_status_id-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Manajer']")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.Id("select2-application_working_industry_id-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Hotel / Rumah Makan']")).Click();
            driver.FindElement(By.Id("application_salary")).Click();
            driver.FindElement(By.Id("application_salary")).Clear();
            driver.FindElement(By.Id("application_salary")).SendKeys(data.Salary);
            driver.FindElement(By.Id("application_relative_mobile_phone")).Click();
            driver.FindElement(By.Id("application_relative_mobile_phone")).Clear();
            driver.FindElement(By.Id("application_relative_mobile_phone")).SendKeys(data.Guarantorphone);
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
