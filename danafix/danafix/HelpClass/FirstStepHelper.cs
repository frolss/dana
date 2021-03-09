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
    public class FirstStepHelper : HelpBase
    {
        public FirstStepHelper(ApplicationManager manager) : base(manager)                                                                                                                                                                                    
        {
        }
        public void FirstStep(FirstStepData account)
        {
            WaitUntil.WaitElement(driver,By.Id("application_full_name"));
            driver.FindElement(By.Id("application_full_name")).Click();
            driver.FindElement(By.Id("application_full_name")).SendKeys(account.Name);
            WaitUntil.WaitSomeTime(2);
            driver.FindElement(By.Id("application_email")).Click();
            driver.FindElement(By.Id("application_email")).SendKeys(account.Email);
            driver.FindElement(By.Id("application_date_of_birth")).Click();
            driver.FindElement(By.Id("application_date_of_birth")).SendKeys(account.Birthdate);
            driver.FindElement(By.XPath("//form[@id='form-step-01']/div[5]/div/span/label")).Click();
            driver.FindElement(By.Id("application_place_of_birth")).Click();
            driver.FindElement(By.Id("application_place_of_birth")).SendKeys(account.Birthplace);
            driver.FindElement(By.Id("select2-application_religion_code-container")).Click();
            WaitUntil.WaitSomeTime(5);
            driver.FindElement(By.XPath("//li[text()='Islam']")).Click();
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
