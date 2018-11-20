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
        //Created Auto-implemented propery of type IWebDriver
        //Making it available throughout all methods
        public static IWebDriver driver { get; set; }
    }
}
