using GenertelPoc.Common.ViewModels;
using MediatR;

namespace GenertelPoc.Service.Commands
{
    public class CreateOfferCommand: IRequest
    {
        public WizardViewModel Wizard { get; }

        public CreateOfferCommand(WizardViewModel wizard)
        {
            Wizard = wizard ?? throw new System.ArgumentNullException(nameof(wizard));
        }
    }
}
