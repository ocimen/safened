using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data.Repository
{
    public interface IBankAccountRepository : IRepository<BankAccount>
    {
        BankAccount GetById(Guid id);


        List<BankAccount> GetBankAccountListByUser(Guid userId);

        bool Delete(Guid id);
    }
}
