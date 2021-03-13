using System;
using System.Collections.Generic;
using System.Text;

namespace SafenedAPI.Domain
{
    public class BankAccount
    {
        public Guid Id { get; set; }

        public Guid BankId { get; set; }

        public Guid UserId { get; set; }

        public decimal Balance { get; set; }
    }
}
