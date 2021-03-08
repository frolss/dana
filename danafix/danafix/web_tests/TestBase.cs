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
    public class TestBase
    {
        public IWebDriver driver;
        private StringBuilder verificationErrors;
        public string baseURL;
        public string baseURLadmin;
        protected FirstStepHelper firstStepHelper;
        protected HomePageHelper homePageHelper;
        protected NavigateHelper navigateHelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://dev.danafix.id";
            verificationErrors = new StringBuilder();

            homePageHelper = new HomePageHelper(driver);
            firstStepHelper = new FirstStepHelper(driver);
            navigateHelper = new NavigateHelper(driver, baseURL, baseURLadmin);
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
    }
}
