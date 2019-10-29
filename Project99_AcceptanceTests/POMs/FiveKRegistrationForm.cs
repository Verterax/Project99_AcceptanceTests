using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

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
            Thread.Sleep(1000);
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
            throw new NotImplementedException();
        }

        #endregion
    }
}
