using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using Project99_AcceptanceTests.SeleniumFramework;

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
            Thread.Sleep(1000); // Wait for form to render.
        }

        #endregion

        #region Page Objects

        public IWebElement txtFirstName => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[1]/div[2]/label/input"));

        public IWebElement txtLastName => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[1]/div[3]/label/input"));

        public IWebElement chkIAmStudent => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[1]/div[2]/label/input"));

        public IWebElement chkIAmNotAStudent => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[1]/div[3]/label/input"));

        public IWebElement txtSchoolNameAndGrade => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[2]/input"));

        public IWebElement txtAddress1 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[2]/label/input"));

        public IWebElement txtAddress2 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[3]/label/input"));

        public IWebElement txtCity => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[4]/label/input"));

        public IWebElement txtState => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[5]/label/input"));

        public IWebElement txtZip => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[6]/label/input"));

        public IWebElement txtCountry => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[2]/div[7]/label/input"));

        public IWebElement txtPhonePt1 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[3]/div[2]/label/input"));

        public IWebElement txtPhonePt2 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[3]/div[3]/label/input"));

        public IWebElement txtPhonePt3 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[3]/div[4]/label/input"));

        public IWebElement txtEmail => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[3]/input"));

        public IWebElement txtDOBPt1 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[4]/div[2]/label/input"));

        public IWebElement txtDOBPt2 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[4]/div[3]/label/input"));

        public IWebElement txtDOBPt3 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[4]/div[4]/label/input"));

        public IWebElement selectSex => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[4]/select"));

        public IWebElement selectTShirtSize => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[5]/select"));

        public IWebElement selectMEAMember => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[6]/select"));

        public IWebElement chkFirstResponder => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[7]/div[3]/label/input"));

        public IWebElement txtEmergencyFirstName => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[5]/div[3]/label/input"));

        public IWebElement txtEmergencyLastName => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[5]/div[4]/label/input"));

        public IWebElement txtEmergencyPhonePt1 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[6]/div[3]/label/input"));

        public IWebElement txtEmergencyPhonePt2 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[6]/div[4]/label/input"));

        public IWebElement txtEmergencyPhonePt3 => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/fieldset[6]/div[5]/label/input"));

        public IWebElement selectDonateExtra => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[8]/select"));

        public IWebElement chkAcceptTerms => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[9]/div[3]/label/input"));

        public IWebElement txtAge => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[10]/input"));

        public IWebElement selectRaceAwardCategory => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[1]/div[11]/select"));

        public IWebElement btnFormAddToCart => Driver.FindElement(
            By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div/div/div[2]/form/div[2]/input"));

        #endregion

        #region Page Interactions

        public void FillWithData(RegistrationData data)
        {
            this.txtFirstName.SendKeys(data.FirstName);
            this.txtLastName.SendKeys(data.LastName);

            if (data.IAmAStudent)
                this.chkIAmStudent.Click();
            if (data.IAmNotAStudent)
                this.chkIAmNotAStudent.Click();

            this.txtSchoolNameAndGrade.SendKeys(data.SchoolNameAndGrade);

            this.txtAddress1.SendKeys(data.Address1);
            this.txtAddress2.SendKeys(data.Address2);
            this.txtCity.SendKeys(data.City);
            this.txtState.SendKeys(data.State);
            this.txtZip.SendKeys(data.Zip);
            this.txtCountry.SendKeys(data.Country);

            this.txtPhonePt1.ScrollToElement(Driver);

            this.SetTriplet(data.Phone, txtPhonePt1, txtPhonePt2, txtPhonePt3);

            this.txtEmail.SendKeys(data.Email);

            this.SetTriplet(data.DOB, txtDOBPt1, txtDOBPt2, txtDOBPt3);

            this.selectSex.SelectDropdownItem((int)data.Sex);

            this.selectTShirtSize.SelectDropdownItem((int)data.TShirtSize);

            if (data.FirstResponder)
                this.chkFirstResponder.Click();

            this.txtEmergencyFirstName.SendKeys(data.EmergencyFirstName);
            this.txtEmergencyLastName.SendKeys(data.EmergencyLastName);

            this.txtEmergencyPhonePt1.ScrollToElement(Driver);

            this.SetTriplet(data.EmergencyPhoneNumber, txtEmergencyPhonePt1, txtEmergencyPhonePt2, txtEmergencyPhonePt3);

            this.selectDonateExtra.SelectDropdownItem((int)data.DonateExtra);

            if (data.AcceptTerms)
                this.chkAcceptTerms.Click();
        }

        /// <summary>
        /// Helper Method for setting controls like Dates and Phone numbers on SquareSpace forms.
        /// </summary>
        /// <param name="s">The string to split. Strings must use a single delimiting char such as a '-'
        /// <param name="c1">The first control.</param>
        /// <param name="c2">The second control.</param>
        /// <param name="c3">The third control.</param>
        private void SetTriplet(string s, IWebElement c1, IWebElement c2, IWebElement c3)
        {
            char delimiter = s.Where(c => !char.IsDigit(c)).FirstOrDefault();
            string[] sections = s.Split(delimiter);

            if (sections.Length != 3)
                throw new Exception(string.Format("The value {0} is not a valid triplet format.", s));

            c1.SendKeys(sections[0]);
            c2.SendKeys(sections[1]);
            c3.SendKeys(sections[2]);
        }

        /// <summary>
        /// Gets a single string value from a trio of controls comprising a date or phone number.
        /// </summary>
        /// <param name="c1">The first control.</param>
        /// <param name="c2">The second control.</param>
        /// <param name="c3">The third control.</param>
        /// <returns>Returns the strings as a single value delimited with two '-' characters. </returns>
        private string GetTriplet(IWebElement c1, IWebElement c2, IWebElement c3)
        {
            return string.Format("{0}-{1}-{2}",
                c1.GetAttribute("value"),
                c2.GetAttribute("value"),
                c3.GetAttribute("value"));
        }

        #endregion
    }
}
