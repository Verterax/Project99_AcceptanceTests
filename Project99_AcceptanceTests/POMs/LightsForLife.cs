using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Project99_AcceptanceTests.SeleniumFramework;

namespace Project99_AcceptanceTests.POMs
{
    class LightsForLife : POMPage
    {
        public LightsForLife(IWebDriver driver) : base(driver, "https://www.project99.org/lightsforlife") { }

        #region Page Objects
        public IWebElement linkTo5KRegistration => Driver.FindElement(By.CssSelector("#block-yui_3_17_2_1_1544307695751_14668 > div > h2:nth-child(3) > a"));

        #endregion

        #region Page Interaction
        public FiveKRegistration Click5KLink()
        {
            IWebElement link = linkTo5KRegistration;
            link.ScrollToElement(Driver);

            link.Click();

            return new FiveKRegistration(Driver);            
        }

        #endregion
    }
}
