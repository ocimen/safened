using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data.Repository
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(SafenedContext customerContext) : base(customerContext)
        {
        }

        public BankAccount GetById(Guid id)
        {
            return SafenedContext.BankAccount.FirstOrDefault(a => a.Id == id);
        }

        public List<BankAccount> GetBankAccountListByUser(Guid userId)
        {
            var accountList = SafenedContext.BankAccount.Where(a => a.UserId == userId).ToList();
            return accountList;
        }

        public bool Delete(Guid id)
        {
            var account = SafenedContext.BankAccount.FirstOrDefault(a => a.Id == id);

            if (account != null)
            {
                SafenedContext.BankAccount.Remove(account);
                return SafenedContext.SaveChanges() > 0;
            }

            return false;
        }
    }
}
