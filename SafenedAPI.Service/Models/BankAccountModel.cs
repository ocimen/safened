using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafenedAPI.Service.Models
{
    public class BankAccountModel
    {
        public string BankName { get; set; }
        public string AccountOwner { get; set; }
        public decimal Balance { get; set; }
    }
}
