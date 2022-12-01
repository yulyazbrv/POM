using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.pages;

namespace POM
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LearnMoreTest()
        {
            driver.Url = "https://www.apple.com/";
            AppleHomePage page = new AppleHomePage(driver);
            page.EnterToIphonePage().EnterToLearnMorePage();
        }

        [Test]
        public void AskSpecialistTest()
        {
            driver.Url = "https://www.apple.com/";
            SupportPage page = new SupportPage(driver);
            page.EnterToStorePage().EnterToAskPage();
        }

        [Test]
        public void ICanWin()
        {
            driver.Url = "https://pastebin.com";
            PastebinPageICanWin page = new PastebinPageICanWin(driver);
            page.EnterSendKeyHello().EnterTenMin().EnterSendKeyWeb();
        }

        [Test]
        public void BrightItOn()
        {
            driver.Url = "https://pastebin.com";
            PastebinPageBrightItOn page = new PastebinPageBrightItOn(driver);
            page.EnterPostformText().EnterBash().EnterExpirationContainer().EnterTenMin().EnterSendKeyHowToGain();
            Assert.That(driver.Title, Is.EqualTo("how to gain dominance among developers - Pastebin.com"));
            Assert.IsTrue(page.IsSyntaxHigh());
            Assert.IsTrue(page.IsCodeFirstLine());
            Assert.IsTrue(page.IsCodeSecondLine());
            Assert.IsTrue(page.IsCodeThirdLine());

        }
    }
}