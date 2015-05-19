using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public interface ILesson5InterfaceClassContract
    {
        string Value
        {
            get;
        }
    }

    class Lesson5InterfaceClassContract : ILesson5InterfaceClassContract
    {
        private string _value;

        /// <summary>
        /// Do not allow a null value to be assigned.
        /// </summary>
        /// <param name="value">The value.</param>
        public Lesson5InterfaceClassContract(string value)
        {
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
    }
}
