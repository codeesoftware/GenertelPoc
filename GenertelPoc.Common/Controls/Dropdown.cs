using System;
using System.Collections.Generic;
using System.Linq;

namespace GenertelPoc.Common.Controls
{
    public class Dropdown<TValueType>
    {
        public string Label { get; set; }
        public TValueType Value { get; set; }
        public IEnumerable<TValueType> Options { get; set; }
        public string ValidationsString => String.Join("|", Validations);
        public IEnumerable<ValidationMessage> Validations { get; set; }

        public Dropdown(string label,TValueType value,IEnumerable<TValueType> options, params ValidationMessage[] validations)
        {
            if (string.IsNullOrWhiteSpace(label))
            {
                throw new ArgumentException("message", nameof(label));
            }

            Label = label;
            Options = options;
            Value = value;
            Validations = validations;

        }


    }
}
