using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    [ContractClass(typeof(Answer5InterfaceClassContractContract))]
    public interface IAnswer5InterfaceClassContract
    {
        string Value
        {
            get;
        }
    }

    [ContractClassFor(typeof(IAnswer5InterfaceClassContract))]
    internal abstract class Answer5InterfaceClassContractContract : IAnswer5InterfaceClassContract
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

    class Answer5InterfaceClassContract : IAnswer5InterfaceClassContract
    {
        private readonly string _value;

        /// <summary>
        /// Do not allow a null value to be assigned.
        /// </summary>
        /// <param name="value">The value.</param>
        public Answer5InterfaceClassContract(string value)
        {
            Contract.Requires<ArgumentException>(value != null, "value");
            _value = value;
        }

        /// <summary>
        /// Force this to never return null and can never change.
        /// </summary>
        public virtual string Value
        {
            get
            {
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
