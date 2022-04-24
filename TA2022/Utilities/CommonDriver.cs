using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA2022.pages;

namespace TA2022.Utilities
{
    internal class CommonDriver
    {
        public IWebDriver mydriver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            // open the crome browser

            mydriver = new ChromeDriver();

            mydriver.Manage().Window.Maximize();

            // Login page object initailazion and definition

            LoginPage LoginPageobj = new LoginPage();
            LoginPageobj.loginSteps(mydriver);

            
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            mydriver.Quit();
        }
    }
}