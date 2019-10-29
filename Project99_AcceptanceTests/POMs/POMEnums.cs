using System;
using System.Collections.Generic;
using System.Text;

namespace Project99_AcceptanceTests.POMs
{

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

}
