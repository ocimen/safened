using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;
using SafenedAPI.Service.Models;

namespace SafenedAPI.Service
{
    public interface IBankAccountService
    {
        Task<bool> CreateAccount(Guid userId, Guid bankId, decimal balance);

        List<BankAccountModel> GetBankAccountListByUser(Guid userId);

        bool Delete(Guid id);
    }
}
