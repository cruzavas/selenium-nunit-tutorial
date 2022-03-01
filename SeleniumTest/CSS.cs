using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTest
{
	class CSS
	{
		[Test]
		public void CssDemo()
		{
            IWebDriver m_driver;
            m_driver = new ChromeDriver(Properties.Settings.Default.PATH);
			m_driver.Url = "http://demo.guru99.com/test/guru99home/";
			m_driver.Manage().Window.Maximize();
			var link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
			link.Click();
			m_driver.Close();
		}

		[Test]
        public void DataTextBox()
        {
            IWebDriver m_driver;
            m_driver = new ChromeDriver(Properties.Settings.Default.PATH);
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();

        }

        [Test]
        public void DataAndClick()
        {
            IWebDriver m_driver;
            m_driver = new ChromeDriver(Properties.Settings.Default.PATH);
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();

			// Store locator values of email text box and sign up button				
			IWebElement emailTextBox = m_driver.FindElement(By.CssSelector("input[id='philadelphia-field-email']"));
			IWebElement signUpButton = m_driver.FindElement(By.CssSelector("button[id='philadelphia-field-submit']"));
			//IWebElement emailTextBox = m_driver.FindElement(By.CssSelector("#philadelphia-field-email"));
			//IWebElement signUpButton = m_driver.FindElement(By.CssSelector("#philadelphia-field-submit"));

			emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();


        }

        [Test]
        public void SelectDemo()
        {
            IWebDriver m_driver;
            m_driver = new ChromeDriver(Properties.Settings.Default.PATH);
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();

            IWebElement course = m_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("sap-abap");

        }
    }
}
