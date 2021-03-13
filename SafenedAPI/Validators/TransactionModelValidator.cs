using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SafenedAPI.Models;

namespace SafenedAPI.Validators
{
    public class TransactionModelValidator : AbstractValidator<TransactionModel>
    {
        public TransactionModelValidator()
        {
            RuleFor(x => x.SenderId).NotEmpty().NotNull().WithMessage("SenderId can not be null");
            RuleFor(x => x.ReceiverId).NotEmpty().NotNull().WithMessage("ReceiverId can not be null");
            RuleFor(x => x.Amount).NotEmpty().NotNull().WithMessage("Amount can not be null");
            RuleFor(x => x.Amount).GreaterThanOrEqualTo(0).WithMessage("Amount must be greater than 0");
        }
    }
}
