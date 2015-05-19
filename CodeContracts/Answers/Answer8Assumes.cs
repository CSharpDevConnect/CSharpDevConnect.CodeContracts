using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    class Answer8Assumes
    {
        private readonly ThirdPartyClass _thirdPartyClass;

        public Answer8Assumes(ThirdPartyClass thirdPartyClass)
        {
            Contract.Requires<ArgumentNullException>(thirdPartyClass != null, "thirdPartyClass");
            _thirdPartyClass = thirdPartyClass;
        }

        public string Value
        {
            get
            {
                Contract.Ensures(!String.IsNullOrWhiteSpace(Contract.Result<string>()));

                // Note that this line must appear down here because Contract.Ensures and Contract.Requires MUST be the first lines in a routine
                Contract.Assume(!String.IsNullOrWhiteSpace(_thirdPartyClass.Value));

                return _thirdPartyClass.Value;
            }
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_thirdPartyClass != null);
        }
    }
}
