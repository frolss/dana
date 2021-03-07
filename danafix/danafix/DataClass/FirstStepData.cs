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
    public class FirstStepData
    {
        public FirstStepData(string name)
        {
            Name = name;
        }
        public FirstStepData(string name, string email, string birthdate, string birthplace) //этот конструктор можно удалить
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
            Birthplace = birthplace;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public string Birthplace { get; set; }
    }
}
