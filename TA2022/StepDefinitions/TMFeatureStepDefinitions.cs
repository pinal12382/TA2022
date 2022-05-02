using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TA2022.pages;
using TA2022.Utilities;
using TechTalk.SpecFlow;

namespace TA2022.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageobj = new LoginPage();
        Homepage HomePageobj = new Homepage();
        TMpage TMpageobj = new TMpage();

        [Given(@"I logged in to Turnup Portal successfully")]
        public void GivenILoggedInToTurnupPortalSuccessfully()
        {
           

            // open the crome browser

            mydriver = new ChromeDriver();

            mydriver.Manage().Window.Maximize();

            // Login page object initailazion and definition

            
            LoginPageobj.loginSteps(mydriver);
            
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initailazion and definition


            HomePageobj.GotoTMpage(mydriver);

        }

        [When(@"I Create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initailazion and definition

            
            TMpageobj.CreateTM(mydriver);
            
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            
            string newCode = TMpageobj.GetCode(mydriver);
            string newTypecode = TMpageobj.GetTypeCode(mydriver);
            string newdiscription = TMpageobj.GetDescription(mydriver);
            string newPrice = TMpageobj.GetPrice(mydriver);
            
            Assert.That(newCode == "Test2022", "Actual code and expected code  do not match");
            Assert.That(newTypecode == "M", "Actual Typecode and expected Tyoecode do not match");
            Assert.That(newdiscription == "Test2022", "Actual discription and expected Description do not match");
            Assert.That(newPrice == "$1,310.00", "Actual price and expected Price do not match");
        }
        [When(@"I update '([^']*)','([^']*)','([^']*)' on existing time and material records")]
        public void WhenIUpdateOnExistingTimeAndMaterialRecords(string p0, string p1, string p2)
        {
            TMpageobj.EditTM(mydriver,p0,p1,p2);
        }

        [Then(@"the record should have updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0, string p1, string p2)
        {
            string editedDescription = TMpageobj.GetEditedDescription(mydriver);
            string editedcode = TMpageobj.GetEditedcode(mydriver);
            string editedprice = TMpageobj.GetEditedprice(mydriver);

            Assert.That(editedDescription == p0, "Actual discription and expected Description do not match");
            Assert.That(editedcode == p1, "Actual code and expected code do not match");
            Assert.That(editedprice == p2, "Actual price and expected Price do not match");
            
        }






    }
}
