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
    class GoogleHomePageObjects
    {
        public GoogleHomePageObjects()
        {
            PageFactory.InitElements(DriverInitializationProperty.driver, this);
        }

        [FindsBy(How = How.Name,Using ="q")]
        public IWebElement txtQ { get; set; }

        [FindsBy(How = How.Name,Using = "btnK")]
        public IWebElement btnSearch { get; set; }

        public GoogleSearchObjects SearchGoogle(string inputValue)
        {
            txtQ.EnterText(inputValue);
            Thread.Sleep(2000);
            btnSearch.Click();

            return new GoogleSearchObjects();
        }
    }
}
