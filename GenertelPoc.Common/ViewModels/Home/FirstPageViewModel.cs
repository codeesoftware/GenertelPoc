using GenertelPoc.Common.Controls;
using System.ComponentModel.DataAnnotations;

namespace GenertelPoc.Common.ViewModels.Home
{
    public class FirstPageViewModel:IPageViewModel
    {
        public Input<string> FullName { get; set; }
        public Input<int> Age { get; set; }
        public Dropdown<string> Damage { get; set; }
        public int PageId => 1;
    }
}
