using System;
using System.Collections.Generic;
using System.Text;

namespace Project99_AcceptanceTests.POMs
{

    public class RegistrationData
    {

        #region Init / Constructors
        private void InitDefaults() 
        {
            this.FirstName = "Christopher";
            this.LastName = "Caldwell";

            this.IAmAStudent = true;
            this.IAmNotAStudent = true;

            this.SchoolNameAndGrade = "Tovashal Middleschool 500th Grade";

            this.Address1 = "100 Zane Grey Lane.";
            this.Address2 = "Unit Boo";
            this.City = "Rockettown";
            this.State = "Arizona";
            this.Zip = "85563";
            this.Country = "England";

            this.Phone = "951-310-2566";

            this.Email = "me@email.com";

            this.DOB = "10-12-1982";

            this.Sex = GenderOptions.Female;

            this.TShirtSize = TShirtOptions.L_Large;

            this.FirstResponder = false;

            this.EmergencyFirstName = "Steve";
            this.EmergencyLastName = "George";

            this.EmergencyPhoneNumber = "310-938-3566";

            this.DonateExtra = DonateExtraOptions._100;

            this.AcceptTerms = true;
        }

        public RegistrationData(bool useDefaults = true) 
        {
            if (useDefaults)
                InitDefaults();
        }

        #endregion

        #region Data

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IAmAStudent { get; set; }
        public bool IAmNotAStudent { get; set; }

        public string SchoolNameAndGrade { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }
        public string DOB { get; set; }

        public string Phone { get; set; }

        public GenderOptions Sex { get; set; }

        public TShirtOptions TShirtSize { get; set; }

        public bool FirstResponder { get; set; }

        public string EmergencyFirstName { get; set; }
        public string EmergencyLastName { get; set; }

        public string EmergencyPhoneNumber { get; set; }

        public DonateExtraOptions DonateExtra { get; set; }

        public bool AcceptTerms { get; set; }

        #endregion

    }

    /// <summary>
    /// Maps the registration types to the ones found at
    /// https://www.project99.org/5kregistration/test-5k-lights-for-life-registration-bk779
    /// </summary>
    public enum RegistrationTypes
    {
        None = 0,
        Basic = 1,
        Student = 2,
        Adult = 3
    }

    public enum GenderOptions
    {
        Male,
        Female,
        Prefer_Not_To_Share
    }

    public enum TShirtOptions
    {
        None,
        NA_Basic_Registration,
        YM_Youth_Medium,
        YL_Youth_Large,
        S_Small,
        M_Medium,
        L_Large,
        XL_Extra_Large,
        XXL_Extra_Extra_Large,
        XXXL_Extra_Extra_Extra_Large
    }

    public enum MEAOptions
    {
        No,
        Alta_Murrieta_Elementary,
        Antelope_Hills_Elementary,
        Avaxat_Elementary,
        Buchanan_Elementary,
        Cole_Canyon_Elementary,
        E_Hale_Curran_Elementary,
        Lisa_J_Mails_Elementary,
        Monte_Vista_Elementary,
        Murrieta_Elementary,
        Rail_Ranch_Elementary,
        Tovashal_Elementary,
        Dorothy_McElhinney_Middle,
        Shivela_Middle,
        Thompson_Middle,
        Warm_Springs_Middle,
        Murrieta_Mesa_High,
        Murrieta_Valley_High,
        Vista_Murrieta_High_School,
        Murrieta_Canyon_Academy
    }

    public enum DonateExtraOptions
    {
        _0,
        _1,
        _5,
        _10,
        _25,
        _50,
        _100,
        _500
    }

    public enum RaceAwardCategories
    { 
        _10AndUnder,
        _17AndUnder,
        _18AndOver,
        FirstResponder
    }

}
