using GenertelPoc.Common.Controls;

namespace GenertelPoc.Common.ViewModels.Home
{
    public class SecondPageViewModel:IPageViewModel
    {
        public Input<string> Email { get; set; }

        public Input<string> Password { get; set; }

        public int PageId => 2;
    }
}
