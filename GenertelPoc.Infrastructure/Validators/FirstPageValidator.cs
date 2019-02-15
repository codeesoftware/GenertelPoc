using FluentValidation;
using GenertelPoc.Common.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Infrastructure.Validators
{
    class FirstPageValidator: AbstractValidator<FirstPageViewModel>
    {
        public FirstPageValidator()
        {
            RuleFor(vm => vm.FullName.Value).Equal("sandor");
        }
    }
}
