using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Project99_AcceptanceTests.SeleniumFramework;

namespace Project99_AcceptanceTests.POMs
{


    public class FiveKRegistration : POMPage
    {
        public FiveKRegistration(IWebDriver driver) : 
            base(driver, "https://www.project99.org/5kregistration/test-5k-lights-for-life-registration-bk779") { }

        #region Page Objects

        public IWebElement linkViewCart => Driver.FindElement(
            By.CssSelector("#productDetails > div.sqs-add-to-cart-button-wrapper > a"));

        public IWebElement selectRegistrationType => Driver.FindElement(
            By.CssSelector("#productDetails > div.product-variants > div > div.variant-select-wrapper > select"));

        public IWebElement linkAddToCart => Driver.FindElement(
            By.XPath("/html/body/div[3]/main/div/div/div[2]/div[2]/div[4]/div"));

        #endregion

        #region Interaction

        /// <summary>
        /// Select the registration type, and get the affiliated registration form.
        /// </summary>
        /// <param name="registrationType"></param>
        /// <returns>Returns 5KRegistration Form unless RegistrationType is "None"</returns>
        public FiveKRegistrationForm SelectRegistrationType(RegistrationTypes registrationType)
        {
            selectRegistrationType.SelectDropdownItem((int)registrationType);

            if (registrationType != RegistrationTypes.None)
            {
                linkAddToCart.ScrollToElement(Driver);
                linkAddToCart.Click();

                return new FiveKRegistrationForm(Driver);
            }
            else
                return null;
            
        }

        #endregion
    }
}
