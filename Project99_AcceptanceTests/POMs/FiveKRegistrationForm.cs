using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Project99_AcceptanceTests.POMs
{
    public class FiveKRegistrationForm : FiveKRegistration
    {

        #region Constructors / Init
        public FiveKRegistrationForm(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Overloaded constructor to bring up form upon entering the baseURL
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="registrationType"></param>
        public FiveKRegistrationForm(IWebDriver driver, RegistrationTypes registrationType) :
            base(driver)
        {
            this.NavigateToBaseURL();
            this.SelectRegistrationType(registrationType);
        }
        #endregion

        #region Page Objects

        public IWebElement txtFirstName => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtLastName => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement radIAmStudent => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement radIAmNotAStudent => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtSchoolNameAndGrade => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtAddress1 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtAddress => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtCity => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtState => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtZip => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtCountry => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtPhonePt1 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtPhonePt2 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtPhonePt3 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmail => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtDOBPt1 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtDOBPt2 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtDOBPt3 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement selectSex => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement selectTShirtSize => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement selectMEAMember => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement chkFirstResponder => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmergencyFirstName => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmergencyLastName => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmergencyPhonePt1 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmergencyPhonePt2 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement txtEmergencyPhonePt3 => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement selectDonateExtra => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement chkAcceptTerms => Driver.FindElement(
            By.CssSelector(""));

        public IWebElement btnFormAddToCart => Driver.FindElement(
            By.CssSelector(""));

        #endregion

        #region Page Interactions

        #endregion
    }
}
