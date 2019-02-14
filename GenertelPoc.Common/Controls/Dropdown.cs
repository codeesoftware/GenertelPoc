using System.Collections.Generic;
using System.Linq;

namespace GenertelPoc.Common.Controls
{
    public class Dropdown<TValueType>
    {

        public TValueType Value { get; set; }
        //public KeyValuePair<int, TValueType> Selected { get; set; }

        public IEnumerable<TValueType> Options { get; set; }

        public IEnumerable<string> Validations { get; set; }

        public Dropdown(TValueType value,IEnumerable<TValueType> options, params string[] validations)
        {
        //    Selected = value;
      //      var tempOptions = new List<KeyValuePair<int, TValueType>> ();
    //        int index = 0;
            //foreach (TValueType option in options)
            //{
            //    tempOptions.Add(new KeyValuePair<int, TValueType>(++index, option));
            //}
            //Options = tempOptions;
            Options = options;
            Value = value;
            Validations = validations;
        }

     
    }
}
