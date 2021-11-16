using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.Age).GreaterThan(18);
            RuleFor(m => m.MembershipTimeId).NotEmpty();
            RuleFor(m => m.FirstName).MinimumLength(3);
        }
    }
}
