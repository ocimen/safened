using System;
using System.ComponentModel.DataAnnotations;

namespace SafenedAPI.Models
{
    public class TransactionModel
    {
        [Required]
        public Guid SenderId { get; set; }

        [Required]
        public Guid ReceiverId { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
