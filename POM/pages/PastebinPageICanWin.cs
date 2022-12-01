using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.pages
{
    class PastebinPageICanWin : Page
    {
        public PastebinPageICanWin(IWebDriver driver) : base(driver)
        {

        }

        public PastebinPageICanWin EnterSendKeyHello()
        {
            driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            return new PastebinPageICanWin(driver);
        }

        public PastebinPageICanWin EnterTenMin()
        {
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            return new PastebinPageICanWin(driver);
        }

        public PastebinPageICanWin EnterSendKeyWeb()
        {
            driver.FindElement(By.Id("postform-name")).SendKeys("helloweb");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            return new PastebinPageICanWin(driver);
        }
    }
}
