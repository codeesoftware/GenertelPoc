using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Common.Controls
{
    public class Input<TValueType>
    {
        public TValueType Value { get; set; }

        public IEnumerable<ValidationMessage> Validations { get; set; }

        public Input(TValueType value, params ValidationMessage[] validations)
        {
            Value = value;
            Validations = validations;
        }

        public Input() : this(default(TValueType))
        {
        }
    }
}
