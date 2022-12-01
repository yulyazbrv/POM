using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.pages
{
    class AppleHomePage : Page
    {
       
        public AppleHomePage(IWebDriver driver) : base(driver)
        {

        }

        public AppleHomePage EnterToIphonePage()
        {
            driver.FindElement(By.XPath("/html/body/nav/div/ul[2]/li[5]/a")).Click();
            return new AppleHomePage(driver);
        }

        public AppleHomePage EnterToLearnMorePage()
        {
            driver.FindElement(By.XPath("//*[@id=\"main\"]/section[1]/div[1]/div[1]/div/div[1]/ul/li[2]/a/span[1]")).Click();
            return new AppleHomePage(driver);
        }
    }
}
