using System.Collections.Generic;

namespace GenertelPoc.Common.Controls
{
    public class Dropdown<TValueType>
    {
        public TValueType Value { get; set; }

        public IEnumerable<TValueType> Options { get; set; }

        public IEnumerable<string> Validations { get; set; }

        public Dropdown(TValueType value,IEnumerable<TValueType> options, params string[] validations)
        {
            Value = value;
            Options = options;
            Validations = validations;
        }

     
    }
}
