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
    public class HomePageData
    {
        public HomePageData(string mobilephone)
        {
            Mobilephone = mobilephone;
        }

        public string Mobilephone { get; set; }
    }
}
