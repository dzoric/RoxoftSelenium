using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    //izrada custom metoda
    public static class SetMethods
    {
        /// <summary>
        /// Proširena metoda za unošenje teksta
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Klik na button i ostalo
        /// </summary>
        /// <param name="element"></param>
        public static void Click(this IWebElement element)
        {
            element.Click();
        }
        
    }
}
