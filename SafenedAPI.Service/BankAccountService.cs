using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SafenedAPI.Data.Repository;
using SafenedAPI.Domain;
using SafenedAPI.Service.Models;

namespace SafenedAPI.Service
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository bankAccountRepository;
        private readonly IBankRepository bankRepository;
        private readonly IMapper _mapper;

        public BankAccountService(IBankAccountRepository bankAccountRepository, IBankRepository bankRepository, IMapper mapper)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.bankRepository = bankRepository;
            _mapper = mapper;
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

        public List<BankAccountModel> GetBankAccountListByUser(Guid userId)
        {
            var bankAccountList = bankAccountRepository.GetBankAccountListByUser(userId);
            var result = _mapper.Map<List<BankAccountModel>>(bankAccountList);
            return result;
        }

        public bool Delete(Guid id)
        {
            var result = bankAccountRepository.Delete(id);
            return result;
        }
    }
}
