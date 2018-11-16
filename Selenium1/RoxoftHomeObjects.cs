﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium1
{
    class RoxoftHomeObjects
    {
        public RoxoftHomeObjects()
        {
            PageFactory.InitElements(DriverInitializationProperty.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Kontakt')]")]
        public IWebElement linkContact { get; set; }

        [FindsBy(How = How.Name,Using = "Name")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "Message")]
        public IWebElement Message { get; set; }

        public void OpenContact()
        {
            linkContact.Click();
            Thread.Sleep(2000);
        }

        public void FillContactForm(string name, string eMail, string message)
        {
            Name.EnterText(name);
            Email.EnterText(eMail);
            Message.EnterText(message);
            Thread.Sleep(3000);
        }
    }
}