using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
	class Demo
	{
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(Properties.Settings.Default.PATH);
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
