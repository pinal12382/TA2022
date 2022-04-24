using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2022.Utilities
{
    internal class Wait
    {
        public static void WaitToBeClickable(IWebDriver mydriver,string locator, string locatorValue, int second)
        {
            var Wait = new WebDriverWait(mydriver, new TimeSpan(0,0,second));
            if(locator == "XPath")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));

            }
            if (locator == "CssSelector")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            }



       

         
        }
        public static void WaitToBeVisible(IWebDriver mydriver, string locator, string locatorValue, int second)
        {
            var Wait = new WebDriverWait(mydriver, new TimeSpan(0, 0, second));
            if (locator == "XPath")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));

            }
            if (locator == "CssSelector")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));

            }






        }
    }
}
