using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Lesson1NonNullArgument
    {
        private string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Lesson1NonNullArgument(string value)
        {
            _value = value;
        }

        public string Value
        {
            get 
            {
                return _value;
            }
        }
    }
}
