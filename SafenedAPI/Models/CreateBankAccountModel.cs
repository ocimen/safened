using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SafenedAPI.Models
{
    public class CreateBankAccountModel
    {
        public Guid BankId { get; set; }
        public Guid UserId { get; set; }
        public decimal Balance { get; set; }
    }
}
