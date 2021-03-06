﻿using System;
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
        public ThirdStepHelper thirdStepHelper;
        public FourthStepHelper fourthStepHelper;
        public FifthStepHelper fifthStepHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "https://dev.danafix.id";

            homePageHelper = new HomePageHelper(this);
            firstStepHelper = new FirstStepHelper(this);
            navigateHelper = new NavigateHelper(this, baseURL, baseURLadmin);
            secondStepHelper = new SecondStepHelper(this);
            thirdStepHelper = new ThirdStepHelper(this);
            fourthStepHelper = new FourthStepHelper(this);
            fifthStepHelper = new FifthStepHelper(this);
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

        public ThirdStepHelper ThirdStep
        {
            get
            {
                return thirdStepHelper;
            }
        }

        public FourthStepHelper FourthStep
        {
            get
            {
                return fourthStepHelper;
            }
        }

        public FifthStepHelper FifthStep
        {
            get
            {
                return fifthStepHelper;
            }
        }

        
    }
}
