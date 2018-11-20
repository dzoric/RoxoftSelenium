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
        //Constructor which initializes controls written below using PageFactory class
        //with InitElements method accepting driver instance and this page initialized
        //in Program.cs Execute method
        public GoogleHomePageObjects()
        {
            PageFactory.InitElements(DriverInitializationProperty.driver, this);
        }

        //Creating an auto-implemented property of type IWebElement using FindsBy
        //attribute which accepts How enumerator describing by which parameter
        //page object is going to be searched by and Using parameter which specifies
        //the value of that parameter
        //Usefull when value of page object is changed because this way, developer
        //needs to change value in one place in code, which is nothing but Using value
        [FindsBy(How = How.Name,Using ="q")]
        public IWebElement txtQ { get; set; }

        [FindsBy(How = How.Name,Using = "btnK")]
        public IWebElement btnSearch { get; set; }

        //SearchGoogle method accepting inputValue which is used in Execute method in Program.cs
        //this method is using custom written method EnterText which is nothing but SendKeys method
        //already implemented in OpenQA.Selenium namespace
        //txtQ (Google search textbox) is an object EnterText is used on
        //Thread.Sleep is used because writing text in Google search bar opens other suggestions
        //which interferes with search button makin it unclickable
        //Method returns GoogleSearchObjects for navigation between pages
        public GoogleSearchObjects SearchGoogle(string inputValue)
        {
            txtQ.EnterText(inputValue);
            Thread.Sleep(1000);
            btnSearch.Click();

            return new GoogleSearchObjects();
        }
    }
}
