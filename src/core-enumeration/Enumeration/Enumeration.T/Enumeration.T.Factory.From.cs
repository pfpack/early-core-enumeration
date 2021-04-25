#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public TEnumeration From(string value)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            return factory.Invoke(value);
        }
    }
}
