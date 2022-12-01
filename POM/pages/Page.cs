using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.pages
{
    class Page
    {
        protected IWebDriver driver;
        protected const int WAIT_TIMEOUT_SECONDS = 30;

        protected Page(IWebDriver driver_)
        {
            this.driver = driver_;           
        }

        protected void WaitLoadedPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_TIMEOUT_SECONDS);
        }
    }
}
