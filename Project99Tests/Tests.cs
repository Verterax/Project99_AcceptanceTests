using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
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
            IWebDriver driver = WebDrivers.Current;
            FiveKRegistrationForm form5K = new FiveKRegistrationForm(driver, RegistrationTypes.Student);

            DateTime today = DateTime.Parse(Project99Variables.DATE_OF_5K);

            form5K.txtAge.ScrollToElement(driver);

            int yearsRange = 80;
            bool neg = true;
            for (int i = yearsRange; i > 3; i-=3)
            {                     
                // Every other iteration adds or subtracts one day about today's date.
                DateTime mockBirthday = today.AddYears(-i).AddDays((neg = !neg) ? -1 : 1);
                int age = CalcAge(today, mockBirthday);

                form5K.SetDOB(mockBirthday.ToShortDateString());
                int formAge = int.Parse(form5K.txtAge.GetValue());          

                Assert.AreEqual(age, formAge, string.Format("Expected: {0}, Actual: {1}, bday = {2}, today = {3}",
                    age, formAge, mockBirthday.ToShortDateString(), today.ToShortDateString()));

                Console.WriteLine(string.Format("{0} == {1}", age, formAge));
            }
            


        }
        private int CalcAge(DateTime today, DateTime bday)
        {      
            int age = today.Year - bday.Year;
            if (bday.Date > today.AddYears(-age)) age--;
            return age;
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