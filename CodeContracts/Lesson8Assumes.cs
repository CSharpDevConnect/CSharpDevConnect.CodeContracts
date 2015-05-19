using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    // Pretend this is some third party class you are unable to modify the source for
    class ThirdPartyClass
    {
        private string _value;

        public ThirdPartyClass(string value)
        {
            _value = value;
        }

        // Pretend this is some method that you know for a fact always returns a proper string value.
        public string Value
        {
            get
            {
                return _value;
            }
        }
    }

    class Lesson8Assumes
    {
        private readonly ThirdPartyClass _thirdPartyClass;

        public Lesson8Assumes(ThirdPartyClass thirdPartyClass)
        {
            Contract.Requires<ArgumentNullException>(thirdPartyClass != null, "thirdPartyClass");
            _thirdPartyClass = thirdPartyClass;
        }

        /// <summary>
        /// Can you find a way to satisfy the static analyzer to ensure the contract?
        /// </summary>
        public string Value
        {
            get
            {
                Contract.Ensures(!String.IsNullOrWhiteSpace(Contract.Result<string>()));
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
