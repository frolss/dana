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
        public SecondStepHelper secondStepHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "https://dev.danafix.id";

            homePageHelper = new HomePageHelper(this);
            firstStepHelper = new FirstStepHelper(this);
            navigateHelper = new NavigateHelper(this, baseURL, baseURLadmin);
            secondStepHelper = new SecondStepHelper(this);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
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

        public HomePageHelper HomePage
        {
            get
            {
                return homePageHelper;
            }
        }

        public FirstStepHelper FirstStep
        {
            get
            {
                return firstStepHelper;
            }
        }

        public NavigateHelper Navigate
        {
            get
            {
                return navigateHelper;
            }
        }

        public SecondStepHelper SecondStep
        {
            get
            {
                return secondStepHelper;
            }
        }

        
    }
}
