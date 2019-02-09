using GenertelPoc.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GenertelPoc.Presentation.ApiControllers
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
                Pages = new List<PageViewModel>()
                {
                    new PageViewModel{
                        PageId =1,
                        Inputs = new List<Input> {
                            new TextInput{ Name = "name"},
                            new TextInput{ Name = "email"},
                        }
                    }
                }
            };
            return Ok(homeWizardViewModel);
        }
    }
}
