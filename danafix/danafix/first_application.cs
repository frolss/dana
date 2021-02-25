using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace danafix
{
    [TestFixture]
    public class web_application
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://dev.danafix.id";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void web_first_application()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("application_mobile_phone")).Click();
            driver.FindElement(By.Id("application_mobile_phone")).SendKeys("08 2689521987");
            driver.FindElement(By.XPath("//span[text()='Ambil uang sekarang']")).Click();
            WaitUntil.WaitElement(driver, By.Id("application_full_name"));
            driver.FindElement(By.Id("application_full_name")).Click();
            driver.FindElement(By.Id("application_full_name")).SendKeys("Doro Goro");
            WaitUntil.WaitSomeTime(2);
            driver.FindElement(By.Id("application_email")).Click();
            driver.FindElement(By.Id("application_email")).SendKeys("goro@mail.ru");
            driver.FindElement(By.Id("application_date_of_birth")).Click();
            driver.FindElement(By.Id("application_date_of_birth")).SendKeys("10.10.1990");
            driver.FindElement(By.XPath("//form[@id='form-step-01']/div[5]/div/span/label")).Click();
            driver.FindElement(By.Id("application_place_of_birth")).Click();
            driver.FindElement(By.Id("application_place_of_birth")).SendKeys("Testo");
            driver.FindElement(By.Id("select2-application_religion_code-container")).Click();
            WaitUntil.WaitSomeTime(10);
            driver.FindElement(By.XPath("//li[text()='Islam']")).Click();
            driver.FindElement(By.Name("commit")).Click();
            WaitUntil.WaitSomeTime(5);

        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
