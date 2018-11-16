using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    class DriverInitializationProperty
    {
        //Dodaje se autoimplementirani property kako bi se mogao koristiti
        //u svim metodama
        public static IWebDriver driver { get; set; }
    }
}
