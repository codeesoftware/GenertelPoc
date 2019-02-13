using System.ComponentModel.DataAnnotations;

namespace GenertelPoc.Common.ViewModels.Home
{
    public class FirstPageViewModel:IPageViewModel
    {
        [Required]
        public UserInput<string> FullName { get; set; }
        public int PageId => 1;
    }
}
