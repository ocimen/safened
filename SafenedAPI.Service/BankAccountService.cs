using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Data.Repository;
using SafenedAPI.Domain;

namespace SafenedAPI.Service
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository bankAccountRepository;

        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
        }

        public List<BankAccount> GetBankAccountListByUser(Guid userId)
        {
            //TODO: Add automapper to return dto instead of domain object
            var bankAccountList = bankAccountRepository.GetBankAccountListByUser(userId);
            return bankAccountList;
        }

        public bool Delete(Guid id)
        {
            var result = bankAccountRepository.Delete(id);
            return result;
        }
    }
}
