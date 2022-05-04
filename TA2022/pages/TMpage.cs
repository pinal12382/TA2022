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
            Thread.Sleep(5000);

            

            IWebElement materailOption = mydriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materailOption.Click();

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
            priceTextBox.SendKeys("$1,310.00");

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


            // option 1


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

        public string GetCode(IWebDriver mydriver)
        {
            IWebElement actualCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }
        public string GetTypeCode(IWebDriver mydriver)
        {
            IWebElement actualTypecode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return actualTypecode.Text;
        }
        public string GetDescription(IWebDriver mydriver)
        {
            IWebElement actualDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }
        public string GetPrice(IWebDriver mydriver)
        {
            IWebElement actualPrice = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }

        public void EditTM(IWebDriver mydriver,string description,string code,string price)
        {
            // Wait untill entire TM page will display
            Wait.WaitToBeVisible(mydriver,"XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]",5);

            //Click on go to last page button

            IWebElement lastpageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(5000);


           // Click on edit button
             IWebElement editButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            // Edit code
            IWebElement codeTextbox = mydriver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys(code);

            // Edit description
            IWebElement descriptionTextbox = mydriver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(description);

            // Edit price
            IWebElement priceTag = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = mydriver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys(price);

            // Click on save button
            IWebElement saveButton = mydriver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeVisible(mydriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);

            // Click on go to last page button
            IWebElement goToLastPageButton1 = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(5000);

            //Assertion

            //IWebElement createdCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement createdTypeCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement createdDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement createdPrice = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assert.That(createdCode.Text == "EditedTestl2022", "Code record hasn't been edited.");
            //Assert.That(createdTypeCode.Text == "M", "TypeCode record hasn't been edited.");
            //Assert.That(createdDescription.Text == "EditedTest2022", "Description record hasn't been edited.");
            //Assert.That(createdPrice.Text == "$1,310.00", "Price record hasn't been edited.");


        }
        public string GetEditedDescription(IWebDriver mydriver)
            {
            IWebElement createdDescription = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;

        }
        public string GetEditedcode(IWebDriver mydriver)
        {
            IWebElement createdCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdCode.Text;
            
        }
        public string GetEditedprice(IWebDriver mydriver)
        {
            IWebElement createdPrice = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return createdPrice.Text;
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
