using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using Project99_AcceptanceTests;
using Project99_AcceptanceTests.SeleniumFramework;
using Project99_AcceptanceTests.POMs;


namespace Project99Tests
{
    public class Tests
    {
        [Test]
        public void Can_Navigate_To_5K_Signup_Page_From_Homepage()
        {
            IWebDriver driver = WebDrivers.Current;

            Homepage pageHome = new Homepage(driver);
            Assert.AreEqual(pageHome.BaseURL, driver.Url);

            LightsForLife pageLights = pageHome.ClickLightsForLifeLink();
            Assert.AreEqual(pageLights.BaseURL, driver.Url);

            FiveKRegistration page5K = pageLights.Click5KLink();
            Assert.AreEqual(page5K.BaseURL, driver.Url);
        }

        [Test]
        public void Can_See_And_Click_Shopping_Cart_Button()
        {
            IWebDriver driver = WebDrivers.Current;

            FiveKRegistration page5K = new FiveKRegistration(driver);
            page5K.NavigateToBaseURL();

            IWebElement cartLink = page5K.linkViewCart;
            Assert.IsTrue(cartLink.IsInteractive());
        }

        [Test]
        public void Age_Is_Correct_Given_DOB()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Race_Category_Is_Correct_Given_DOB_And_FirstResponder_Status()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void The_Donate_Extra_Dropdown_Adds_Donation_Item_To_Cart()
        {
            throw new NotImplementedException();
        }
    }
}