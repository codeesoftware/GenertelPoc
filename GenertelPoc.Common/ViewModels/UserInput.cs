using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Common.ViewModels
{
    public class UserInput<TValueType>
    {
        public TValueType Value { get; set; }

        public IEnumerable<string> Validations { get; }
        public UserInput(TValueType value, params string[] validations)
        {
            Value = value;
            Validations = validations;
        }

        public UserInput(params string[] validations) : this(default(TValueType), validations)
        {
        }
    }
}
