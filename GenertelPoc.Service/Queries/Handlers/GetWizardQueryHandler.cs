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
                        FullName = new Input<string>("Teljes név","Sandor Imre", ValidationMessage.VAL_100,ValidationMessage.VAL_103),
                        Age = new Input<int>("Kor",27,ValidationMessage.VAL_175),
                        Damage = new Dropdown<string>("Káreseméy","-",new[]{ "Égési sérülés","Reaktor"},ValidationMessage.VAL_100)
                    }
                    ,
                      new SecondPageViewModel(){
                          Email =  new Input<string>("E-mail","sandor@jani.hu", ValidationMessage.VAL_206,ValidationMessage.VAL_301),
                          PasswordConfirmation  =  new Input<string>("Jelszó ismét",String.Empty, ValidationMessage.VAL_100),
                          Password  =  new Input<string>("Jelszó",String.Empty, ValidationMessage.VAL_100,$"{ValidationMessage.VAL_300}:passwordConfirmation"),
                      }
                }
            };
            return await Task.FromResult<WizardViewModel>(a);
        }
    }
}
