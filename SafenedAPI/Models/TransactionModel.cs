using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafenedAPI.Models
{
    public class TransactionModel
    {
        public Guid senderId { get; set; }
        public Guid receiverId { get; set; }

        public decimal Amount { get; set; }
    }
}
