﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafenedAPI.Domain
{
    public class BankAccount : BaseEntity
    {
        //public Guid Id { get; set; }

        public Guid BankId { get; set; }

        public Guid UserId { get; set; }

        public decimal Balance { get; set; }
    }
}
