using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GenertelPoc.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeWizardApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<WizardViewModel> Start()
        {
            var homeWizardViewModel = new WizardViewModel
            {
                Pages = new List<IPageViewModel>()
                {
                    new FirstPageViewModel()
                    ,
                      new SecondPageViewModel()
                }
            };
            return Ok(homeWizardViewModel);
        }


        [HttpPost]
        public ActionResult End([FromBody] WizardViewModel wizardViewModel)
        {

            return NoContent();
        }
    }
}
