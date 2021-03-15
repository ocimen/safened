using System;

namespace SafenedAPI.Domain
{
    public class BankAccount : BaseEntity
    {
        public Guid BankId { get; set; }

        public virtual Bank Bank { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public decimal Balance { get; set; }
    }
}
