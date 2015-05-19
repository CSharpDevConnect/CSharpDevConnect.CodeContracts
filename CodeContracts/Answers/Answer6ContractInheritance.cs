using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    class Answer6ContractInheritance : Answer5InterfaceClassContract
    {
        /// <summary>
        /// Satisfy the contract for Answer5InterfaceClassContract
        /// </summary>
        public Answer6ContractInheritance(string value)
            : base(value)
        {
            // Remember, C# constructors are not inherited, so this is treated as a separate routine for contracts
            // That is, we have B.ctor calling A.ctor, and the analyzer makes no assumptions about what happens in between the calls
            Contract.Requires<ArgumentNullException>(value != null, "value");
        }

        /// <summary>
        /// Can you force this to be not null or whitespace?
        /// </summary>
        public override string Value
        {
            get
            {
                // If you uncomment the line below and run the static analysis (aka Build) you will see:
                // CodeContracts: ensures unproven: !String.IsNullOrWhiteSpace(Contract.Result<string>()). Are you making some assumption on get_Length that the static checker is unaware of?
                // Because there is no way in your code to prove that the return value cannot be whitespace without modifying the requires.

                // Contract.Ensures(!String.IsNullOrWhiteSpace(Contract.Result<string>()));

                return base.Value;
            }
        }
    }
}
