using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GenertelPoc.Common;
namespace GenertelPoc.Service.Queries.Handlers
{
    class GetWizardQueryHandler : IRequestHandler<GetWizardQuery, WizardViewModel>
    {

        public async Task<WizardViewModel> Handle(GetWizardQuery request, CancellationToken cancellationToken)
        {
            var a = new WizardViewModel
            {
                Pages = new List<IPageViewModel>()
                {
                    new FirstPageViewModel{
                        FullName = new UserInput<string>("sandor", ValidationMessage.VAL_100,ValidationMessage.VAL_103),
                        Age = new UserInput<int>(4,ValidationMessage.VAL_175)
                    }
                    ,
                      new SecondPageViewModel()
                }
            };
            return await Task.FromResult<WizardViewModel>(a);
        }
    }
}
