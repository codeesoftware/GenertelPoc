using System.Collections.Generic;

namespace GenertelPoc.Common.ViewModels
{
    public class MessageViewModel
    {
        public IDictionary<ValidationMessage, string> ValidationMessages { get; set; }

        public MessageViewModel()
        {
            ValidationMessages = new Dictionary<ValidationMessage, string>();
        }
    }
}
