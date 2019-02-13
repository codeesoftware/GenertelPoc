﻿using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using MediatR;
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
                    new FirstPageViewModel()
                    ,
                      new SecondPageViewModel()
                }
            };
            return await Task.FromResult<WizardViewModel>(a);
        }
    }
}