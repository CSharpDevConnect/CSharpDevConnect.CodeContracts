using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Answer2NonNullReturn
    {
        private string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Answer2NonNullReturn(string value)
        {
            Contract.Requires<ArgumentNullException>(value != null, "value");
            _value = value;
        }

        /// <summary>
        /// Make sure that this property never returns null
        /// </summary>
        public string Value
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                return _value;
            }
        }
    }
}
