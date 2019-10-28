using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Project99_AcceptanceTests.SeleniumFramework;

namespace Project99_AcceptanceTests.POMs
{
    public class Homepage : POMPage
    {
        public Homepage(IWebDriver driver) : base(driver, "https://www.project99.org/") 
        {
            driver.Navigate().GoToUrl(BaseURL);
        }

        #region Page Objects
        public IWebElement linkLightsForLife => Driver.FindElement(By.CssSelector("#block-yui_3_17_2_1_1570299034310_10326 > div > h2 > a"));

        #endregion

        #region Page Interaction

        public LightsForLife ClickLightsForLifeLink()
        {
            IWebElement link = linkLightsForLife;

            link.ScrollToElement(Driver);
            link.Click();

            return new LightsForLife(Driver);
        }

        #endregion
    }
}
