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
    [Parallelizable]
    internal class TM_Tests : CommonDriver
    {
                  
                 
        [Test,Order (1)]
        public void CreateTM_Test()
        { 
             // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTMpage(mydriver);
        
            // TM page object initailazion and definition

            TMpage TMpageobj = new TMpage();
            TMpageobj.CreateTM(mydriver);

        }

        [Test, Order (2)]

        public void EditTM_Test()
        {
            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTMpage(mydriver);
            // Edit TM

            TMpage TMpageobj = new TMpage();
            TMpageobj.EditTM(mydriver,"Aarna","Aanav","Pinal");
        }
        [Test, Order (3)]
        public void DeleteTM_Test()
        { 
            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTMpage(mydriver);
        
            // Delete Tm
            TMpage TMpageobj = new TMpage();
            TMpageobj.DeleteTM(mydriver);

        }
        
    }
}