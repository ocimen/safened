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
        private readonly IBankRepository bankRepository;

        public BankAccountService(IBankAccountRepository bankAccountRepository, IBankRepository bankRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.bankRepository = bankRepository;
        }

        public async Task<bool> CreateAccount(Guid userId, Guid bankId, decimal balance)
        {
            var bank = bankRepository.GetById(bankId);
            if (bank != null)
            {
                var bankAccount = await bankAccountRepository.AddAsync(new BankAccount
                {
                    Id = Guid.NewGuid(),
                    BankId = bankId,
                    UserId = userId,
                    Balance = balance
                });

                return bankAccount != null;
            }

            return false;
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
