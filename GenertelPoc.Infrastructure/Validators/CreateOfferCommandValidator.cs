using FluentValidation;
using GenertelPoc.Service.Commands;
using System.Linq;

namespace GenertelPoc.Infrastructure.Validators
{
    public class CreateOfferCommandValidator : AbstractValidator<CreateOfferCommand>
    {
        public CreateOfferCommandValidator()
        {
            RuleFor(x => x.Wizard.Pages).NotEmpty();
            //RuleFor(x => x.Vat).NotEmpty();

        }
    }
}
