using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data.Repository
{
    public class BankRepository : Repository<Bank>, IBankRepository
    {
        public BankRepository(SafenedContext safenedContext) : base(safenedContext)
        {
        }
    }
}
