using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    [ContractClass(typeof(Answer4InterfaceContractContract))]
    interface Answer4InterfaceContract
    {
        /// <summary>
        /// Force this to never be allowed to return null.
        /// </summary>
        string Value { get; }
    }

    [ContractClassFor(typeof(Answer4InterfaceContract))]
    internal abstract class Answer4InterfaceContractContract : Answer4InterfaceContract
    {
        public string Value
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

                return default(string);
            }
        }
    }
}
