using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Lesson2NonNullReturn
    {
        private string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Lesson2NonNullReturn(string value)
        {
            _value = value;
        }
        
        /// <summary>
        /// Make sure that this property never returns null
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
        }
    }
}
