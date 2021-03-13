using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafenedAPI.Service
{
    public interface ITransactionService
    {
        bool Deposit(Guid senderId, Guid receiverId, decimal amount);

        bool Withdraw(Guid senderId, Guid receiverId, decimal amount);
    }
}
