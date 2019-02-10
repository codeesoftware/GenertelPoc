using GenertelPoc.Common.ViewModels;
using MediatR;

namespace GenertelPoc.Service.Queries
{
    public class GetWizardQuery: IRequest<WizardViewModel>
    {
    }
}
