using OpenQA.Selenium;
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

        [FindsBy(How = How.Name, Using = "Name")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "Message")]
        public IWebElement Message { get; set; }

        [FindsBy(How = How.Id, Using = "HomeMenuIcon")]
        public IWebElement Hamburger { get; set; }

        public void OpenContact()
        {
            //Method checks if Contact button is present in navigation bar
            //Problem occured while running the test in tabled/mobile mode
            //where Contact button is displayed only after clicking "menu" icon
            bool ContactButton = linkContact.Displayed;
            if (ContactButton == true)
            {
                linkContact.Click();
            }
            else
            {
                Hamburger.Click();
                Thread.Sleep(300);
                linkContact.Click();
            }


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
