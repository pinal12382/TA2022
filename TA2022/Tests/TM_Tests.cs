using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TA2022.pages;
using TA2022.Utilities;

namespace TA2022.Tests
{
    [TestFixture]
    internal class TM_Tests : CommonDriver
    {



        [SetUp]
        public void loginFunction()
        {
            // open the crome browser

            mydriver = new ChromeDriver();

            mydriver.Manage().Window.Maximize();

            // Login page object initailazion and definition

            LoginPage LoginPageobj = new LoginPage();
            LoginPageobj.loginSteps(mydriver);

            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTMpage(mydriver);
        }
        [Test]
        public void CreateTM_Test()
        {
            // TM page object initailazion and definition

            TMpage TMpageobj = new TMpage();
            TMpageobj.CreateTM(mydriver);

        }

        [Test]

        public void EditTM_Test()
        {
            // Edit TM

            TMpage TMpageobj = new TMpage();
            TMpageobj.EditTM(mydriver);
        }
        [Test]
        public void DeleteTM_Test()
        {
            // Delete Tm
            TMpage TMpageobj = new TMpage();
            TMpageobj.DeleteTM(mydriver);

        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}