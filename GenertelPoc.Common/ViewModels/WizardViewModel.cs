using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Common.ViewModels
{
    public class WizardViewModel
    {
       public IEnumerable<PageViewModel> Pages {get;set;}

        public int CurrentPageId { get; set; }
    }
}
