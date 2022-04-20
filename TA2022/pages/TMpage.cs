using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TA2022.Utilities;


namespace TA2022.pages
{
    internal class TMpage
    {
        public void CreateTM(IWebDriver mydriver)
        {
                                  
                     
                             
            
            // create Time and Material record




            //  Click on create a new Button

            IWebElement createNewbutton = mydriver.FindElement(By.XPath("//*[@id='container']/p/a"));

            createNewbutton.Click();

            // select Mterial  from Typecode Dropedown

            IWebElement typeCodeDropdown = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement mateiralOption = mydriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            mateiralOption.Click();     
              

            // identify the code textbox and input a code

            IWebElement codeTextBox = mydriver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Test2022");

            // Identify the discription textbox and input discription

            IWebElement discriptionTextBox = mydriver.FindElement(By.Id("Description"));
            discriptionTextBox.SendKeys("Test2022");

            // Identify the price textbox and input a price

            IWebElement pricetag = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricetag.Click();

            IWebElement priceTextBox = mydriver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("1310");

            // Click on Save button

            IWebElement saveButton = mydriver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            //Thread.Sleep(5000);

            Wait.WaitToBeVisible(mydriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5); 

            //Click on go to last page button

            IWebElement lastpageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
           
            
            Thread.Sleep(5000);

            //Check if record create present in the table and expected value
            IWebElement actualCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            // option 1

            Assert.That(actualCode.Text == "Test2022", "ActualCode and expected code not match");

            // option 2
            //if (actualCode.Text == "Test2022")
            // {
            // Assert.Pass("Materiral record created successfully, test passed.");
            // }
            // else
            //{
            //   Assert.Fail("Teat Failed"); 
            // }
        }

        public void EditTM(IWebDriver mydriver)
        {

        }

        public void DeleteTM(IWebDriver mydriver)
        {

        }
    }

    
}
