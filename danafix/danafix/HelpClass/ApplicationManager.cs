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
    public class ApplicationManager
    {
        public IWebDriver driver;
        public string baseURL;
        public string baseURLadmin;
        public FirstStepHelper firstStepHelper;
        public HomePageHelper homePageHelper;
        public NavigateHelper navigateHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "https://dev.danafix.id";
            homePageHelper = new HomePageHelper(driver);
            firstStepHelper = new FirstStepHelper(driver);
            navigateHelper = new NavigateHelper(driver, baseURL, baseURLadmin);
        }

        public void Stop()
        {   
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
