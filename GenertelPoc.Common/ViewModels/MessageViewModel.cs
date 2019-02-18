using System.Collections.Generic;

namespace GenertelPoc.Common.ViewModels
{
    public class MessageViewModel
    {
        public IDictionary<string, string> ValidationMessages { get; set; }

        public MessageViewModel()
        {
            ValidationMessages = new Dictionary<string, string>();
        }
    }
}
