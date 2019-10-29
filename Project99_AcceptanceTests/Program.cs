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

            //Age_Is_Correct_Given_DOB()
            IWebDriver driver = WebDrivers.Current;


            FiveKRegistrationForm form5K = new FiveKRegistrationForm(driver, RegistrationTypes.Student);

            RegistrationData data = new RegistrationData(true);

            form5K.FillWithData(data);

            //Assert.AreEqual(page5K.BaseURL, driver.Url);
        }
   
    }
}
