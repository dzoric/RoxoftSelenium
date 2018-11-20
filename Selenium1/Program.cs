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
            //Create the reference for web browser using auto-implemented property
            DriverInitializationProperty.driver = new ChromeDriver();
            //Navigate to Google home page
            DriverInitializationProperty.driver.Navigate().GoToUrl("http://www.google.hr");
        }

        [Test]
        public void Execute()
        {
            //Please change .xslx file route to route where file is located on local PC

            //Initialize excel sheet by calling ExcelToContactForm
            ExcelToContactForm.PopulateCollection(@"C:\Users\Dusan\source\repos\Selenium1\Selenium1\OvoJeProba.xlsx");

            //Initialize object from class GoogleHomePageObjects and call SearchGoogle method
            //using string roxoft as an input value
            GoogleHomePageObjects googleHome = new GoogleHomePageObjects();
            googleHome.SearchGoogle("roxoft");

            //Slimilarly initialize new googleSearch object from GoogleSearchObjects class
            //and use OpenLink method to click on first link
            GoogleSearchObjects googleSearch = new GoogleSearchObjects();
            googleSearch.OpenLink();

            //Initialize roxoftHome object and use OpenContact method to navigate to Contact
            //form, FillContactForm with data read from Excell table which are nothing but three
            //string values read from first row of specific column name
            //Thread goes to sleep for 3000 miliseconds allowing user to read written data
            RoxoftHomeObjects roxoftHome = new RoxoftHomeObjects();
            roxoftHome.OpenContact();
            roxoftHome.FillContactForm(ExcelToContactForm.ReadData(1, "Name"), ExcelToContactForm.ReadData(1, "Email"), ExcelToContactForm.ReadData(1, "Message"));
            Thread.Sleep(3000);
        }

        [TearDown]
        public void CleanUp()
        {
            //Close web browser
            DriverInitializationProperty.driver.Close();
        }
    }
}
