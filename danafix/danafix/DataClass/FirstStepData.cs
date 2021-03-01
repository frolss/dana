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
    class FirstStepData
    {
        private string name;
        private string email;
        private string birthdate;
        private string birthplace;

        public FirstStepData(string name)
        {
            this.name = name;
        }
        public FirstStepData(string name, string email, string birthdate, string birthplace) //этот конструктор можно удалить
        {
            this.name = name;
            this.email = email;
            this.birthdate = birthdate;
            this.birthplace = birthplace;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public string Birthplace
        {
            get
            {
                return birthplace;
            }
            set
            {
                birthplace = value;
            }
        }

    }
}
