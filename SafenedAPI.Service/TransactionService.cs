using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Data.Repository;

namespace SafenedAPI.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly IBankAccountRepository bankAccountRepository;

        private readonly IUserRepository userRepository;

        public TransactionService(IBankAccountRepository bankAccountRepository, IUserRepository userRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.userRepository = userRepository;
        }

        public bool Deposit(Guid senderId, Guid receiverId, decimal amount)
        {
            //TODO: Check this request send by sender
            var senderAccount = bankAccountRepository.GetById(senderId);
            var receiverAccount = bankAccountRepository.GetById(receiverId);

            if (senderAccount?.Balance < amount)
            {
                return false;
            }

            if (senderAccount != null && receiverAccount != null)
            {
                senderAccount.Balance = senderAccount.Balance - amount;
                receiverAccount.Balance = receiverAccount.Balance + amount;

                bankAccountRepository.UpdateAsync(senderAccount);
                bankAccountRepository.UpdateAsync(receiverAccount);
                return true;
            }

            return false;
        }

        public bool Withdraw(Guid senderId, Guid receiverId, decimal amount)
        {
            var senderAccount = bankAccountRepository.GetById(senderId);
            var receiverAccount = bankAccountRepository.GetById(receiverId);

            if (receiverAccount?.Balance < amount)
            {
                return false;
            }

            if (senderAccount != null && receiverAccount != null)
            {
                senderAccount.Balance = senderAccount.Balance + amount;
                receiverAccount.Balance = receiverAccount.Balance - amount;

                bankAccountRepository.UpdateAsync(senderAccount);
                bankAccountRepository.UpdateAsync(receiverAccount);
                return true;
            }

            return false;
        }
    }
}
