using GenertelPoc.Common;
using GenertelPoc.Common.Controls;
using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
                        FullName = new Input<string>("Sandor |Imre", ValidationMessage.VAL_100,ValidationMessage.VAL_103),
                        Age = new Input<int>(27,ValidationMessage.VAL_175),
                        Damage = new Dropdown<string>("-",new[]{ "Égési sérülés","Reaktor"})
                    }
                    ,
                      new SecondPageViewModel(){
                          Email =  new Input<string>("sandor@jani.hu", ValidationMessage.VAL_100),
                          Password  =  new Input<string>(String.Empty, ValidationMessage.VAL_100),
                      }
                }
            };
            return await Task.FromResult<WizardViewModel>(a);
        }
    }
}
