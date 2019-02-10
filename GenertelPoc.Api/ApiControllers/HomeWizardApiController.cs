using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using GenertelPoc.Service.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public ActionResult End([FromBody] WizardViewModel wizardViewModel)
        {

            return NoContent();
        }
    }
}
