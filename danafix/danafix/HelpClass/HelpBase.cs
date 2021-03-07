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
    public class HelpBase
    {
        protected IWebDriver driver;

        public HelpBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
