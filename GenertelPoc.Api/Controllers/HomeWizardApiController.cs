using GenertelPoc.Common.ViewModels;
using GenertelPoc.Service.Commands;
using GenertelPoc.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GenertelPoc.Api.Controllers
{
    public class HomeWizardApiController : BasicApiController
    {
        private readonly IMediator mediator;

        public HomeWizardApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public HomeWizardApiController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<WizardViewModel>> Start()
        {
            WizardViewModel vm = await mediator.Send(new GetWizardQuery());
            return Ok(vm);
        }

        [HttpGet]
        public async Task<ActionResult<bool>> IsUniqueEmail(string email)
        {
            bool result = await mediator.Send(new IsUniqueEmailQuery() { Email = email });
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult> End([FromBody] WizardViewModel wizardViewModel)
        {
             await mediator.Send(new CreateOfferCommand(wizardViewModel));

            return NoContent();
        }
    }
}
