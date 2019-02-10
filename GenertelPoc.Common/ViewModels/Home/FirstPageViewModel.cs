namespace GenertelPoc.Common.ViewModels.Home
{
    public class FirstPageViewModel:IPageViewModel
    {
        public string FullName { get; set; }
        public int PageId => 1;
    }
}
