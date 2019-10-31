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
using System.Threading;


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
            form5K.HideBG();

            DateTime today = DateTime.Parse(Project99Variables.DATE_OF_5K);
            driver.ConsoleLog("today = {0}", today.ToString());

            int yearsRange = 80;
            bool neg = true;
            for (int i = yearsRange; i > 3; i-=3)
            {                     
                // Every other iteration adds or subtracts one day about today's date.
                DateTime mockBirthday = today.AddYears(-i).AddDays((neg = !neg) ? -1 : 1);
            
                driver.ConsoleLog("bday = {0}", mockBirthday.ToString());

                int age = CalcAge(today, mockBirthday);

                //form5K.txtDOBPt1.ScrollToElement(driver);
                form5K.SetDOB(mockBirthday.ToShortDateString());

                //form5K.txtAge.ScrollToElement(driver);
                string strAge = form5K.txtAge.GetValue();
                int formAge = int.Parse(strAge);          

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
            IWebDriver driver = WebDrivers.Current;
            FiveKRegistrationForm form5K = new FiveKRegistrationForm(driver, RegistrationTypes.Student);
            form5K.HideBG();

            DateTime today = DateTime.Parse(Project99Variables.DATE_OF_5K);
            List<int> testAges = new List<int>(new int[] { 5, 10, 11, 17, 18, 50 });

            foreach(int age in testAges)
            {
                DateTime bday = today.AddYears(-age);
                form5K.SetDOB(bday.ToShortDateString());

                IWebElement selectedItem = form5K.selectRaceAwardCategory;

                // Check that age group is correct.
                RaceAwardCategories actualCategory = (RaceAwardCategories)int.Parse(selectedItem.GetAttribute("selectedIndex"));
                RaceAwardCategories expectedCategory = ExpectedCategoryForAge(age, false);
                Assert.AreEqual(expectedCategory, actualCategory);

                // See that First responder overrrides age.
                form5K.chkFirstResponder.Click();
                actualCategory = (RaceAwardCategories)int.Parse(selectedItem.GetAttribute("selectedIndex"));
                Assert.AreEqual(RaceAwardCategories.FirstResponder, actualCategory);

                // Reset First Responder Checkbox
                form5K.chkFirstResponder.Click();
            }
        }

        private RaceAwardCategories ExpectedCategoryForAge(int age, bool isFirstResponder)
        {
            if (isFirstResponder)
                return RaceAwardCategories.FirstResponder;

            if (age <= 10) return RaceAwardCategories._10AndUnder;
            if (age <= 17) return RaceAwardCategories._17AndUnder;

            return RaceAwardCategories._18AndOver;
        }


        [Test]
        public void The_Donate_Extra_Dropdown_Adds_Donation_Item_To_Cart()
        {
            IWebDriver driver = WebDrivers.Current;
            FiveKRegistrationForm form5K = new FiveKRegistrationForm(driver, RegistrationTypes.Student);
            RegistrationData data = new RegistrationData(true);
            data.DonateExtra = DonateExtraOptions._100;
            form5K.FillWithData(data);

            form5K.btnFormAddToCart.Click();
            Thread.Sleep(1500);

            form5K.linkViewCart.ScrollToElement(driver);
            form5K.linkViewCart.Click();


        }
    }
}