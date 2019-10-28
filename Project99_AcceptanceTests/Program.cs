using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using Project99_AcceptanceTests.POMs;
using Project99_AcceptanceTests.SeleniumFramework;


namespace Project99_AcceptanceTests
{
    class Program
    {
        static void Main()
        {           
            IWebDriver driver = WebDrivers.Current;

            FiveKRegistration page5K = new FiveKRegistration(driver);
            page5K.NavigateToBaseURL();

            page5K.SelectRegistrationType(RegistrationTypes.Adult);

            //Assert.IsTrue(page5K.linkViewCart.IsInteractive);


            //Assert.AreEqual(page5K.BaseURL, driver.Url);
        }
   
    }
}
