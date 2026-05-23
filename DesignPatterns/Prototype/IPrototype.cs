using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// IPrototype interface defines the contract for all objects that support cloning.
    /// This is a core part of the Prototype design pattern.
    /// </summary>
    internal interface IPrototype<T>
    {
        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        /// <returns>A cloned copy of the object</returns>
        T clone();
    }
}
