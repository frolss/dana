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
    public class NavigateHelper : HelpBase
    {
        private string baseURL;
        private string baseURLadmin;
        public NavigateHelper(ApplicationManager manager, string baseURL, string baseURLadmin) : base(manager)
        {
            this.baseURL = baseURL;
            this.baseURLadmin = baseURLadmin;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void OpenAdminPage()
        {
            driver.Navigate().GoToUrl(baseURLadmin);
        }
    }
}
