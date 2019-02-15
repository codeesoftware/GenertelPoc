using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenertelPoc.Common.Controls
{
    public class Input<TValueType>
    {
        public string Label { get; set; }
        public TValueType Value { get; set; }
        public string ValidationsString => String.Join("|", Validations);

        public IEnumerable<ValidationMessage> Validations { get; set; }

        public Input(string label, TValueType value, params ValidationMessage[] validations)
        {
            if (string.IsNullOrWhiteSpace(label))
            {
                throw new ArgumentException("message", nameof(label));
            }

            Label = label;
            Value = value;
            Validations = validations;
        }

       
    }
}
