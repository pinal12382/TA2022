using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2022.pages
{
    internal class LoginPage
    {
        public void loginSteps(IWebDriver mydriver)
        {


            // launch turnal porter

            mydriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                //identify username textbox and enter the valid username

                IWebElement usernameTextbox = mydriver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");



                // identify password textbow and enter the valid password

                IWebElement passwordTextbox = mydriver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                // click on login buttom

                IWebElement loginButton = mydriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal login page did not launch", ex.Message);

                throw;
            }


            


            

            



            // check if user is logged in sucessfully

            IWebElement helloHari = mydriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

           
        }
    }
}
