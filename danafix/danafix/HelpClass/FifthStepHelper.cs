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
    public class FifthStepHelper : HelpBase
    {
        public FifthStepHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void FifthStep(DataContact data)
        {
            WaitUntil.WaitElement(driver, By.Id("application_document_number"));
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.Id("application_document_number")).Click();
            driver.FindElement(By.Id("application_document_number")).Clear();
            driver.FindElement(By.Id("application_document_number")).SendKeys(data.Ktp);
            driver.FindElement(By.Id("select2-application_bank_id-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='PT Bank Central Asia Tbk (BCA)']")).Click();
            driver.FindElement(By.Id("application_account_number")).Click();
            driver.FindElement(By.Id("application_account_number")).Clear();
            driver.FindElement(By.Id("application_account_number")).SendKeys(data.AccounNumber);
            driver.FindElement(By.Id("select2-application_utilization_loan_code-container")).Click();
            WaitUntil.WaitSomeTime(3);
            driver.FindElement(By.XPath("//li[text()='Kebutuhan hidup']")).Click();
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
