using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Lesson3UnchangingValue
    {
        /// <summary>
        /// Force _value to be unable to change.  Hint, this declaration may change, but a contract is also needed
        /// </summary>
        private string _value;

        /// <summary>
        /// Prevent this class from being constructed with a null parameter.
        /// </summary>
        public Lesson3UnchangingValue(string value)
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
