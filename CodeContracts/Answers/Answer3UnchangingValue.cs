using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Answer3UnchangingValue
    {
        /// <summary>
        /// Force _value to be unable to change
        /// </summary>
        private readonly string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Answer3UnchangingValue(string value)
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

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_value != null);
        }
    }
}
