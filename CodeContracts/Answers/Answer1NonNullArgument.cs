using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Answer1NonNullArgument
    {
        private string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Answer1NonNullArgument(string value)
        {
            Contract.Requires<ArgumentNullException>(value != null, "value");
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
