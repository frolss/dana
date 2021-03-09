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
    public class web_application : TestBase
    {
        [Test]
        public void web_first_application()
        {
            HomePageData phone = new HomePageData("08 2689521987");
            DataContact data = new DataContact("Doro Goro");
            data.Email = "goro@mail.ru";
            data.Birthdate = "10.10.1990";
            data.Birthplace = "Testo";
            data.Address = "Pengotan, Kec. Bangli";

            app.HomePage.PhoneNumberInput(phone);
            app.FirstStep.FirstStep(data);
            app.SecondStep.SecondStep(data);

        }
    }
}
