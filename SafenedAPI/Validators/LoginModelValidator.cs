using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SafenedAPI.Models;

namespace SafenedAPI.Validators
{
    public class LoginModelValidator : AbstractValidator<LoginModel>
    {
        public LoginModelValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("The user name can not be null");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("The user name must be at least 3 character long");
            RuleFor(x => x.Password).NotNull().WithMessage("The password can not be null");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("The password must be at least 3 character long");
        }
    }
}
