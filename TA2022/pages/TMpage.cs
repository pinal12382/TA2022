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
            IWebElement actualTypecode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice= mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // option 1

            Assert.That(actualCode.Text == "Test2022", "ActualCode and expected code not match");
            Assert.That(actualTypecode.Text == "M", "Actual type Code and expected type code not match");
            Assert.That(actualDescription.Text == "Test2022", "Actual Descriptin and expected Description not match");
            Assert.That(actualPrice.Text == "$1,310.00", "ActualPrice and expected Price not match");



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
            // Wait untill entire TM page will display
         Wait.WaitToBeVisible(mydriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);

            //Click on go to last page button

            IWebElement lastpageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();

            IWebElement findRecordCreated = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "Test2022")
            {
                // Click on edit button
                IWebElement editButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }
            
            // Edit code
            IWebElement codeTextbox = mydriver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("EditedTest2022");

            // Edit description
            IWebElement descriptionTextbox = mydriver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("EditedTest2022");

            // Edit price
            IWebElement priceTag = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = mydriver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys("1,234.00");

            // Click on save button
            IWebElement saveButton = mydriver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeVisible(mydriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);

            // Click on go to last page button
            IWebElement goToLastPageButton1 = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(5000);

            //Assertion
            IWebElement createdCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement createdTypeCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement createdDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement createdPrice = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(createdCode.Text == "EditedTest2022", "Code record hasn't been edited.");
            Assert.That(createdTypeCode.Text == "M", "TypeCode record hasn't been edited.");
            Assert.That(createdDescription.Text == "EditedTest2022", "Description record hasn't been edited.");
            Assert.That(createdPrice.Text == "$1,234.00", "Price record hasn't been edited.");

                               }

        public void DeleteTM(IWebDriver mydriver)
        {
            // Wait until the entire TM page is displayed
            Wait.WaitToBeVisible(mydriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);

            // Click on go to last page button
            IWebElement goToLastPageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "EditedTest2022")
            {
                // Click on delete button
                IWebElement deleteButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000);

                mydriver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");
            }

            // Assert that Time record has been deleted
            mydriver.Navigate().Refresh();
            Thread.Sleep(5000);

            IWebElement goToLastPageButton1 = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(5000);

            IWebElement editedCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedCode.Text != "EditedTest2022", "Code record hasn't been deleted.");
            Assert.That(editedDescription.Text != "EditedTest2022", "Description record hasn't been deleted.");
            Assert.That(editedPrice.Text != "$1,234.00", "Price record hasn't been deleted.");


        }
    }

    
}
