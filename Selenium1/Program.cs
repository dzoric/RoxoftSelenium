using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            DriverInitializationProperty.driver = new ChromeDriver();
            DriverInitializationProperty.driver.Navigate().GoToUrl("http://www.google.hr");
        }

        [Test]
        public void Execute()
        {
            //Promijeniti putanju .xlsx file-a na putanju u kojoj se trenutno nalazi na lokalnom računalu
            ExcelToContactForm.PopulateCollection(@"C:\Users\Dusan\source\repos\Selenium1\Selenium1\OvoJeProba.xlsx");

            GoogleHomePageObjects googleHome = new GoogleHomePageObjects();
            googleHome.SearchGoogle("roxoft");

            GoogleSearchObjects googleSearch = new GoogleSearchObjects();
            googleSearch.OpenLink();

            RoxoftHomeObjects roxoftHome = new RoxoftHomeObjects();
            roxoftHome.OpenContact();
            roxoftHome.FillContactForm(ExcelToContactForm.ReadData(1, "Name"), ExcelToContactForm.ReadData(1, "Email"), ExcelToContactForm.ReadData(1, "Message"));
            Thread.Sleep(3000);
        }

        [TearDown]
        public void CleanUp()
        {
            DriverInitializationProperty.driver.Close();
        }
    }
}
