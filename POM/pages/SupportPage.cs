using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.pages
{
    class SupportPage : Page
    {
        public SupportPage(IWebDriver driver) : base(driver)
        {

        }

        public SupportPage EnterToStorePage()
        {
            driver.FindElement(By.XPath("//*[@id=\"ac-globalnav\"]/div/ul[2]/li[2]/a")).Click();
            return new SupportPage(driver);
        }

        public SupportPage EnterToAskPage()
        {
            driver.FindElement(By.XPath("//*[@id=\"generic-2\"]/div[1]/div/div[2]/div[2]/a")).Click();
            return new SupportPage(driver);
        }
    }
}
