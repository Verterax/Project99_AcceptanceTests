using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Project99_AcceptanceTests.POMs
{
    class FiveKRegistration : POMPage
    {
        public FiveKRegistration(IWebDriver driver) : base(driver) { }

        #region Page Objects

        public IWebElement linkViewCart => Driver.FindElement(
            By.CssSelector("#productDetails > div.sqs-add-to-cart-button-wrapper > a"));

        public IWebElement selectRegistrationType => Driver.FindElement(
            By.CssSelector("#productDetails > div.product-variants > div > div.variant-select-wrapper > select"));

        public IWebElement linkAddToCart => Driver.FindElement(
            By.CssSelector("#yui_3_17_2_1_1572222377354_179"));

        #endregion

        #region Interaction

        #endregion
    }
}
