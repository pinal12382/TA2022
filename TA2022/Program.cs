using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TA2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open the crome browser

            IWebDriver mydriver = new ChromeDriver();
            
            mydriver.Manage().Window.Maximize();


            // launch turnal porter

            mydriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter the valid username

            IWebElement usernameTextbox = mydriver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");



            // identify password textbow and enter the valid password

            IWebElement passwordTextbox = mydriver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on login buttom

            IWebElement loginButton = mydriver.FindElement(By.XPath( "//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();



            // check if user is logged in sucessfully

            IWebElement helloHari = mydriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in sucessfully,test passed");

            }
            else
            {
                Console.WriteLine("Loginin failed, test failed.");
            }
            // create Time and Material record


            // Go to TM page 

            IWebElement administrationDropedown = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropedown.Click();

            IWebElement tmOption = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));

            tmOption.Click();

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
            Thread.Sleep(1000);

            //Click on go to last page button

            IWebElement lastPageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);

            //Check if record create present in the table and expected value
            IWebElement actualCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode.Text == "Test2022")
            {
                Console.WriteLine("Materiral record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Teat Failed");
            }
        }
    }
}
