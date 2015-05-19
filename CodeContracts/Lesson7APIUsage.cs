using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    /// <summary>
    /// Can you figure out why this is reporting:
    /// CodeContracts: invariant unproven: _value.Trim().Length > 0. Is it an off-by-one? Or, Are you making some assumption on get_Length that the static checker is unaware of?
    /// Hint: think about how strings work.
    /// </summary>
    class Lesson7APIUsage
    {
        private readonly string _value;

        public Lesson7APIUsage(string value)
        {
            Contract.Requires<ArgumentException>((value != null) && (value.Trim().Length > 0));
            _value = value.Trim();
        }

        public string Value
        {
            get
            {
                Contract.Ensures((Contract.Result<string>() != null) && (Contract.Result<string>().Trim().Length > 0));
                return _value;
            }
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_value != null);
            Contract.Invariant(_value.Trim().Length > 0);
        }
    }
}
