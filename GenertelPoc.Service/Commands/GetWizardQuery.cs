using GenertelPoc.Common.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Service.Commands
{
    public class GetWizardQuery: IRequest<WizardViewModel>
    {
    }
}
