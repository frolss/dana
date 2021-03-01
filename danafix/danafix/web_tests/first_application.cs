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
            OpenHomePage();
            PhoneNumberInput(new HomePageData("08 2689521987"));
            FirstStepData data = new FirstStepData("Doro Goro");
            data.Email = "goro@mail.ru";
            data.Birthdate = "10.10.1990";
            data.Birthplace = "Testo";
            FirstStep(data);
        }

        private void FirstStep(FirstStepData account)
        {
            WaitUntil.WaitElement(driver, By.Id("application_full_name"));
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

        private void PhoneNumberInput(HomePageData phone)
        {
            driver.FindElement(By.Id("application_mobile_phone")).Click();
            driver.FindElement(By.Id("application_mobile_phone")).SendKeys(phone.Mobilephone);
            driver.FindElement(By.XPath("//span[text()='Ambil uang sekarang']")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
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
