using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Service.Queries.Handlers
{
    class GetWizardQueryHandler : IRequestHandler<GetWizardQuery, WizardViewModel>
    {
        const string VAL_100 = "VAL_100";
        const string VAL_103 = "VAL_103";
        const string VAL_175 = "VAL_175";

        public async Task<WizardViewModel> Handle(GetWizardQuery request, CancellationToken cancellationToken)
        {
            var a = new WizardViewModel
            {
                Pages = new List<IPageViewModel>()
                {
                    new FirstPageViewModel{
                        FullName = new UserInput<string>("sandor",VAL_100,VAL_103),
                        Age = new UserInput<int>(4,VAL_175)
                    }
                    ,
                      new SecondPageViewModel()
                }
            };
            return await Task.FromResult<WizardViewModel>(a);
        }
    }
}
