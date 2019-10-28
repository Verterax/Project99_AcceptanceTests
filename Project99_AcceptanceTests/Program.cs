using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Project99_AcceptanceTests.POMs;
using Project99_AcceptanceTests.SeleniumFramework;


namespace Project99_AcceptanceTests
{
    class Program
    {
        static void Main()
        {
            IWebDriver driver = WebDrivers.Current;

            Homepage pageHome = new Homepage(driver);
            //Assert.AreEqual(pageHome.BaseURL, driver.Url);

            LightsForLife pageLights = pageHome.ClickLightsForLifeLink();
            //Assert.AreEqual(pageLights.BaseURL, driver.Url);

            FiveKRegistration page5K = pageLights.Click5KLink();
            //Assert.AreEqual(page5K.BaseURL, driver.Url);
        }
   
    }
}
