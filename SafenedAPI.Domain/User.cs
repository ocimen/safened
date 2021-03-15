using System;

namespace SafenedAPI.Domain
{
    public class User : BaseEntity
    {
        //public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Bsn { get; set; }
    }
}
