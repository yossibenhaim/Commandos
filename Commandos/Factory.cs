using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    // C# 7.3 does not support property initializers in interfaces.
    // Move the property to a class or use only a getter in the interface.

    internal interface IFactory
    {
        List<IFactory> myList { get; }

    }
}
