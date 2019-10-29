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

            form5K.txtFirstName.SendKeys("Christopher");
            form5K.txtLastName.SendKeys("Caldwell");

            form5K.chkIAmStudent.Click();
            form5K.chkIAmNotAStudent.Click();
            form5K.txtSchoolNameAndGrade.SendKeys("Tovashal Middleschool 500th Grade");

            form5K.txtAddress1.SendKeys("100 Zane Grey Lane.");
            form5K.txtAddress2.SendKeys("Unit Boo");
            form5K.txtCity.SendKeys("Rockettown");
            form5K.txtState.SendKeys("Arizona");
            form5K.txtZip.SendKeys("86335");
            form5K.txtCountry.SendKeys("Khazackstan");

            form5K.txtPhonePt1.ScrollToElement(driver);
            form5K.txtPhonePt1.SendKeys("951");
            form5K.txtPhonePt2.SendKeys("310");
            form5K.txtPhonePt3.SendKeys("2533");

            form5K.txtEmail.SendKeys("chris@codehadouken.com");

            form5K.txtDOBPt1.SendKeys("10");
            form5K.txtDOBPt2.SendKeys("01");
            form5K.txtDOBPt3.SendKeys("1982");

            form5K.selectSex.SelectDropdownItem(1);

            form5K.selectTShirtSize.SelectDropdownItem(6);

            form5K.chkFirstResponder.Click();

            form5K.txtEmergencyFirstName.SendKeys("Cassie");
            form5K.txtEmergencyLastName.SendKeys("Caldwell");

            form5K.txtEmergencyPhonePt1.ScrollToElement(driver);
            form5K.txtEmergencyPhonePt1.SendKeys("310");
            form5K.txtEmergencyPhonePt2.SendKeys("938");
            form5K.txtEmergencyPhonePt3.SendKeys("3567");

            form5K.selectDonateExtra.SelectDropdownItem(7);

            form5K.chkAcceptTerms.Click();


            //Assert.AreEqual(page5K.BaseURL, driver.Url);
        }
   
    }
}
