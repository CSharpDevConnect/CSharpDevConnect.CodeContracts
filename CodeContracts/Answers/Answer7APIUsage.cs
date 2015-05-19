using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    /// <summary>
    /// Can you figure out why this is reporting:
    /// CodeContracts: invariant unproven: _value.Trim().Length > 0. Is it an off-by-one? Or, Are you making some assumption on get_Length that the static checker is unaware of?
    /// </summary>
    class Answer7APIUsage
    {
        private readonly string _value;

        public Answer7APIUsage(string value)
        {
            Contract.Requires<ArgumentException>((value != null) && (value.Trim().Length > 0));
            // When we assign the result of trim, the contract is satisfied here
            _value = value.Trim();
        }

        public string Value
        {
            get
            {
                // However, when we trimmed in the contract here, we were creating a *NEW* string with only the length contract
                Contract.Ensures((Contract.Result<string>() != null) && (Contract.Result<string>().Length > 0));
                return _value;
            }
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_value != null);
            // However, when we trimmed in the contract here, we were creating a *NEW* string with only the length contract
            Contract.Invariant(_value.Length > 0);
        }
    }
}
