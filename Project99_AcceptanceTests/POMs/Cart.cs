using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using Project99_AcceptanceTests.SeleniumFramework;
using OpenQA.Selenium.Support.UI;

namespace Project99_AcceptanceTests.POMs
{
    public class Cart : POMPage
    {
        #region Constructors / Init
        public Cart(IWebDriver driver) : base(driver, "https://www.project99.org/cart") { }

        #endregion

        #region Page Objects

        public IWebElement objRegistrationItem => Driver.FindElement(
            By.XPath("/html/body/div[3]/main/div/div/div/div/div[1]/div[2]"));

        public IWebElement objDonationItem => Driver.FindElement(
            By.XPath("/html/body/div[3]/main/div/div/div/div/div[1]/div[3]"));

        public IWebElement linkEditRegistration => Driver.FindElement(
            By.XPath("/html/body/div[3]/main/div/div/div/div/div[1]/div[2]/div[3]/div[3]/span/span"));

        public IWebElement btnCheckout => Driver.FindElement(
            By.XPath("html/body/div[3]/main/div/div/div/div/div[2]/button"));

        public IWebElement btnClose5KFormModal => Driver.FindElement(
            By.XPath("/html/body/div[3]/main/div/div/div/div/div[3]/div/div[1]"));

        // modal close button 

        #endregion

        #region Page Interactions

        public DonateExtraOptions GetDonateExtraOption()
        {
            linkEditRegistration.Click();
            Thread.Sleep(1000);
            IWebElement selectDonatExtra = Driver.FindElement(
                By.XPath("/html/body/div[3]/main/div/div/div/div/div[3]/div/div[2]/div/div/div/div/div/div/div/div[2]/form/div[1]/div[8]/select"));

            DonateExtraOptions selectedOption = (DonateExtraOptions)selectDonatExtra.GetSelectedIndex();
            btnClose5KFormModal.Click();

            return selectedOption;
        }

        #endregion
    }
}
