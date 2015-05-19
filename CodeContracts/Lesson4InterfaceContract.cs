using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    interface Lesson4InterfaceContract
    {
        /// <summary>
        /// Force this to never be allowed to return null.
        /// </summary>
        string Value { get; }
    }
}
