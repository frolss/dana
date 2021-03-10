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
    public class DataContact
    {
        public DataContact(string name)
        {
            Name = name;
        }
        /*public FirstStepData(string name, string email, string birthdate, string birthplace) //этот конструктор можно удалить
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
            Birthplace = birthplace;
        }*/
        public string Name { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public string Birthplace { get; set; }
        public string Address { get; set; }
        public string Guarantorphone { get; set; }
        public string Salary { get; set; }
        public string Ktp { get; set; }
        public string AccounNumber { get; set; }
    }
}
