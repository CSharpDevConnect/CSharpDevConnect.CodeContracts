using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    class Lesson6ContractInheritance : Answer5InterfaceClassContract
    {
        /// <summary>
        /// Satisfy the contract for Answer5InterfaceClassContract
        /// </summary>
        public Lesson6ContractInheritance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Can you force this to be not null or whitespace?
        /// </summary>
        public override string Value
        {
            get
            {
                return base.Value;
            }
        }
    }
}
