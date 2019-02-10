using GenertelPoc.Common.ViewModels;
using GenertelPoc.Service.Commands;
using GenertelPoc.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GenertelPoc.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeWizardApiController : ControllerBase
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


        [HttpPost]
        public async Task<ActionResult> End([FromBody] WizardViewModel wizardViewModel)
        {
             await mediator.Send(new CreateOfferCommand(wizardViewModel));

            return NoContent();
        }
    }
}
