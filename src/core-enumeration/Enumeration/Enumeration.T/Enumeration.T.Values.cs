#nullable enable

using System.Collections.Generic;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static IReadOnlyCollection<TEnumeration> Values
            =>
            EnumerationReadOnly<TEnumeration>.Instance.Values;
    }
}
