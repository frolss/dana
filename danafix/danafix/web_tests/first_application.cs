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
            data.Guarantorphone = "08 2689525896";
            data.Salary = "15.000.000";
            data.Ktp = "5865211010905621";
            data.AccounNumber = "5651259875";

            app.HomePage.PhoneNumberInput(phone);
            app.FirstStep.FirstStep(data);
            app.SecondStep.SecondStep(data);
            app.ThirdStep.ThirdStep(data);
            app.FourthStep.FourthStep();
            app.FifthStep.FifthStep(data);
        }
    }
}
