using FluentValidation;
using GenertelPoc.Service.Commands;
using System.Linq;

namespace GenertelPoc.Infrastructure.Validators
{
    public class CreateOfferCommandValidator : AbstractValidator<CreateOfferCommand>
    {
        public CreateOfferCommandValidator()
        {

        }
    }
}
