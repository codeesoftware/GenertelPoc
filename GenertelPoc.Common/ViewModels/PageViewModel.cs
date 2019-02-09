using System.Collections.Generic;

namespace GenertelPoc.Common.ViewModels
{
    public class PageViewModel
    {
        public int PageId { get; set; }
        public IEnumerable<Input> Inputs { get; set; }
    }
}