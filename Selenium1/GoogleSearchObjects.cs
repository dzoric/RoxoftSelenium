using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    class GoogleSearchObjects
    {
        public GoogleSearchObjects()
        {
            PageFactory.InitElements(DriverInitializationProperty.driver, this);
        }

        [FindsBy(How = How.XPath,Using = "//h3[contains(text(),'Roxoft.hr')]")]
        public IWebElement linkText { get; set; }

        public RoxoftHomeObjects OpenLink()
        {
            linkText.Click();
            return new RoxoftHomeObjects();
        }
    }
}
