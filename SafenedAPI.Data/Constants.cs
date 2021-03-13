using System;

namespace SafenedAPI.Data
{
    public static class Constants
    {
        // Users
        public static Guid User1 = Guid.Parse("C0944D4C-F653-44EA-98BD-2E97A7F11FBF");
        public static Guid User2 = Guid.Parse("C4F29778-F8A4-46D6-AA1D-54D0A0E4A642");
        public static Guid User3 = Guid.Parse("CA47D9FD-D549-4D7B-9689-D4E61F08E67A");

        // Banks
        public static Guid ING = Guid.Parse("BCC33985-93EB-479F-8C54-AE8DE1DC623B");
        public static Guid ABN = Guid.Parse("063F6B8C-99E6-463F-9C0B-69FBEDE7C813");
        public static Guid Rabobank = Guid.Parse("A9124851-B14E-4268-9C7B-FA46F23140C0");


        // Bank Accounts

        public static Guid User_1_ING_Account = Guid.Parse("060D75B9-C9E3-4677-9F6F-7AB93728EDAB");
        public static Guid User_1_ABN_Account = Guid.Parse("DBD78C5B-2FED-4705-AD5A-D6ED48C0DF2B");
        public static Guid User2_Rabobank_Account = Guid.Parse("B7AD631E-58EC-431D-BDEA-5CBE9F521894");
    }
}
