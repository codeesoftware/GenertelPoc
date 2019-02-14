using GenertelPoc.Common.ViewModels;
using GenertelPoc.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GenertelPoc.Api.Controllers
{
    public class MessageApiController : BasicApiController
    {
        private readonly IMediator mediator;

        public MessageApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }
     

        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<ActionResult<MessageViewModel>> GetHomeWizardMessages()
        {
            MessageViewModel vm = await mediator.Send(new GetValidationMessageQuery());
            return Ok(vm);
        }
    }
}