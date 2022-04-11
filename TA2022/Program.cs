using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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


        }
    }
}
