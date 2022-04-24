using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA2022.Utilities;

namespace TA2022.pages
{
    internal class Homepage
    {
        public void GotoTMpage(IWebDriver mydriver)
        {
            // Go to TM page 

            IWebElement administrationDropedown = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropedown.Click();


            Wait.WaitToBeClickable(mydriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);


            IWebElement tmOption = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));

            tmOption.Click();
        }

        public void GOtoEmployeePage(IWebDriver mydriver)
        {

        }

    }
}
